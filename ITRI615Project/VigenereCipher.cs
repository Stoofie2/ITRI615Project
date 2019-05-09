using System;
using System.IO;
using System.Text;
namespace ITRI615Project
{
    static public class VigenereCipher
    {
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        public static void Encrypt(string file, string fileName, string key)
        {
            string temp = fileName = fileName.Replace("_encrypted", "");
            string encrtypedName = "_encrypted" + temp;

            FileStream fs = new FileStream(file, FileMode.Open);
            byte[] ogfileBytes = new byte[fs.Length];
            fs.Read(ogfileBytes, 0, ogfileBytes.Length);
            fs.Close();

            // create an byte array namely "en_bytes" that will be used to store the encrypted byte values for the file by making use of the key byte array created earlier.
            byte[] en_bytes = encryptByteVigenere(ogfileBytes,key);


            //after the file has been encrypted the filestream is used again to write the encrypted file to the disk again.
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();
        }

        public static Byte[] encryptByteVigenere(Byte[] plaintext, string key)
        {

            Byte[] result = new Byte[plaintext.Length];

            key = key.Trim().ToUpper();

            int keyIndex = 0;
            int keylength = key.Length;

            for (int i = 0; i < plaintext.Length; i++)
            {
                keyIndex = keyIndex % keylength;
                int shift = (int)key[keyIndex] - 65;
                result[i] = (byte)(((int)plaintext[i] + shift) % 256);
                keyIndex++;
            }

            return result;
        }


        public static void Decrypt(string file, string fileName, string key)
        {
            string temp = fileName = fileName.Replace("_encrypted", "_decrypted"); ;
            string decryptedName = temp;

            // Filestream is used in order to read the encrypted file into the byte array called "en_bytes".
            byte[] en_bytes;
            FileStream fs = new FileStream(file, FileMode.Open);
            en_bytes = new byte[fs.Length];
            fs.Read(en_bytes, 0, en_bytes.Length);
            fs.Close();



            // Calls the methods to decrypt the encrypted byte array and store the decrypted values into an array called decryptedBytes.
            byte[] decryptedBytes = decryptByteVigenere(en_bytes,key);
            // The decrypted file is written to the disk by using the filestream.
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decryptedBytes, 0, decryptedBytes.Length);
            fs.Close();
        }

        public static Byte[] decryptByteVigenere(Byte[] ciphertext, string key)
        {
            Byte[] result = new Byte[ciphertext.Length];

            key = key.Trim().ToUpper();

            int keyIndex = 0;
            int keylength = key.Length;

            for (int i = 0; i < ciphertext.Length; i++)
            {
                keyIndex = keyIndex % keylength;
                int shift = (int)key[keyIndex] - 65;
                result[i] = (byte)(((int)ciphertext[i] + 256 - shift) % 256);
                keyIndex++;
            }

            return result;
        }


        public static string Cipher(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null; // Error
            //string input = Encoding.Unicode.GetString(file);
            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter((char)input[i]))
                {
                    bool cIsUpper = char.IsUpper((char)input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }
    }
}
