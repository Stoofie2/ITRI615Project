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
            //Text Encryption
            //Convert the input into a byte array
            byte[] bInput = Encoding.ASCII.GetBytes(input);
            
            //Call the methods of the encryption algorithm
            byte[] trans = TranspositionE(bInput, col);
            byte[] sub = SubstitutionE(trans, shift);
            byte[] output = TranspositionE(sub, col + shift);

            //Convert back to string for output
            string sOutput = Encoding.ASCII.GetString(output);

            return sOutput;
        }

        public static byte[] EncryptF(byte[] input, int col, int shift)
        {
            //File Encryption
            //If it's a file being encrypted it's already in byte array form, so no need to convert
            //Calls the methods of encryption algorithm
            byte[] trans = TranspositionE(input, col);
            byte[] sub = SubstitutionE(trans, shift);
            byte[] output = TranspositionE(sub, col + shift);

            return output;
        }

        public static byte[] TranspositionE(byte[] input, int col)
        {
            //Transposition Encryption
            //Test if there will be any open spaces in the table
            if (input.Length % col != 0)
            {
                //If there is, resize the array to allow for the buffer values
                int oldSize = input.Length;
                int newSize = (input.Length - (input.Length % col) + col);
                Array.Resize(ref input, newSize);

                //Insert buffer values "-"
                for (int k = oldSize; k < newSize; k++)
                {
                    input[k] = 45;
                }
            }

            //Get length of array
            int totalBytes = input.Length;
            byte[] output = new byte[totalBytes];
            //Create 2D arrays, since it needs to be in the format of a table
            int totalColumns = col;
            int totalRows = (int)Math.Ceiling((double)totalBytes / totalColumns);
            byte[,] rowBytes = new byte[totalRows, totalColumns];
            byte[,] colBytes = new byte[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;

            //Insert each byte into the table
            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowBytes[currentRow, currentColumn] = input[i];
            }

            //Swap rows and columns for easier output
            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colBytes[j, i] = rowBytes[i, j];

            //Get the result of the transposition phase
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
            //Substitution Encryption
            //Convert to string for easier manipulation
            string sInput = Encoding.ASCII.GetString(input);
            int c = 0;
            char[] inputArr = new char[input.Length];

            //Put each character of the string into an array
            foreach (char chr in sInput)
            {
                inputArr[c] = chr;
                c++;
            }

            //Shift the char values of the array to get a char output
            char[] cOutput = new char[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                cOutput[i] = (char)(inputArr[i] + shift);
            }

            //Convert output back to byte array
            byte[] bOutput = Encoding.ASCII.GetBytes(cOutput);

            return bOutput;
        }

        public static byte[] DecryptF(byte[] input, int col, int shift)
        {
            //File decryption
            int totalBytes = input.Length;

            //Calls methods for decryption algorithm
            byte[] trans = TranspositionD(input, col + shift);
            byte[] sub = SubstitutionD(trans, shift);
            byte[] output = TranspositionD(sub, col);

            return output;
        }

        public static string DecryptT(string input, int col, int shift)
        {
            //Text decryption
            //Converts string to byte array
            byte[] bInput = Encoding.ASCII.GetBytes(input);

            int totalBytes = bInput.Length;
            //Calls methods for decryption algorithm
            byte[] trans = TranspositionD(bInput, col + shift);
            byte[] sub = SubstitutionD(trans, shift);
            byte[] output = TranspositionD(sub, col);

            //Converts byte array to string for output
            string sOutput = Encoding.ASCII.GetString(output);

            return sOutput;
        }

        public static byte[] TranspositionD(byte[] input, int col)
        {
            //Transposition Decryption
            int newSize = 0;
            int totalBytes = input.Length;
            byte[] output = new byte[totalBytes];

            //Create 2D array
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

            //swap rows and columns for easier output
            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colBytes[j, i] = rowBytes[i, j];
            
            //Get result of reverse transposition
            for (i = 0; i < totalBytes; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output[i] = colBytes[currentRow, currentColumn];
            }

            //Removes the buffer characters added during the first transposition phase
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

            //Resizes array for output
            byte[] fOutput = new byte[newSize];

            for (int z = 0; z < newSize; z++)
            {
                fOutput[z] = output[z];
            }

            return fOutput;
        }

        public static byte[] SubstitutionD(byte[] input, int shift)
        {
            //Convert input to string
            string sInput = Encoding.ASCII.GetString(input);
            int c = 0;
            char[] inputArr = new char[input.Length];

            //Insert each char of string into char array
            foreach (char chr in sInput)
            {
                inputArr[c] = chr;
                c++;
            }

            //Create output
            char[] cOutput = new char[input.Length];

            //Shift the char values back to what it was
            for (int i = 0; i < input.Length; i++)
            {
                cOutput[i] = (char)(inputArr[i] - shift);
            }

            //Convert back to byte array
            byte[] bOutput = Encoding.ASCII.GetBytes(cOutput);

            return bOutput;
        }

        public static void FEncrypt(string file, string fileName, int col, int shift)
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
            byte[] en_bytes = EncryptF(ogfileBytes, col, shift);
            
            //Create new file
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();
        }

        public static void FDecrypt(string file, string fileName, int col, int shift)
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
            byte[] decryptedBytes = DecryptF(en_bytes, col, shift);

            //Create new file
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decryptedBytes, 0, decryptedBytes.Length);
            fs.Close();
        }
    }
}
