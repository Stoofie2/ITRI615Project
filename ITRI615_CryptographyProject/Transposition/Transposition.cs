using System;
using System.Windows.Forms;


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
            if (txtTransMessage.Text == "")
            {
                MessageBox.Show("Please enter a message to encrypt");
            }
            else
            {
                string message = txtTransMessage.Text;
                transEncryptedMessage = TranspositionAlgorithm.EncryptT(message, numColumns);
                txtTransEncrypted.Text = transEncryptedMessage;

                lblColumns.Text = "Number of Columns: " + numColumns;
            }
        }

        private void btnTransDecrypt_Click(object sender, EventArgs e)
        {
            if (transEncryptedMessage == "")
            {
                MessageBox.Show("Please encrypt before you decrypt");
            }
            else
            {
                transDecryptedMessage = TranspositionAlgorithm.DecryptT(transEncryptedMessage, numColumns);
                lbxTransDecrypted.Items.Add(transDecryptedMessage);
            }
        }

        private void btnSetColumns_Click(object sender, EventArgs e)
        {
            int number;
            bool num = int.TryParse(txtSetColumns.Text, out number);

            if (num)
            {
                if (number <= 0)
                {
                    MessageBox.Show("The number of columns needs to be more than 0, please enter a new number");
                }
                else
                {
                    numColumns = number;
                    lblColumns.Text = "Number of Columns: " + numColumns;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number larger than 0");
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
            if (!string.IsNullOrEmpty(myDialog.FileName))
            {
                TranspositionAlgorithm.FEncrypt(myDialog.FileName, myDialog.SafeFileName, numColumns);
                FileHandler.OpenFolder();
            }
        }

        private void radMenuItem4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            if (!string.IsNullOrEmpty(myDialog.FileName))
            {
                TranspositionAlgorithm.FDecrypt(myDialog.FileName, myDialog.SafeFileName, numColumns);
                FileHandler.OpenFolder();
            }
        }
    }
}
