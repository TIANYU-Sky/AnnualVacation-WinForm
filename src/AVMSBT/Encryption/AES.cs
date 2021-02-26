using System;
using System.Collections.Generic;
using System.Text;

namespace AVMSBT.Encryption
{
    public class AES_128 : BAdvancedEncryption
    {
        public AES_128(byte[] keys)
        {
            if (null == keys)
                throw new Exception();
            if (keys.Length < AES_128_KeyLength)
                throw new Exception();
            Keys = splitKey(keys);
        }

        public override byte[] encryption(byte[] source)
        {
            if (null == source)
                throw new Exception();
            byte[][][] packages = splitBytes(source);
            byte[] target = new byte[packages.Length * 16];
            byte[][] before = new byte[][]
                    {
                        new byte[]{0, 0, 0, 0},
                        new byte[]{0, 0, 0, 0},
                        new byte[]{0, 0, 0, 0},
                        new byte[]{0, 0, 0, 0}
                    };
            for (int i = 0; i < packages.Length; i++)
            {
                KeyPackage[] keys = keyExpansion(before);
                byte[][] temp = encode(packages[i], keys);
                before = temp;
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        target[i * 16 + j * 4 + k] = temp[j][k];
            }
            return target;
        }
        public override byte[] decryption(byte[] source)
        {
            if (null == source)
                throw new Exception();
            Stack<byte[][]> stack = new Stack<byte[][]>();
            byte[][][] packages = splitBytes(source);
            byte[] target = new byte[packages.Length * 16];
            for (int i = packages.Length - 1; i >= 0; i--)
            {
                byte[][] before = 0 <= i - 1 ? packages[i - 1] : new byte[][]
                    {
                        new byte[]{0, 0, 0, 0},
                        new byte[]{0, 0, 0, 0},
                        new byte[]{0, 0, 0, 0},
                        new byte[]{0, 0, 0, 0}
                    };
                KeyPackage[] keys = keyExpansion(before);
                byte[][] temp = decode(packages[i], keys);
                stack.Push(temp);
            }
            for (int i = 0; 0 < stack.Count; i++)
            {
                byte[][] temp = stack.Pop();
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        target[i * 16 + j * 4 + k] = temp[j][k];
            }
            return target;
        }

        private byte[][] encode(byte[][] source, KeyPackage[] keys)
        {
            byte[][] temp = xor(source, keys[0].Keys);
            for (int i = 1; i < 10; i++)
                temp = repeatRoundEncode(temp, keys[i].Keys);
            temp = getByteReplace(temp, EOperation.Encode);
            temp = rowTransposition(temp, EOperation.Encode);
            return xor(temp, keys[keys.Length - 1].Keys);
        }
        private byte[][] repeatRoundEncode(byte[][] source, byte[][] key)
        {
            byte[][] temp = getByteReplace(source, EOperation.Encode);
            temp = rowTransposition(temp, EOperation.Encode);
            temp = mixColumns(temp, EOperation.Encode);
            temp = xor(temp, key);
            return temp;
        }

        private byte[][] decode(byte[][] source, KeyPackage[] keys)
        {
            byte[][] temp = xor(source, keys[keys.Length - 1].Keys);
            for (int i = 0; i < 9; i++)
                temp = repeatRoundDecode(temp, keys[keys.Length - 2 - i].Keys);
            temp = rowTransposition(temp, EOperation.Decode);
            temp = getByteReplace(temp, EOperation.Decode);
            temp = xor(temp, keys[0].Keys);
            return temp;
        }
        private byte[][] repeatRoundDecode(byte[][] source, byte[][] key)
        {
            byte[][] temp = rowTransposition(source, EOperation.Decode);
            temp = getByteReplace(temp, EOperation.Decode);
            temp = xor(temp, key);
            temp = mixColumns(temp, EOperation.Decode);
            return temp;
        }

        private byte[][][] splitBytes(byte[] source)
        {
            byte[][][] result;
            if (0 == source.Length % 16)
                result = new byte[source.Length / 16][][];
            else
                result = new byte[source.Length / 16 + 1][][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new byte[GroupLength][];
                for (int j = 0; j < result[i].Length; j++)
                    result[i][j] = new byte[]
                            {
                                (byte)(i * 16 + j * 4 < source.Length ? source[i * 16 + j * 4] : 0),
                                (byte)(i * 16 + j * 4 + 1 < source.Length ? source[i * 16 + j * 4 + 1] : 0),
                                (byte)(i * 16 + j * 4 + 2 < source.Length ? source[i * 16 + j * 4 + 2] : 0),
                                (byte)(i * 16 + j * 4 + 3 < source.Length ? source[i * 16 + j * 4 + 3] : 0)
                            };
            }
            return result;
        }

        private byte[][] splitKey(byte[] source)
        {
            byte[][] result = new byte[4][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new byte[4];
                for (int j = 0; j < result[i].Length; j++)
                    result[i][j] = source[i + 4 * j];
            }
            return result;
        }
        private KeyPackage[] keyExpansion(byte[][] before)
        {
            KeyPackage[] packages = new KeyPackage[SubKeyLength];
            packages[0] = new KeyPackage();
            for (int i = 0; i < packages[0].Keys.Length; i++)
                for (int j = 0; j < packages[0].Keys[i].Length; j++)
                    packages[0].Keys[i][j] = (byte)(Keys[i][j] ^ before[i][j]);
            for (int i = 1; i < packages.Length; i++)
                packages[i] = keyPackage(packages[i - 1], RoundConst[i - 1]);
            return packages;
        }
        private KeyPackage keyPackage(KeyPackage source, byte[] rcon)
        {
            byte[] temp = new byte[]
                    {
                        (byte) (getByteRPS(source.Keys[1][3]) ^ rcon[0]),
                        (byte) (getByteRPS(source.Keys[2][3]) ^ rcon[0]),
                        (byte) (getByteRPS(source.Keys[3][3]) ^ rcon[0]),
                        (byte) (getByteRPS(source.Keys[0][3]) ^ rcon[0])
                    };
            KeyPackage keyPackage = new KeyPackage();
            for (int i = 0; i < temp.Length; i++)
                keyPackage.Keys[i][3] = temp[i];
            keyPackage.Keys[0][0] = (byte)(temp[0] ^ source.Keys[0][0]);
            keyPackage.Keys[1][0] = (byte)(temp[1] ^ source.Keys[1][0]);
            keyPackage.Keys[2][0] = (byte)(temp[2] ^ source.Keys[2][0]);
            keyPackage.Keys[3][0] = (byte)(temp[3] ^ source.Keys[3][0]);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    keyPackage.Keys[j][i + 1] = (byte)(keyPackage.Keys[j][i] ^ source.Keys[j][i + 1]);
            return keyPackage;
        }

        private static byte[][] RoundConst = new byte[][]
                {
                    new byte[]{ 0x01, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x02, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x04, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x08, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x10, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x20, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x40, 0x00, 0x00, 0x00 },
                    new byte[]{(byte) 0x80, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x1B, 0x00, 0x00, 0x00 },
                    new byte[]{ 0x36, 0x00, 0x00, 0x00 }
                };
        private static int SubKeyLength = 11;
    }
}
