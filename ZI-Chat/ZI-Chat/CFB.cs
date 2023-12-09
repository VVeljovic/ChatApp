using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Chat
{
    class CFB
    {
        private static uint[] key = { 0x11223344, 0x22334455, 0x33445566, 0x44556677 };
        private static uint[] iv = { 0x11223344, 0x22334455 };
        public CFB()
        {

        }
        public string encrypt(string plainText)
        {
            
            Console.WriteLine(plainText.Length);
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            int blockSize = 8;
            int blockCount = (int)Math.Ceiling((double)inputBytes.Length / blockSize);
            Console.WriteLine(blockCount);
            byte[] encryptedBytes = new byte[blockCount * blockSize];
            byte[] block = new byte[blockSize];
            uint[] uintBlock = new uint[block.Length / 4];
            Array.Copy(inputBytes, 0 * blockSize, block, 0, Math.Min(blockSize, inputBytes.Length - 0 * blockSize));
            Buffer.BlockCopy(block, 0, uintBlock, 0, block.Length);
            uint[] copyIv = new uint[iv.Length];
            Array.Copy(iv, copyIv, iv.Length);
            for (int i = 0; i < blockCount; i++)
            {
                byte[] helpers = new byte[blockSize];
                uint[] helpersUint = new uint[block.Length / 4];
                Array.Copy(inputBytes, i * blockSize, helpers, 0, Math.Min(blockSize, inputBytes.Length - i * blockSize));
                Buffer.BlockCopy(helpers, 0, helpersUint, 0, helpers.Length);

                if (i == 0)
                {
                    XXTEA.Btea(copyIv,copyIv.Length, key);

                    for (int k = 0; k < uintBlock.Length; k++)
                    {
                        Console.WriteLine(uintBlock[k]);
                        uintBlock[k] ^= copyIv[k];
                    }
                }
                else
                {
                    XXTEA.Btea(uintBlock, uintBlock.Length, key);

                    for (int k = 0; k < uintBlock.Length; k++)
                    {
                        Console.WriteLine(helpersUint[k]);
                        uintBlock[k] ^= helpersUint[k];
                    }
                }

                byte[] encryptedBlock = new byte[block.Length];
                Buffer.BlockCopy(uintBlock, 0, encryptedBlock, 0, encryptedBlock.Length);

                // Kopiranje šifrovanog bloka u rezultujući niz
                Array.Copy(encryptedBlock, 0, encryptedBytes, i * blockSize, encryptedBlock.Length);
            }

            Console.WriteLine("Šifrovan tekst: " + Convert.ToBase64String(encryptedBytes));
            Console.WriteLine("bajtovi blok" + encryptedBytes.Length);
            Console.WriteLine("GLEDAJEEE");
            foreach (byte b in encryptedBytes)
                Console.WriteLine(b);
            Console.WriteLine("GLEDAJEEE");
            string encText = Convert.ToBase64String(encryptedBytes);
            return encText;
        }
        public string decrypt(string codedText)
        {
            Console.WriteLine(codedText);
            Console.WriteLine(codedText.Length);
            byte[] encryptedBytes = Convert.FromBase64String(codedText);
            Console.WriteLine("GLEDAJ");
            foreach (byte b in encryptedBytes)
                Console.WriteLine(b);
            Console.WriteLine("GLEDAJ");
            int blockSize = 8;
            int blockCount = (int)Math.Ceiling((double)encryptedBytes.Length / blockSize);
            byte[] block = new byte[blockSize];
            byte[] decryptedBytes = new byte[blockCount * blockSize];
            uint[] uintBlock = new uint[block.Length / 4];
            byte[] helpersBlock = new byte[blockSize];
            uint[] helpersUint2 = new uint[block.Length / 4];
            Console.WriteLine(encryptedBytes.Length);
            Array.Copy(encryptedBytes, 0 * blockSize, helpersBlock, 0, blockSize);
            Buffer.BlockCopy(helpersBlock, 0, helpersUint2, 0, helpersBlock.Length);
            uint[] copyIv = new uint[iv.Length];
            Array.Copy(iv, copyIv, iv.Length);
            XXTEA.Btea(copyIv, copyIv.Length, key);
            for (int i = 0; i < blockCount; i++)
            {
                byte[] encryptedBlock = new byte[blockSize];
                Array.Copy(encryptedBytes, i * blockSize, encryptedBlock, 0, blockSize);
                Buffer.BlockCopy(encryptedBlock, 0, uintBlock, 0, encryptedBlock.Length);



                if (i == 0)
                {
                    for (int k = 0; k < uintBlock.Length; k++)
                    {
                        helpersUint2[k] ^= copyIv[k];
                    }
                }
                else
                {
                    XXTEA.Btea(helpersUint2, helpersUint2.Length, key);
                    //byte[] helpers = new byte[blockSize];
                    //Array.Copy(encryptedBytes, (i - 1) * blockSize, helpers, 0, blockSize);
                    //uint[] helpersUint = new uint[block.Length / 4];
                    //Buffer.BlockCopy(helpers, 0, helpersUint, 0, helpers.Length);

                    for (int k = 0; k < helpersUint2.Length; k++)
                    {
                        helpersUint2[k] ^= uintBlock[k];
                    }
                }


                byte[] decryptedBlock = new byte[block.Length];
                Buffer.BlockCopy(helpersUint2, 0, decryptedBlock, 0, decryptedBlock.Length);

                // Kopiranje dešifrovanog bloka u rezultujući niz
                Array.Copy(decryptedBlock, 0, decryptedBytes, i * blockSize, decryptedBlock.Length);
                Array.Copy(uintBlock, 0, helpersUint2, 0, helpersUint2.Length);
            }

            // Pretvaranje rezultujućeg niza bajtova u string
            string decryptedText = Encoding.UTF8.GetString(decryptedBytes).TrimEnd('\0');
            Console.WriteLine("Dešifrovan tekst: " + decryptedText);
            return decryptedText;
        }

    }
    
}
