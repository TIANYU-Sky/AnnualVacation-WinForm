using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSBT.Encryption
{
    public class NoEncryption : ICipher
    {
        public byte[] decryption(byte[] source)
        {
            return source;
        }

        public byte[] encryption(byte[] source)
        {
            return source;
        }

        public static NoEncryption Increase()
        {
            return new NoEncryption();
        }
    }
}
