using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace BL
{
    public static class PasswordHasher
    {
        public static string HashPasswordWithSalt(string password, byte[] salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] passBytes = Encoding.Unicode.GetBytes(password);
                byte[] data = new byte[passBytes.Length + salt.Length];
                Buffer.BlockCopy(passBytes, 0, data, 0, passBytes.Length);
                Buffer.BlockCopy(salt, 0, data, passBytes.Length, salt.Length);

                byte[] hash = sha.ComputeHash(data);

                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
