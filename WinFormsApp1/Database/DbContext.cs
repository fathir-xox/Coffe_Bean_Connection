using System;
namespace FinalProjek.Database
{
    public class DbContext
    {
        public string? connStr;

        public DbContext()
        {
            // If you want to load a .env file at runtime, add a reference to a library
            // such as DotNetEnv and call Env.Load() here. For now just read the
            // environment variable directly so the project builds without that package.
            connStr = Environment.GetEnvironmentVariable("CONN_STR");
        }
    }
}
