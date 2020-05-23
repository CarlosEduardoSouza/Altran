using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Business.Services
{
    public class CriptografiaByCript
    {
        public static string HashGeneration(string password)
        {
            // Definindo o valor de caracteres:
            const int workfactor = 10;

            string salt = BCrypt.Net.BCrypt.GenerateSalt(workfactor);
            string hash = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hash;
        }

        public static bool PasswordCompare(string hash, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
