using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Chat
{
    class CFB
    {
        private static uint[] key;
        private static uint[] iv;
        private XXTEA xxtea;     
        public CFB()
        {
            xxtea = new XXTEA(10);
            key = generateRandomUintArray(4);
            iv = generateRandomUintArray(2);
        }
        public string EncryptDecrypt(string text, int direction,int off)
        {
            if (off != 0)
                return text;
            byte[] inputBytes;
            if (direction == 0)
                inputBytes = Encoding.UTF8.GetBytes(text);
            else
            {
                    
                    inputBytes = Convert.FromBase64String(text);
            }
            int blockSize = 8;
            int blockCount = (int)Math.Ceiling((double)inputBytes.Length / blockSize);
            byte[] block = new byte[blockSize];
            byte[] encryptedBytes = new byte[blockCount * blockSize];
            uint[] uintBlock = new uint[block.Length / 4];
            Array.Copy(inputBytes, 0 * blockSize, block, 0, Math.Min(blockSize, inputBytes.Length - 0 * blockSize));
            Buffer.BlockCopy(block, 0, uintBlock, 0, block.Length);
            uint[] copyIv = new uint[iv.Length];
            Array.Copy(iv, copyIv, iv.Length);
            XXTEA.Btea(copyIv, copyIv.Length, key);
            string retVal = "";
            if (direction == 0)
                retVal = Encrypt(inputBytes,blockSize,blockCount,block,encryptedBytes,uintBlock,copyIv);
            else
                retVal = Decrypt(inputBytes, blockSize, blockCount, block, encryptedBytes, uintBlock, copyIv);
            return retVal;
        }
        public string Decrypt(byte[]encryptedBytes,int blockSize,
            int blockCount,byte[]block,byte[]decryptedBytes,uint[]uintBlock,uint[]copyIv)
        {
            byte[] helpersBlock = new byte[blockSize];
            uint[] helpersUint = new uint[block.Length / 4];

            Array.Copy(encryptedBytes, 0 * blockSize, helpersBlock, 0, blockSize);
            Buffer.BlockCopy(helpersBlock, 0, helpersUint, 0, helpersBlock.Length);
            for (int i = 0; i < blockCount; i++)
            {

                
                    byte[] encryptedBlock = new byte[blockSize];
                    Array.Copy(encryptedBytes, i * blockSize, encryptedBlock, 0, blockSize);
                    Buffer.BlockCopy(encryptedBlock, 0, uintBlock, 0, encryptedBlock.Length);
                                


                if (i == 0)
                {
                    for (int k = 0; k < helpersUint.Length; k++)
                    {
                        helpersUint[k] ^= copyIv[k];
                    }
                }
                else
                {
                    XXTEA.Btea(helpersUint, helpersUint.Length, key);


                    for (int k = 0; k < helpersUint.Length; k++)
                    {
                        helpersUint[k] ^= uintBlock[k];
                    }
                }


                byte[] decryptedBlock = new byte[block.Length];
                Buffer.BlockCopy(helpersUint, 0, decryptedBlock, 0, decryptedBlock.Length);


                Array.Copy(decryptedBlock, 0, decryptedBytes, i * blockSize, decryptedBlock.Length);
                Array.Copy(uintBlock, 0, helpersUint, 0, helpersUint.Length);
            }


            string decryptedText = Encoding.UTF8.GetString(decryptedBytes).TrimEnd('\0');

            return decryptedText;
        }
        public string Encrypt(byte[]inputBytes,int blockSize,int blockCount,byte[]block,byte[]encryptedBytes,uint[]uintBlock,uint[]copyIv)
        {
            for (int i = 0; i < blockCount; i++)
            {
                byte[] helpers = new byte[blockSize];
                uint[] helpersUint = new uint[block.Length / 4];
                Array.Copy(inputBytes, i * blockSize, helpers, 0, Math.Min(blockSize, inputBytes.Length - i * blockSize));
                Buffer.BlockCopy(helpers, 0, helpersUint, 0, helpers.Length);

                if (i == 0)
                {
                   

                    for (int k = 0; k < uintBlock.Length; k++)
                    {

                        uintBlock[k] ^= copyIv[k];
                    }
                }
                else
                {
                    XXTEA.Btea(uintBlock, uintBlock.Length, key);

                    for (int k = 0; k < uintBlock.Length; k++)
                    {

                        uintBlock[k] ^= helpersUint[k];
                    }
                }

                byte[] encryptedBlock = new byte[block.Length];
                Buffer.BlockCopy(uintBlock, 0, encryptedBlock, 0, encryptedBlock.Length);


                Array.Copy(encryptedBlock, 0, encryptedBytes, i * blockSize, encryptedBlock.Length);
            }


            string encText = Convert.ToBase64String(encryptedBytes);
            return encText;
        }

        private uint[] generateRandomUintArray(int lenght)
        {
            int seed = lenght * 32;
            Random random = new Random(seed);
            uint[] generatedArray = new uint[lenght];
            for(int i = 0;i<lenght; i ++)
            {
                uint randValue = (uint)random.Next();
                generatedArray[i] = randValue;
            }
            return generatedArray;
        }
     

       

    }
    
}
