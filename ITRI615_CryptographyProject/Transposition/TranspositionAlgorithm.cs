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
            //Text message encryption
            originalSize = input.Length;

            //If there are open spaces in the table that needs to be filled
            input = (input.Length % col == 0) ? input : input.PadRight(input.Length - (input.Length % col) + col, '-');
            StringBuilder output = new StringBuilder();

            //Create 2D array
            int totalChars = input.Length;
            int totalColumns = col;
            int totalRows = (int)Math.Ceiling((double)totalChars / totalColumns);
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            //Insert each char into table
            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            //Swap rows and columns
            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            //Get result of transposition
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
            //File encryption
            originalSize = input.Length;

            //If there are open spaces that need to be filled
            if (input.Length % col != 0)
            {
                //Resize array
                int oldSize = input.Length;
                int newSize = (input.Length - (input.Length % col) + col);
                Array.Resize(ref input, newSize);

                //Add buffer byte
                for (int k = oldSize; k < newSize; k++)
                {
                    input[k] = 45;
                }
            }

            int totalBytes = input.Length;
            byte[] output = new byte[totalBytes];
            //Create 2D array
            int totalColumns = col;
            int totalRows = (int)Math.Ceiling((double)totalBytes / totalColumns);
            byte[,] rowBytes = new byte[totalRows, totalColumns];
            byte[,] colBytes = new byte[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            //Insert each byte into table
            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowBytes[currentRow, currentColumn] = input[i];
            }

            //Swap rows and columns
            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colBytes[j, i] = rowBytes[i, j];

            //Get result of transposition
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
            //Text decryption
            StringBuilder output = new StringBuilder();

            //Create 2D array
            int totalChars = input.Length;
            int totalColumns = (int)Math.Ceiling((double)totalChars / col);
            int totalRows = col;
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            //Insert each char into table
            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            //Swap rows and columns
            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            //Get result of reverse transposition
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
            //File decryption
            int totalBytes = input.Length;

            //Create 2D array
            byte[] output = new byte[totalBytes];
            int totalColumns = (int)Math.Ceiling((double)totalBytes / col);
            int totalRows = col;
            byte[,] rowBytes = new byte[totalRows, totalColumns];
            byte[,] colBytes = new byte[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            //Insert each byte into table
            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowBytes[currentRow, currentColumn] = input[i];
            }

            //Swap rows and columns
            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colBytes[j, i] = rowBytes[i, j];

            //Get result of reverse transposition
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
            //If you want to encrypt a file
            //Create new filename
            string temp = fileName = fileName.Replace("_encrypted", "");
            string encrtypedName = "_encrypted" + temp;

            //Open file explorer to fetch file
            FileStream fs = new FileStream(file, FileMode.Open);
            byte[] ogfileBytes = new byte[fs.Length];
            fs.Read(ogfileBytes, 0, ogfileBytes.Length);
            fs.Close();

            //Create byte array of the chosen file
            byte[] en_bytes = EncryptF(ogfileBytes, col);

            //Create new file
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();
        }

        public static void FDecrypt(string file, string fileName, int col)
        {
            //If you want to decrypt a file
            //Create new filename
            string temp = fileName = fileName.Replace("_encrypted", "_decrypted"); ;
            string decryptedName = temp;

            //Open file explorer to fetch file
            byte[] en_bytes;
            FileStream fs = new FileStream(file, FileMode.Open);
            en_bytes = new byte[fs.Length];
            fs.Read(en_bytes, 0, en_bytes.Length);
            fs.Close();

            //Create byte array of the chosen file
            byte[] decryptedBytes = DecryptF(en_bytes, col);

            //Create new file
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decryptedBytes, 0, decryptedBytes.Length);
            fs.Close();
        }
    }
}
