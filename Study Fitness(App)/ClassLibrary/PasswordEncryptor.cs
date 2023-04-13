using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PasswordEncryptor
    {
        private const int SaltSize = 16; 
        private const int HashSize = 20; 
        private const int Iterations = 10000;

        public static List<string> HashPassword(string password) 
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            var hashBytes = new byte[HashSize];
            Array.Copy(hash, 0, hashBytes, 0, HashSize);

            // Use the truncated salt and hash byte arrays when storing in the database
            var hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "");
            var saltBytes = new byte[SaltSize];
            Array.Copy(salt, 0, saltBytes, 0, SaltSize);
            var saltedPassword = BitConverter.ToString(saltBytes).Replace("-", "");

            return new List<string>() { hashedPassword, saltedPassword };

        }

        public static bool VerifyPassword(string password, string hashedPassword, string salt) 
        { 
            var saltBytes = Convert.FromBase64String(salt); 
            var hashBytes = Convert.FromBase64String(hashedPassword); 
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations); 
            var enteredHash = pbkdf2.GetBytes(HashSize); 
            for (var i = 0; i < HashSize; i++) 
            { 
                if (hashBytes[SaltSize + i] != enteredHash[i]) 
                    return false;
            } 
            return true;
        }

    }
}
