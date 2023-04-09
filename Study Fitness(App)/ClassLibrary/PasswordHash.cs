using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PasswordHash
    {
        public static string HashPasswordWithSalt(byte[] password, byte[] salt)
        {
            byte[] saltedPassword = new byte[password.Length + salt.Length];
            Array.Copy(password, saltedPassword, password.Length);
            Array.Copy(salt, 0, saltedPassword, password.Length, salt.Length);

            using (var sha256 = SHA256.Create())
            {
                byte[] hashed = sha256.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hashed) + ":" + Convert.ToBase64String(salt);
            }
        }

        public static string HashPassword(string password)
        {
            byte[] salt = GenerateSalt(); // Call your own method to generate a salt
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            string hashedPassword = HashPasswordWithSalt(passwordBytes, salt);
            return hashedPassword;
        }

        public static byte[] GenerateSalt()
        {
            const int saltLength = 16; // You can adjust the salt length as needed
            byte[] salt = new byte[saltLength];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }
    }
}
