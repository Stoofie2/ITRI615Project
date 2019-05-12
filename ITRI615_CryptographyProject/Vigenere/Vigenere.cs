using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ITRI615_CryptographyProject.Vigenere
{
    public partial class Vigenere : UserControl
    {
        //**VIGENERE RELATED VARIABLES

        string VigKey = "VIGENERECIPHER";
        ToolTip TP = new ToolTip();

        public Vigenere()
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

 
        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            byte[] bytes = File.ReadAllBytes(myDialog.FileName);
            VigenereCipher.Encrypt(myDialog.FileName, myDialog.SafeFileName, VigKey);
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myDialog.InitialDirectory = directoryPath;
            myDialog.ShowDialog();
            VigenereCipher.Decrypt(myDialog.FileName, myDialog.SafeFileName, VigKey);
            OpenFolder(directoryPath);
        }

        private void btnEncryptVig_Click(object sender, EventArgs e)
        {
            string message = txtVigMessage.Text;
            string encryptedMessVig = VigenereCipher.Cipher(message, VigKey, true);
            txtVigDecOutput.Text = encryptedMessVig; //displayes encrypted cipher.
            radLabel1.Visible = true;
            txtVigDecOutput.Visible = true;
        }

        private void btnDecryptVig_Click(object sender, EventArgs e)
        {
            string encryptedMessVig = txtVigDecOutput.Text;
            string decryptedMess = VigenereCipher.Cipher(encryptedMessVig, VigKey, false);
            lstbxVigOutput.Text = decryptedMess; //displayes decrypted message.
            radLabel3.Visible = true;
            lstbxVigOutput.Visible = true;
        }

  
        private void Vigenere_Load(object sender, EventArgs e)
        {
            TP.ShowAlways = true;
            TP.SetToolTip(radLabel5, "Enter a manual key to be used, otherwise the default key will be used.");
            radLabel6.Text = "Current key: " + VigKey;
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            txtVigDecOutput.Clear();
            txtVigMessage.Clear();
            lstbxVigOutput.Clear();
            rdtxtSetKeyVig.Clear();
            VigKey = "VIGENERECIPHER";
            radLabel6.Text = "Current key: " + VigKey;

            radLabel3.Visible = false;
            lstbxVigOutput.Visible = false;
            radLabel1.Visible = false;
            txtVigDecOutput.Visible = false;
        }

        private void rdbtnSetKeyVig_Click(object sender, EventArgs e)
        {
            VigKey = rdtxtSetKeyVig.Text;
            radLabel6.Text = "Current key: " + VigKey;
        }

    }
}
