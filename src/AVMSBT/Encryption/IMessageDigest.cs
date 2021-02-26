using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSBT.Encryption
{
    public interface IMessageDigest
    {
        byte[] Encryption(byte[] source);
        string Encryption(string source);
    }
}
