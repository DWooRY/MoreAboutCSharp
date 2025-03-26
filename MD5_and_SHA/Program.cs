using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5_and_SHA
{
    class Program
    {
        static void Main(string[] args)
        {
            //MD5
            string password = "EniscanYildiz";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] md5ComputeBytes = md5.ComputeHash(passwordBytes);

            string encryptedPassword = Convert.ToBase64String(md5ComputeBytes);

            Console.WriteLine("MD5 ile sifreleme: " + encryptedPassword);

            //SHA256
            string sha256password = SHA256Encrypt(password);
            Console.WriteLine("SHA256 ile sifreleme: "+sha256password);

            string sha512password = SHA512Encrypt(password);
            Console.WriteLine("SHA512 ile sifreleme: " + sha512password);

        }

        public static string SHA256Encrypt(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] sha256Bytes = sha256.ComputeHash(passwordBytes);
            return HashtoByte(sha256Bytes);

        }

        public static string SHA512Encrypt(string password)
        {
            SHA512 sha512 = SHA512.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] sha512Bytes = sha512.ComputeHash(passwordBytes);
            return HashtoByte(sha512Bytes);

        }

        private static string HashtoByte(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }



    }


}
