using System;
using System.Windows.Forms;

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

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            if (!string.IsNullOrEmpty(myDialog.FileName))
            {
                Custom.FEncrypt(myDialog.FileName, myDialog.SafeFileName, numColumns, shiftKey);
                FileHandler.OpenFolder();
            }
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            if (!string.IsNullOrEmpty(myDialog.FileName))
            {
                Custom.FDecrypt(myDialog.FileName, myDialog.SafeFileName, numColumns, shiftKey);
                FileHandler.OpenFolder();
            }
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
