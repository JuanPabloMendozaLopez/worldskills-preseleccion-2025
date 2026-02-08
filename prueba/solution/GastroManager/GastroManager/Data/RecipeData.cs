using GastroManager.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Data
{
    public class RecipeData : IRecipeRepository
    {
        public List<string> RecipeByDishID(int dishId)
        {

            var connectionString = Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                string query = @"SELECT

                                R.Process_Description

                                FROM Recipes R
                                WHERE Dish_Id = @Id";

                List<string> recipes = new List<string>();

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@Id", dishId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            recipes.Add(Convert.ToString(reader["Process_Description"])!);


                        }

                        
                    }


                }

                return recipes;


            }


        }
    }
}
