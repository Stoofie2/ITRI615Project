using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Numerics;
using RSA;

namespace ITRI615Project
{
    public partial class frmHome : Form
    {
        //**RSA RELATED VARIABLES--------------------------------------------------
        /// <summary>
        RSAAlgorithm mytest = new RSAAlgorithm();
        RSAParameters publicKey;
        RSAParameters privateKey;
        byte[] msg;
        byte[] msgout;
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
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            VernamAlgorithm.Encrypt(myDialog.FileName, myDialog.SafeFileName);
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void btnVernamDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myDialog.InitialDirectory = directoryPath;
            myDialog.ShowDialog();
            VernamAlgorithm.Decrypt(myDialog.FileName, myDialog.SafeFileName);
            OpenFolder(directoryPath);
        }

        private void btnEncrypt_Click(object sender, EventArgs ee)
        {
            if (publicKey.ToString() == null || privateKey.ToString() == null)
            {
                MessageBox.Show("Generate keys first.");
            }
            else
            {
                msg = mytest.EncryptText(publicKey, txtRSAPlainText.Text);
                lstbxOutputRSA.AppendText(Convert.ToBase64String(msg));
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (publicKey.ToString() == null || privateKey.ToString() == null)
            {
                MessageBox.Show("Generate keys first.");
            }
            else
            {
              msgout = mytest.DecryptText(privateKey, msg);
              lstbxRSADecryptOutput.Items.Add(Convert.ToBase64String(msgout));
            }
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            mytest.Encrypt(publicKey, myDialog.FileName, myDialog.SafeFileName);
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myDialog.InitialDirectory = directoryPath;
            myDialog.ShowDialog();
            mytest.Decrypt(privateKey, myDialog.FileName, myDialog.SafeFileName);
            OpenFolder(directoryPath);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSAKeyGenerator.GenerateKeys(ref publicKey, ref privateKey);
            lblRSAOut.Text = "Keys generated.";
            btnDecrypt.Enabled = true;
            btnEncrypt.Enabled = true;
            encryptDecryptFilesToolStripMenuItem.Enabled = true;
        }
    }
}
