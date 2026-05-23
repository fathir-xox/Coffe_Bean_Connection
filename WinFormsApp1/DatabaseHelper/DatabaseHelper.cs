using System;
using Npgsql;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.DatabaseHelper
{
    public class DatabaseHelper
    {
        private static string connString = "Host=localhost;Port=5432;Database=PBO LAST;Username=postgres;Password=12345";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
