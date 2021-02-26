using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSBT.Encryption
{
    public interface ICipher
    {
        byte[] encryption(byte[] source);
        byte[] decryption(byte[] source);
    }
}
