using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITRI615_CryptographyProject.Transposition
{
    public static class TranspositionAlgorithm
    {
        public static int originalSize = 0;

        public static string EncryptT(string input, int col)
        {
            originalSize = input.Length;
            input = (input.Length % col == 0) ? input : input.PadRight(input.Length - (input.Length % col) + col, '-');
            StringBuilder output = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = col;
            int totalRows = (int)Math.Ceiling((double)totalChars / totalColumns);
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output.Append(colChars[currentRow, currentColumn]);
            }

            return output.ToString();
        }

        public static byte[] EncryptF(byte[] input, int col)
        {
            originalSize = input.Length;
            if (input.Length % col != 0)
            {
                int oldSize = input.Length;
                int newSize = (input.Length - (input.Length % col) + col);
                Array.Resize(ref input, newSize);

                for (int k = oldSize; k < newSize; k++)
                {
                    input[k] = 0;
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

        public static string DecryptT(string input, int col)
        {
            StringBuilder output = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = (int)Math.Ceiling((double)totalChars / col);
            int totalRows = col;
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            for (i = 0; i < originalSize; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output.Append(colChars[currentRow, currentColumn]);
            }

            return output.ToString();
        }

        public static byte[] DecryptF(byte[] input, int col)
        {
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

            for (i = 0; i < originalSize; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output[i] = colBytes[currentRow, currentColumn];
            }

            return output;
        }

        public static void FEncrypt(string file, string fileName, int col)
        {
            string temp = fileName = fileName.Replace("_encrypted", "");
            string encrtypedName = "_encrypted" + temp;

            FileStream fs = new FileStream(file, FileMode.Open);
            byte[] ogfileBytes = new byte[fs.Length];
            fs.Read(ogfileBytes, 0, ogfileBytes.Length);
            fs.Close();
            
            byte[] en_bytes = EncryptF(ogfileBytes, col);
            
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();
        }

        public static void FDecrypt(string file, string fileName, int col)
        {
            string temp = fileName = fileName.Replace("_encrypted", "_decrypted"); ;
            string decryptedName = temp;
            
            byte[] en_bytes;
            FileStream fs = new FileStream(file, FileMode.Open);
            en_bytes = new byte[fs.Length];
            fs.Read(en_bytes, 0, en_bytes.Length);
            fs.Close();
            
            byte[] decryptedBytes = DecryptF(en_bytes, col);
            
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decryptedBytes, 0, decryptedBytes.Length);
            fs.Close();
        }
    }
}
