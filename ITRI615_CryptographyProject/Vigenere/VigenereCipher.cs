using System;
using System.IO;
namespace ITRI615_CryptographyProject.Vigenere
{
    static public class VigenereCipher
    {

        public static void Encrypt(string file, string fileName, string key)
        {
            //adds the _encrypted string to the name of the file to indicate it is encrypted.
            string temp = fileName = fileName.Replace("_encrypted", "");
            string encrtypedName = "_encrypted" + temp;

            // filestream is used to read the file provided through the paramater of this method.
            FileStream fs = new FileStream(file, FileMode.Open);
            
            //byte array is created in order to store the original byte values for the file that will be encrypted.
            byte[] ogfileBytes = new byte[fs.Length];
            fs.Read(ogfileBytes, 0, ogfileBytes.Length);
            fs.Close();

            // create an byte array namely "en_bytes" that will be used to store the encrypted byte values for the file by making use of the key byte array created earlier.
            byte[] en_bytes = DecryptEncryptByteVigenere(ogfileBytes, key,true);


            //after the file has been encrypted the filestream is used again to write the encrypted file to the disk again.
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();
        }

        public static void Decrypt(string file, string fileName, string key)
        {
            //adds the _decrypted string to the name of the file to indicate it is decrypted as well as removing _encrypted from the name if it is detected.
            string temp = fileName = fileName.Replace("_encrypted", "_decrypted"); ;
            string decryptedName = temp;

            // Filestream is used in order to read the encrypted file into the byte array called "en_bytes".
            byte[] en_bytes;
            FileStream fs = new FileStream(file, FileMode.Open);
            en_bytes = new byte[fs.Length];
            fs.Read(en_bytes, 0, en_bytes.Length);
            fs.Close();

            // Calls the methods to decrypt the encrypted byte array and store the decrypted values into an array called decryptedBytes.
            byte[] decryptedBytes = DecryptEncryptByteVigenere(en_bytes, key,false);

            // The decrypted file is written to the disk by using the filestream.
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decryptedBytes, 0, decryptedBytes.Length);
            fs.Close();
        }

        //method use to decrypt and encrypt files by encrypting/decrypting their byte values.
        public static byte[] DecryptEncryptByteVigenere(byte[] message, string key, bool value)
        {
            byte[] result = new byte[message.Length]; //message is stored into a byte array to be modified.
            key = key.Trim().ToUpper(); //the key used for the program is "trimmed", meaning white spaces are removed, and all the lowercase characters are converted to uppercase.
           
            //sets the key index.
            int keyIndex = 0; 
            int keylength = key.Length;

            if (value == false) //decrypt ciphertext
            {
                for (int i = 0; i < message.Length; i++)
                {
                    //the algorithm is broken up into various steps to make it easier to understand.

                    keyIndex = keyIndex % keylength;  //at first the keyindex to be used is obtained by taking the current key index and mod it with the keylength
                    int shift = (int)key[keyIndex] - 65; //the shift value is determined by taking the key character (parsing it to integer value) and substracting it with 65. The subsctraction for 65 is done to get the correct value for the modulus operator.

                    //a new value is obtained by adding the value of the message (parsed to an integer) and 256, then substractng the shift key and afterwards modding it with 26.
                    result[i] = (byte)(((int)message[i] + 256 - shift) % 256);
                    //after the decrypted message is added to the result array, the keyindex is incrreased.
                    keyIndex++;
                }
            }
            else //encrypt plaintext
            {
                for (int i = 0; i < message.Length; i++)
                {
                    //the algorithm is broken up into various steps to make it easier to understand.
                    keyIndex = keyIndex % keylength; //at first the keyindex to be used is obtained by taking the current key index and mod it with the keylength

                    int shift = (int)key[keyIndex] - 65; //the shift value is determined by taking the key character (parsing it to integer value) and substracting it with 65. The subsctraction for 65 is done to get the correct value for the modulus operator.

                    //a new value is obtained by adding the value of the message (parsed to an integer) and the shift key then modding it with 26.
                    result[i] = (byte)(((int)message[i] + shift) % 256);

                    keyIndex++;
                }
            }
            return result;
        }


        //method use to decrypt and encrypt standard text messages.
        public static string DecryptEncryptTextVigenere(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null; // validation is done on the key to ensure that it only contains valid letters.

            string message_output = "";

            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter((char)input[i])) //validation to check if the current character of the message is a letter 
                {
                    bool cIsUpper = char.IsUpper((char)input[i]);
                    char offset; //value used to get the correct value for the modulus operator.

                    int keyIndex = (i - nonAlphaCharCount) % key.Length; //obtains the key index, minus the non alphabetic characters.
                    int key_value = 0;
                    if (cIsUpper)
                    {
                        offset = 'A'; //65 in ascii
                        key_value = char.ToUpper(key[keyIndex]); //the key's character is obtained using the key index and is converted to an uppercase.
                    }
                    else
                    {
                        offset = 'a';
                        key_value = char.ToLower(key[keyIndex]) - offset; //the key's character is obtained using the key index and is converted to an uppercase.
                    }

                    //char offset = cIsUpper ? 'A' : 'a';                 
                    //int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;

                    if (!encipher) //if true then it means this method will be used to encrypt the text.
                        key_value = -key_value; //the key value is reversed in order to use it to decrypt the message.
                    //k = encipher ? k : -k;

                    //the encrypted/decrtypted character isi obtained by adding the message's character with the key value, then subscracting the offset value and mod it with 26.

                    char mod_value_charcater = (char) Mod(((input[i] + key_value) - offset), 26);

                    char result_character = (char) (mod_value_charcater + offset); //the offset value is then added again to the modded value in order to obtain the result.

                    message_output += result_character; //the newly encrypted/decrypted character is added to the output string.
                }
                else //following code executed if the character is not a letter.
                {
                    message_output += input[i]; //adds the nonalphabetic character directly to the message.
                    ++nonAlphaCharCount; //increases the non alphabetic characters' counter.
                }
            }

            return message_output; //return the encrypted/decrypted message
        }

        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }
    }
}
