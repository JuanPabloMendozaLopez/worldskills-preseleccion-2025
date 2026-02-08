using GastroManager.Entidades;
using GastroManager.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Data
{
    public class CategoriesData : ICategoryRepository
    {
        public List<Categories> ListCategories()
        {

            var connectionString = Connection.ConnectionString;


            using (var conn = new SqlConnection(connectionString))
            {

                conn.Open();
                var categories = new List<Categories>();

                string query = "SELECT * FROM Categories";

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            categories.Add(new Categories()
                            {
                                CategoryId = Convert.ToInt32(reader["Category_Id"]),
                                CategoryName = Convert.ToString(reader["Category_Name"])!

                            });

                        }

                    }

                    return categories;

                }


            }

        }
    }
}
