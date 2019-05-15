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
            if (txtCustomMessage.Text == "")
            {
                MessageBox.Show("Please enter a message to encrypt");
            }
            else
            {
                string message = txtCustomMessage.Text;
                customEncryptedMessage = Custom.EncryptT(message, numColumns, shiftKey);
                txtCustomEncrypt.Text = customEncryptedMessage;
                lblCustomColumns.Text = "Number of Columns: " + numColumns;
                lblCustomShift.Text = "Shift Key: " + shiftKey;
            }
        }

        private void btnCustomDecrypt_Click(object sender, EventArgs e)
        {
            if (customEncryptedMessage == "")
            {
                MessageBox.Show("Please encrypt before you decrypt");
            }
            else
            {
                customDecryptedMessage = Custom.DecryptT(customEncryptedMessage, numColumns, shiftKey);
                lbxCustomDecrypt.Items.Add(customDecryptedMessage);
            }
        }

        private void btnCustomSetShift_Click(object sender, EventArgs e)
        {
            int number;
            bool num = int.TryParse(txtCustomShift.Text, out number);

            if (num)
            {
                if (number < -5 || number > 5)
                {
                    MessageBox.Show("The shift key value needs to be between -5 and 5, please enter a new number");
                }
                else
                {
                    shiftKey = number;
                    lblCustomShift.Text = "Shift key: " + shiftKey;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number between -5 and 5");
            }
        }

        private void btnCustomSetColumn_Click(object sender, EventArgs e)
        {
            int number;
            bool num = int.TryParse(txtCustomColumns.Text, out number);

            if (num)
            {
                if (int.Parse(txtCustomColumns.Text) <= 0)
                {
                    MessageBox.Show("The number of columns needs to be more than 0, please enter a new number");
                }
                else
                {
                    numColumns = int.Parse(txtCustomColumns.Text);
                    lblCustomColumns.Text = "Number of Columns: " + numColumns;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number larger than 0");
            }

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

        private void CustomAlgorithm_Load(object sender, EventArgs e)
        {

        }
    }
}
