using System.IO;
using System.Diagnostics;

namespace ITRI615_CryptographyProject
{
    public static class FileHandler
    {
        static string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public static void OpenFolder()
        {
            if (Directory.Exists(directoryPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                { Arguments = directoryPath, FileName = "explorer.exe" };
                Process.Start(startInfo);
            }
        }

        public static byte[] ReadOriginalFile(string file, string fileName)
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

            return ogfileBytes;
        }

        public static byte[] ReadEncryptedFile(string file, string fileName)
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
            return en_bytes;
        }
    }
}
