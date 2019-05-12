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

namespace ITRI615_CryptographyProject.Vernam
{
    public partial class VernamForm : UserControl
    {
        string VernamKey = "";
        int count = 0;
        ToolTip TP = new ToolTip();
        public VernamForm()
        {
            InitializeComponent();
        }

        string encryptedVernamMessage;
        string decryptedVernamMessage;

        private void rdbtnVernamEncrypt_Click(object sender, EventArgs e)
        {
            string message = txtVernamMessageInput.Text;
            encryptedVernamMessage = VernamAlgorithm.EncryptText(message,VernamKey);
            txtVernamMessEncrypted.Text = encryptedVernamMessage;
        }

        private void rdbtnVernamDecrypt_Click(object sender, EventArgs e)
        {
            decryptedVernamMessage = VernamAlgorithm.DecryptText(encryptedVernamMessage, VernamKey);
            lstbxVernamMessDecrypt.Items.Add(decryptedVernamMessage);
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            VernamAlgorithm.Encrypt(myDialog.FileName, myDialog.SafeFileName);
            FileHandler.OpenFolder();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            VernamAlgorithm.Decrypt(myDialog.FileName, myDialog.SafeFileName);
            FileHandler.OpenFolder();
        }

        private string GenerateRandomKey()
        {
            Random myRandom = new Random();
            char character = (char) Convert.ToInt32(Math.Floor(26 * myRandom.NextDouble() + 65));
            string key = character.ToString();
            return key;
        }

        private void txtVernamMessageInput_TextChanged(object sender, EventArgs e)
        {
            if (txtVernamMessageInput.Text.Length <= 0)
                VernamKey = "";
            else if (count < txtVernamMessageInput.Text.Length)
                VernamKey += GenerateRandomKey();
            else
                VernamKey = VernamKey.Remove(VernamKey.Length-1,1);

            count = txtVernamMessageInput.Text.Length;

            radLabel6.Text = "Current key: " + VernamKey;
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            txtVernamMessageInput.Clear();
            txtVernamMessEncrypted.Clear();
            rdtxtSetKeyVig.Clear();
            lstbxVernamMessDecrypt.Items.Clear();
            VernamKey = "";
            radLabel6.Text = "Current key: " + VernamKey;
        }

        private void rdbtnSetKeyVig_Click(object sender, EventArgs e)
        {
            if (rdtxtSetKeyVig.Text.Length != txtVernamMessageInput.Text.Length)
                MessageBox.Show("Invalid key length! \nVernam algorithm requires a key length matching the lengh of the message.");
            else
                VernamKey = rdtxtSetKeyVig.Text;
                radLabel6.Text = "Current key: " + VernamKey;
        }

        private void VernamForm_Load(object sender, EventArgs e)
        {
            TP.ShowAlways = true;
            TP.SetToolTip(radLabel5, "Enter a manual key to be used or a random one will be generated.");
        }
    }
}
