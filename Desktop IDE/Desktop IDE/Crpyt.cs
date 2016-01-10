using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Desktop_IDE
{
    public static class Crpyt
    {
        private static IMain main = strData.main;
        private static string password = "dasdsdsadwdsdscx";
        private static byte[] pwb = Encoding.UTF7.GetBytes(password);

        public static void encrypt(string file, string output)
        {
            string plainText = string.Empty;
            using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(fs))
                {
                    plainText = reader.ReadToEnd();
                }
            }
            using (var encryptedOutput = new FileStream(output, FileMode.Create, FileAccess.Write))
            {
                AESEncrypt(plainText, encryptedOutput, pwb);
            }
        }
        public static void decrpyt(string file, string output)
        {
            string decryptedText = string.Empty;
            using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                decryptedText = AESDecrypt(fs, pwb);
            }

            using (var decryptedStream = new FileStream(output, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new StreamWriter(decryptedStream))
                {
                    writer.Write(decryptedText);
                }
            }
        }

        private static void AESEncrypt(string plainText, Stream encryptedOutput, byte[] key)
        {
            if (plainText == null || plainText == string.Empty)
                return;
            if (key == null | key.Length == 0)
                return;
            if (encryptedOutput == null)
                return;

            using (var aes = new AesManaged())
            {
                aes.Key = key;
                var salt = new byte[16];
                using (var rngCSP = new RNGCryptoServiceProvider())
                {
                    rngCSP.GetBytes(salt);
                }
                aes.IV = salt;

                using (var encryptor = aes.CreateEncryptor())
                {
                    encryptedOutput.Write(salt, 0, salt.Length);//write the salt to the begining of the stream

                    using (var cs = new CryptoStream(encryptedOutput, encryptor, CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(cs))
                        {
                            writer.Write(plainText);
                        }
                    }
                }
            }
        }

        private static string AESDecrypt(Stream encryptedInput, byte[] key)
        {
            if (encryptedInput == null || encryptedInput.Length == 0)
                return null;
            if (key == null || key.Length == 0)
                return null;

            var salt = new byte[16];
            encryptedInput.Read(salt, 0, salt.Length);

            using (var aes = new AesManaged())
            {
                aes.Key = key;
                aes.IV = salt;
                using (var decryptor = aes.CreateDecryptor())
                {
                    using (var cs = new CryptoStream(encryptedInput, decryptor, CryptoStreamMode.Read))
                    {
                        using (var reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
