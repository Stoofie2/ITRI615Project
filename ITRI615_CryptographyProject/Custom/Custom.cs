using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITRI615_CryptographyProject.Custom
{
    class Custom
    {
        public static int count = 0;

        public static string EncryptT(string input, int col, int shift)
        {
            byte[] bInput = Encoding.ASCII.GetBytes(input);
            
            byte[] trans = TranspositionE(bInput, col);
            byte[] sub = SubstitutionE(trans, shift);
            byte[] output = TranspositionE(sub, col + shift);

            string sOutput = Encoding.ASCII.GetString(output);

            return sOutput;
        }

        public static byte[] EncryptF(byte[] input, int col, int shift)
        {
            byte[] trans = TranspositionE(input, col);
            byte[] sub = SubstitutionE(trans, shift);
            byte[] output = TranspositionE(sub, col + shift);

            return output;
        }

        public static byte[] TranspositionE(byte[] input, int col)
        {
            if (input.Length % col != 0)
            {
                int oldSize = input.Length;
                int newSize = (input.Length - (input.Length % col) + col);
                Array.Resize(ref input, newSize);

                for (int k = oldSize; k < newSize; k++)
                {
                    input[k] = 45;
                }
            }

            int totalBytes = input.Length;
            byte[] output = new byte[totalBytes];
            int totalColumns = col;
            int totalRows = (int)Math.Ceiling((double)totalBytes / totalColumns);
            byte[,] rowBytes = new byte[totalRows, totalColumns];
            byte[,] colBytes = new byte[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowBytes[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colBytes[j, i] = rowBytes[i, j];

            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output[i] = colBytes[currentRow, currentColumn];
            }

            return output;
        }

        public static byte[] SubstitutionE(byte[] input, int shift)
        {
            string sInput = Encoding.ASCII.GetString(input);
            int c = 0;
            char[] inputArr = new char[input.Length];

            foreach (char chr in sInput)
            {
                inputArr[c] = chr;
                c++;
            }

            char[] cOutput = new char[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                cOutput[i] = (char)(inputArr[i] + shift);
            }

            byte[] bOutput = Encoding.ASCII.GetBytes(cOutput);

            return bOutput;
        }

        public static byte[] DecryptF(byte[] input, int col, int shift)
        {
            int totalBytes = input.Length;
            byte[] trans = TranspositionD(input, col + shift);
            byte[] sub = SubstitutionD(trans, shift);
            byte[] output = TranspositionD(sub, col);

            return output;
        }

        public static string DecryptT(string input, int col, int shift)
        {
            byte[] bInput = Encoding.ASCII.GetBytes(input);

            int totalBytes = bInput.Length;
            byte[] trans = TranspositionD(bInput, col + shift);
            byte[] sub = SubstitutionD(trans, shift);
            byte[] output = TranspositionD(sub, col);

            string sOutput = Encoding.ASCII.GetString(output);

            return sOutput;
        }

        public static byte[] TranspositionD(byte[] input, int col)
        {
            int newSize = 0;
            int totalBytes = input.Length;
            byte[] output = new byte[totalBytes];
            int totalColumns = (int)Math.Ceiling((double)totalBytes / col);
            int totalRows = col;
            byte[,] rowBytes = new byte[totalRows, totalColumns];
            byte[,] colBytes = new byte[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowBytes[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colBytes[j, i] = rowBytes[i, j];
            
            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output[i] = colBytes[currentRow, currentColumn];
            }

            for (int l = 0; l < output.Length; l++)
            {
                if (output[l] == 45)
                {
                    newSize = l;
                    break;
                }
                else
                    newSize = l + 1;
            }
            
            byte[] fOutput = new byte[newSize];

            for (int z = 0; z < newSize; z++)
            {
                fOutput[z] = output[z];
            }

            return fOutput;
        }

        public static byte[] SubstitutionD(byte[] input, int shift)
        {
            string sInput = Encoding.ASCII.GetString(input);
            int c = 0;
            char[] inputArr = new char[input.Length];

            foreach (char chr in sInput)
            {
                inputArr[c] = chr;
                c++;
            }

            char[] cOutput = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                cOutput[i] = (char)(inputArr[i] - shift);
            }

            byte[] bOutput = Encoding.ASCII.GetBytes(cOutput);

            return bOutput;
        }

        public static void FEncrypt(string file, string fileName, int col, int shift)
        {
            string temp = fileName = fileName.Replace("_encrypted", "");
            string encrtypedName = "_encrypted" + temp;

            FileStream fs = new FileStream(file, FileMode.Open);
            byte[] ogfileBytes = new byte[fs.Length];
            fs.Read(ogfileBytes, 0, ogfileBytes.Length);
            fs.Close();
            
            byte[] en_bytes = EncryptF(ogfileBytes, col, shift);
            
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();
        }

        public static void FDecrypt(string file, string fileName, int col, int shift)
        {
            string temp = fileName = fileName.Replace("_encrypted", "_decrypted"); ;
            string decryptedName = temp;
            
            byte[] en_bytes;
            FileStream fs = new FileStream(file, FileMode.Open);
            en_bytes = new byte[fs.Length];
            fs.Read(en_bytes, 0, en_bytes.Length);
            fs.Close();
            
            byte[] decryptedBytes = DecryptF(en_bytes, col, shift);
            
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decryptedBytes, 0, decryptedBytes.Length);
            fs.Close();
        }
    }
}
