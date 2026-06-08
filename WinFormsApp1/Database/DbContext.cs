using System;
<<<<<<< HEAD
=======
using DotNetEnv;
>>>>>>> 037f6063f0d53e584be41d03f5535c8401a508bb
namespace FinalProjek.Database
{
    public class DbContext
    {
<<<<<<< HEAD
=======
        
>>>>>>> 037f6063f0d53e584be41d03f5535c8401a508bb
        public string? connStr;

        public DbContext()
        {
<<<<<<< HEAD
            // If you want to load a .env file at runtime, add a reference to a library
            // such as DotNetEnv and call Env.Load() here. For now just read the
            // environment variable directly so the project builds without that package.
=======
            Env.Load();
>>>>>>> 037f6063f0d53e584be41d03f5535c8401a508bb
            connStr = Environment.GetEnvironmentVariable("CONN_STR");
        }
    }
}
