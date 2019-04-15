using System;
using System.IO;
namespace ITRI615Project
{
    public static class VernamAlgorithm
    {
        static string keyFile = "vernamkey.ser";

        public static void Encrypt(string file,string fileName)
        {
            string temp = fileName = fileName.Replace("_encrypted", "");
            string encrtypedName = "_encrypted" + temp;
          
            // filestream is used to read the file provided through the paramater of this method.

            FileStream fs = new FileStream(file, FileMode.Open);
            
            //byte array is created in order to store the original byte values for the file that will be encrypted.
            byte[] ogfileBytes = new byte[fs.Length];

            fs.Read(ogfileBytes, 0, ogfileBytes.Length);
 
            //another byte array is created in order to store the key value that will be used to encrypt the file with.
            //the vernam algorithm requires that the key value must be the same length of the file (in this case the same amount of bytes).
            //the random function is used in order to generate random byte values to be stored in the key byte array.

            byte[] key = new byte[ogfileBytes.Length];
            Random myRandom = new Random();
            myRandom.NextBytes(key);
            fs.Close();
           
            // using the filestream again the key byte array is written to the file called keydump.txt that will be used in order to decrypt the file again.
            fs = new FileStream(keyFile, FileMode.Create);
            fs.Write(key, 0, key.Length);
            fs.Close();

            // create an byte array namely "en_bytes" that will be used to store the encrypted byte values for the file by making use of the key byte array created earlier.
            byte[] en_bytes = new byte[ogfileBytes.Length];
            
            EncryptDecryptFile(ogfileBytes, key, ref en_bytes); //the ref is used due to...

            //after the file has been encrypted the filestream is used again to write the encrypted file to the disk again.
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();
        }

        public static void Decrypt(string file, string fileName)//method to decrypt a file encrypted by the vernam algorithm given the keyfile.
        {
            string temp = fileName = fileName.Replace("_encrypted", "_decrypted"); ;
            string decryptedName = temp;

            // Filestream is used in order to read the encrypted file into the byte array called "en_bytes".
            byte[] en_bytes;
            FileStream fs = new FileStream(file, FileMode.Open);
            en_bytes = new byte[fs.Length];
            fs.Read(en_bytes, 0, en_bytes.Length);
            fs.Close();

            // Filestream is used again in order to read in the key file into the byte array called "key".
            byte[] key;
            fs = new FileStream(keyFile, FileMode.Open);
            key = new byte[fs.Length];
            fs.Read(key, 0, key.Length);
            fs.Close();

            // Calls the methods to decrypt the encrypted byte array and store the decrypted values into an array called decryptedBytes.
            byte[] decryptedBytes = new byte[en_bytes.Length];

            EncryptDecryptFile(en_bytes, key, ref decryptedBytes);

            // The decrypted file is written to the disk by using the filestream.
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decryptedBytes, 0, decryptedBytes.Length);
            fs.Close();
        }

        private static void EncryptDecryptFile(byte[] inputBytes, byte[] keyBytes, ref byte[] outputBytes)
        {
            // if-statement to check whether the input bytes (encrypted/decrypted file) is the same length as the key provided.
            if ((inputBytes.Length != keyBytes.Length) || (keyBytes.Length != outputBytes.Length))
                throw new ArgumentException("The file cannot be encrypted/decrypted due to the byte-array is not the same length as the key array.");

            // encrypt or decrypt the file using XOR method.
            for (int i = 0; i < inputBytes.Length; i++)
            {
                outputBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i]);
            }
        }
    }
}
