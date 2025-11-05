using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CryptoManager
    {
        private static readonly Lazy<CryptoManager> _inst = new Lazy<CryptoManager>(() => new CryptoManager());
        public static CryptoManager Instancia { get { return _inst.Value; } }

        private readonly int _iterations = 120000; // seguro para 2025
        private CryptoManager() { }

        public byte[] GenerateSalt(int size)
        {
            var salt = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt); // ✅ Esto sí funciona en C# 7.3
            }
            return salt;
        }

        public string HashPasswordPBKDF2(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, _iterations, HashAlgorithmName.SHA256))
            {
                var hash = pbkdf2.GetBytes(32); // 256 bits
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }

        public bool ConstantTimeEquals(string aHex, string bHex)
        {
            if (aHex == null || bHex == null || aHex.Length != bHex.Length) return false;
            int diff = 0;
            for (int i = 0; i < aHex.Length; i++) diff |= aHex[i] ^ bHex[i];
            return diff == 0;
        }
    }
}

