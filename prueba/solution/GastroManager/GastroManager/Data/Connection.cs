using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Data
{
    public static class Connection
    {

        public static string ConnectionString { get; } = @"Server=.\SQLEXPRESS;Database=DishManagmentDB;Trusted_Connection=True;TrustServerCertificate=True";

    }
}
