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
            connStr = Environment.GetEnvironmentVariable("Host=ep-wispy-river-aoxu1bki-pooler.c-2.ap-southeast-1.aws.neon.tech; Database=neondb; Username=neondb_owner; Password=npg_8sXeqj6NgdTE; SSL Mode=VerifyFull; Channel Binding=Require;\"");
        }
    }
}
