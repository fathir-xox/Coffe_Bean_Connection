using System;
using DotNetEnv;
namespace FinalProjek.Database
{
    public class DbContext
    {
        
        public string? connStr;

        public DbContext()
        {
            Env.Load();
            connStr = Environment.GetEnvironmentVariable("CONN_STR");
        }
    }
}
