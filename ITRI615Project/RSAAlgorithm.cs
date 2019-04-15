using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Numerics;
using RSA;

namespace ITRI615Project
{
    public class RSAAlgorithm
    {


 

        public void Encrypt(RSAParameters publicKey, string file, string fileName)
        {

            string temp = fileName = fileName.Replace("_encrypted", "");
            string encrtypedName = "_encrypted" + temp;
            FileStream fs;

            fs = new FileStream(file, FileMode.Open);

            byte[] ogfileBytes = new byte[fs.Length];

            fs.Read(ogfileBytes, 0, ogfileBytes.Length);
            fs.Close();
            //byte[] ogfileBytes = Encoding.UTF8.GetBytes("bernie is dom.");

    
            byte[]  en_bytes;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(publicKey);
                en_bytes = rsa.Encrypt(ogfileBytes, true);
            }

            //after the file has been encrypted the filestream is used again to write the encrypted file to the disk again.
            fs = new FileStream(encrtypedName, FileMode.Create);
            fs.Write(en_bytes, 0, en_bytes.Length);
            fs.Close();      
        }

        public byte[] EncryptText(RSAParameters publicKey, string file)
        {

            //byte[] ogfileBytes = Convert.FromBase64String(file);
            byte[] ogfileBytes = Encoding.UTF8.GetBytes(file);

            byte[] en_bytes;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(publicKey);
                en_bytes = rsa.Encrypt(ogfileBytes, true);
            }


            return en_bytes;
        }

        public void Decrypt(RSAParameters privateKey, string file, string fileName)//method to decrypt a file encrypted by the vernam algorithm given the keyfile.
        {
            string temp = fileName = fileName.Replace("_encrypted", "_decrypted"); ;
            string decryptedName = temp;
            FileStream fs;

            fs = new FileStream(file, FileMode.Open);

            byte[] en_bytes = new byte[fs.Length];

            fs.Read(en_bytes, 0, en_bytes.Length);
            fs.Close();

            //decrypt
            byte[] decrypted_bytes;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(privateKey);
                decrypted_bytes = rsa.Decrypt(en_bytes, true);
            }

            //after the file has been encrypted the filestream is used again to write the encrypted file to the disk again.
            fs = new FileStream(decryptedName, FileMode.Create);
            fs.Write(decrypted_bytes, 0, decrypted_bytes.Length);
            fs.Close();
        }

        public byte[] DecryptText(RSAParameters privateKey, byte[] en_bytes)//method to decrypt a file encrypted by the vernam algorithm given the keyfile.
        {
            //byte[] encryptedData = Convert.FromBase64String(value);
            //byte[] en_bytes = Convert.FromBase64String(file);
            //byte[] en_bytes = Convert.FromBase64String(file);
            //decrypt
            byte[] decrypted_bytes;


            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(privateKey);
                decrypted_bytes = rsa.Decrypt(en_bytes, true);
            }

            //after the file has been encrypted the filestream is used again to write the encrypted file to the disk again.
            //return Encoding.Unicode.GetString(decrypted_bytes);
            return decrypted_bytes;
        }
    }
}
