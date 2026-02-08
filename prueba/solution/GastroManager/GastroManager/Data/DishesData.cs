using GastroManager.Entidades;
using GastroManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using GastroManager.DTOs;

namespace GastroManager.Data
{
    public class DishesData : IDishesRepository
    {

        public List<Dishes> Select()
        {

            var connectionString = Connection.ConnectionString;

            using (var conn = new SqlConnection(connectionString))
            {

                conn.Open();

                List<Dishes> Dishes = new List<Dishes>();

                //Consulta - Listar Platos 
                string query = "SELECT * FROM Dishes";

                using (SqlCommand command = new SqlCommand(query, conn))
                { 

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Dishes.Add(new Dishes()
                            {
                                DishId = Convert.ToInt32(reader["Dish_Id"]),
                                BaseServings = Convert.ToInt32(reader["Base_Servings"]),
                                CategoryId = Convert.ToInt32(reader["Category_Id"]),
                                Description = Convert.ToString(reader["Description"])!,
                                DishName = Convert.ToString(reader["Dish_Name"])!,
                                FinalPriceForClients = Convert.ToDecimal(reader["Final_Price_for_Clients"]),
                                ImagePath = Convert.ToString(reader["Image_Path"])!,
                                SourceRecipeLink = Convert.ToString(reader["Source_Recipe_Link"])!
                            });

                        }

                    }

                }

                return Dishes;

            }

        }

        public List<Dishes> Filter(string categoryName, string dishName, bool availableIngredients, int minPrice, int maxPrice)
        {

            if (categoryName == "All categories") categoryName = "";


            var connectionString = Connection.ConnectionString;

            using (var conn = new SqlConnection(connectionString))
            {

                conn.Open();

                List<Dishes> Dishes = new List<Dishes>();

                //Consulta - Listar Platos 
                string query = @"SELECT 
                                D.Dish_Id,
                                D.Dish_Name,
                                D.Base_Servings,
                                D.Category_Id,
                                D.Image_Path,
                                D.Source_Recipe_Link,
                                D.Description,
                                D.Final_Price_for_Clients

                                FROM Dishes D
                                JOIN Categories C ON D.Category_Id = C.Category_Id
                                JOIN Dishes_Ingredients DI ON D.Dish_Id = DI.Dish_Id
                                JOIN Ingredients I ON DI.Ingredient_Id = I.Ingredient_Id
                                WHERE D.Dish_Name LIKE '%' + @dishName + '%' 
                                AND C.Category_Name LIKE '%' + @categoryName + '%'
                                AND (Final_Price_for_Clients >= @minPrice AND Final_Price_for_Clients <= @maxPrice)";

                //Seleccionar el filtro mostrara solo los platos con ingredientes disponibles
                if (availableIngredients)
                {
                    query += " AND I.Available_count_in_stock > 0";
                }

                //Consulta Listar Platos
                string queryGroupBy = @"
                                        GROUP BY 
                                        D.Dish_Id,
                                        D.Dish_Name,
                                        D.Base_Servings,
                                        D.Category_Id,
                                        D.Image_Path,
                                        D.Source_Recipe_Link,
                                        D.Description,
                                        D.Final_Price_for_Clients";

                //Unir consultas para evitar duplicados
                query += queryGroupBy;

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@dishName", dishName);
                    command.Parameters.AddWithValue("@categoryName", categoryName);
                    command.Parameters.AddWithValue("@minPrice", minPrice);
                    command.Parameters.AddWithValue("@maxPrice", maxPrice);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Dishes.Add(new Dishes()
                            {
                                DishId = Convert.ToInt32(reader["Dish_Id"]),
                                BaseServings = Convert.ToInt32(reader["Base_Servings"]),
                                CategoryId = Convert.ToInt32(reader["Category_Id"]),
                                Description = Convert.ToString(reader["Description"])!,
                                DishName = Convert.ToString(reader["Dish_Name"])!,
                                FinalPriceForClients = Convert.ToDecimal(reader["Final_Price_for_Clients"]),
                                ImagePath = Convert.ToString(reader["Image_Path"])!,
                                SourceRecipeLink = Convert.ToString(reader["Source_Recipe_Link"])!
                            });

                        }

                    }

                }

                return Dishes;

            }


        }

        public DishReadDTO? GetById(int Id)
        {

            var connectionString = Connection.ConnectionString;

            using (var conn = new SqlConnection(connectionString))
            {

                conn.Open();

                //Consulta - Listar Platos 
                string query = @"SELECT

                                D.Dish_Id,
                                D.Dish_Name,
                                C.Category_Name,
                                D.Base_Servings,
                                SUM(R.Time_In_Minutes) AS Time_In_Minutes,
                                D.Final_Price_for_Clients,
                                D.Description,
                                D.Image_Path

                                FROM Dishes D
                                JOIN Categories C ON D.Category_Id = C.Category_Id
                                JOIN Recipes R ON R.Dish_Id = D.Dish_Id

                                WHERE D.Dish_Id = @Id
                                GROUP BY 

                                D.Dish_Id,
                                D.Dish_Name,
                                C.Category_Name,
                                D.Base_Servings,
                                D.Image_Path,
                                D.Source_Recipe_Link,
                                D.Description,
                                D.Final_Price_for_Clients

                                ORDER BY Dish_Id";

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@Id", Id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            return new DishReadDTO()
                            {
                                DishId = Convert.ToInt32(reader["Dish_Id"]),
                                BaseServings = Convert.ToInt32(reader["Base_Servings"]),
                                CategoryName = Convert.ToString(reader["Category_Name"])!,
                                Description = Convert.ToString(reader["Description"])!,
                                DishName = Convert.ToString(reader["Dish_Name"])!,
                                FinalPriceForClients = Convert.ToDecimal(reader["Final_Price_for_Clients"]),
                                ImagePath = Convert.ToString(reader["Image_Path"])!,
                                Time = Convert.ToInt32(reader["Time_In_Minutes"])
                            };

                        }
                        else
                        {
                            return null;
                        }

                    }

                }

            }

        }

        public void UpdateServings(int dishId, int baseServings)
        {

            var connectionString = Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                string query = @"UPDATE
                                Dishes 
                                SET Base_Servings = @Base_Servings
                                WHERE Dish_Id = @Id";

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@Base_Servings", baseServings);
                    command.Parameters.AddWithValue("@Id", dishId);

                    command.ExecuteNonQuery();

                }

            }

        }
    }
}
