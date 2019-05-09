using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;


namespace ITRI615Project
{
    public partial class frmHome : Form
    {

        //**VIGENERE RELATED VARIABLES
        string VigKey = "VIGENERECIPHER";
        string encryptedVernamMessage;
        string decryptedVernamMessage;
        public frmHome()
        {
            InitializeComponent();
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                { Arguments = folderPath, FileName = "explorer.exe" };
                Process.Start(startInfo);
            }
        }

        private void btnVernamEncrypt_Click(object sender, EventArgs e)
        {
            string message = txtVernamMessageInput.Text;
            encryptedVernamMessage = VernamAlgorithm.EncryptText(message);
            txtVernamMessEncrypted.Text = encryptedVernamMessage;
        }

        private void btnVernamDecrypt_Click(object sender, EventArgs e)
        {
            decryptedVernamMessage = VernamAlgorithm.DecryptText(encryptedVernamMessage);
            lstbxVernamMessDecrypt.Items.Add(decryptedVernamMessage);
        }


        /**VIGENERE SUMMARY
         *  In cryptography, a Vigenère cipher is a method of encrypting alphabetic text by using a series of different Caesar ciphers based on the letters of a keyword. It is a simple form of polyalphabetic substitution.
            The Vigenère cipher has been reinvented many times. The method was originally described by Giovan Battista Bellaso in his 1553 book La cifra del. Sig. Giovan Battista Bellaso; however, the scheme was later misattributed to Blaise de Vigenère in the 19th century, and is now widely known as the Vigenère cipher.
            This scheme of cipher uses a text string (say, a word) as a key, which is then used for doing a number of shifts on the plaintext.
            For example, let’s assume the key is 'cipher'. Each alphabet of the key is converted to its respective numeric value: In this case,
            c → 2, i → 8, p → 15, h → 7, e → 4, r → 17.
            Thus, the key is: 2 8 15 7 4 17.
        */

        private void button2_Click(object sender, EventArgs e)
        {
            string message = txtVigMessage.Text;
            string encryptedMessVig = VigenereCipher.Cipher(message, "cipher",false);
            txtVigDecOutput.Text = encryptedMessVig; //displayes encrypted cipher.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encryptedMessVig = txtVigDecOutput.Text;
            string decryptedMess = VigenereCipher.Cipher(encryptedMessVig, "cipher",true);
            lstbxVigOutput.Items.Add(decryptedMess); //displayes decrypted message.
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            byte[] bytes = File.ReadAllBytes(myDialog.FileName);
            VigenereCipher.Encrypt(myDialog.FileName, myDialog.SafeFileName, VigKey);
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myDialog.InitialDirectory = directoryPath;
            myDialog.ShowDialog();
            VigenereCipher.Decrypt(myDialog.FileName, myDialog.SafeFileName, VigKey);
            OpenFolder(directoryPath);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            VernamAlgorithm.Encrypt(myDialog.FileName, myDialog.SafeFileName);
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myDialog.InitialDirectory = directoryPath;
            myDialog.ShowDialog();
            VernamAlgorithm.Decrypt(myDialog.FileName, myDialog.SafeFileName);
            OpenFolder(directoryPath);
        }
    }
}
