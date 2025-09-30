using System;
using System.Security.Cryptography;
using System.Text;

namespace AESDecryptWinForms.Utils
{
    public static class CryptoHelper
    {
        public static byte[] HexStringToBytes(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Hex string must have an even length");

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                string byteValue = hex.Substring(i * 2, 2);
                bytes[i] = Convert.ToByte(byteValue, 16);
            }
            return bytes;
        }

        public static byte[] AESDecrypt_ECB(byte[] cipherBytes, byte[] key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.None;
                aes.Key = key;

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    return decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                }
            }
        }

        public static string DecodeEBCDIC(byte[] data, string codePage)
        {
            Encoding encoding;
            try
            {
                encoding = Encoding.GetEncoding(codePage);
            }
            catch
            {
                encoding = Encoding.GetEncoding("cp1140"); // fallback
            }
            return encoding.GetString(data);
        }
    }
}
