using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSBT.Encryption
{
    public class MD5 : IMessageDigest
    {
        public byte[] Encryption(byte[] source)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            return md5.ComputeHash(source);
        }

        public string Encryption(string source)
        {
            byte[] result = Encryption(Encoding.Default.GetBytes(source));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < result.Length; ++i)
                builder.Append(result[i].ToString("x2"));
            return builder.ToString();
        }
    }
}
