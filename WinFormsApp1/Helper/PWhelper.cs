using System;
using System.Security.Cryptography;
using System.Text;

namespace FinalProjek.Helper
{
    public static class PWhelper
    {
        public static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            string inputHash = HashPassword(inputPassword);
            return inputHash == storedHash;
        }
    }
}