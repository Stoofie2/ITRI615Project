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

namespace ITRI615_CryptographyProject.Transposition
{
    public partial class Transposition : UserControl
    {
        int numColumns = 5;
        string transEncryptedMessage = "";
        string transDecryptedMessage = "";

        public Transposition()
        {
            InitializeComponent();
        }

        private void btnTransEncrypt_Click(object sender, EventArgs e)
        {
            string message = txtTransMessage.Text;
            transEncryptedMessage = TranspositionAlgorithm.EncryptT(message, numColumns);
            txtTransEncrypted.Text = transEncryptedMessage;

            lblColumns.Text = "Number of Columns: " + numColumns;
        }

        private void btnTransDecrypt_Click(object sender, EventArgs e)
        {
            transDecryptedMessage = TranspositionAlgorithm.DecryptT(transEncryptedMessage, numColumns);
            lbxTransDecrypted.Items.Add(transDecryptedMessage);
        }

        private void btnSetColumns_Click(object sender, EventArgs e)
        {
            numColumns = int.Parse(txtSetColumns.Text);
            lblColumns.Text = "Number of Columns: " + numColumns;
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

        private void radMenuItem5_Click_1(object sender, EventArgs e)
        {
            txtSetColumns.Clear();
            txtTransEncrypted.Clear();
            txtTransMessage.Clear();
            lbxTransDecrypted.Items.Clear();
            numColumns = 5;

            lblColumns.Text = "Number of Columns: 5";
        }

        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            TranspositionAlgorithm.FEncrypt(myDialog.FileName, myDialog.SafeFileName, numColumns);
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void radMenuItem4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myDialog.InitialDirectory = directoryPath;
            myDialog.ShowDialog();
            TranspositionAlgorithm.FDecrypt(myDialog.FileName, myDialog.SafeFileName, numColumns);
            OpenFolder(directoryPath);
        }
    }
}
