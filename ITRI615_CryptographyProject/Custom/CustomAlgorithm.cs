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

namespace ITRI615_CryptographyProject.Custom
{
    public partial class CustomAlgorithm : UserControl
    {
        int numColumns = 5;
        int shiftKey = 3;
        string customEncryptedMessage = "";
        string customDecryptedMessage = "";

        public CustomAlgorithm()
        {
            InitializeComponent();
        }

        private void btnCustomEncrypt_Click(object sender, EventArgs e)
        {
            string message = txtCustomMessage.Text;
            customEncryptedMessage = Custom.EncryptT(message, numColumns, shiftKey);
            txtCustomEncrypt.Text = customEncryptedMessage;

            lblCustomColumns.Text = "Number of Columns: " + numColumns;
            lblCustomShift.Text = "Shift Key: " + shiftKey;
        }

        private void btnCustomDecrypt_Click(object sender, EventArgs e)
        {
            customDecryptedMessage = Custom.DecryptT(customEncryptedMessage, numColumns, shiftKey);
            lbxCustomDecrypt.Items.Add(customDecryptedMessage);
        }

        private void btnCustomSetShift_Click(object sender, EventArgs e)
        {
            shiftKey = int.Parse(txtCustomShift.Text);
            lblCustomShift.Text = "Shift key: " + shiftKey;
        }

        private void btnCustomSetColumn_Click(object sender, EventArgs e)
        {
            numColumns = int.Parse(txtCustomColumns.Text);
            lblCustomColumns.Text = "Number of Columns: " + numColumns;
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
            Custom.FEncrypt(myDialog.FileName, myDialog.SafeFileName, numColumns, shiftKey);
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            myDialog.InitialDirectory = directoryPath;
            myDialog.ShowDialog();
            Custom.FDecrypt(myDialog.FileName, myDialog.SafeFileName, numColumns, shiftKey);
            OpenFolder(directoryPath);
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            txtCustomColumns.Clear();
            txtCustomShift.Clear();
            txtCustomMessage.Clear();
            txtCustomEncrypt.Clear();
            lbxCustomDecrypt.Items.Clear();
            numColumns = 5;
            shiftKey = 3;

            lblCustomColumns.Text = "Number of Columns: 5";
            lblCustomShift.Text = "Shift key: 3";
        }
    }
}
