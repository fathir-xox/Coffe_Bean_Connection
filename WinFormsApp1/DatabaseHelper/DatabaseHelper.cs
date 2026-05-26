using System;
using Npgsql;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.DatabaseHelper
{
    public class DatabaseHelper
    {
        private static string connString = "Host=ep-wispy-river-aoxu1bki-pooler.c-2.ap-southeast-1.aws.neon.tech; Database=neondb; Username=neondb_owner; Password=npg_8sXeqj6NgdTE; SSL Mode=VerifyFull; Channel Binding=Require;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
