using System;
using System.Windows.Forms;
using System.IO;

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
 
        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            if (!string.IsNullOrEmpty(myDialog.FileName))
            {
                byte[] bytes = File.ReadAllBytes(myDialog.FileName);
                VigenereCipher.Encrypt(myDialog.FileName, myDialog.SafeFileName, VigKey);
                FileHandler.OpenFolder();
            }
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.ShowDialog();
            if (!string.IsNullOrEmpty(myDialog.FileName))
            {
                VigenereCipher.Decrypt(myDialog.FileName, myDialog.SafeFileName, VigKey);
                FileHandler.OpenFolder();
            }
        }

        private void btnEncryptVig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVigMessage.Text))
            {
                MessageBox.Show("Enter message to encrypt.");
            }
            else
            {
                string message = txtVigMessage.Text;
                string encryptedMessVig = VigenereCipher.DecryptEncryptTextVigenere(message, VigKey, true);
                txtVigDecOutput.Text = encryptedMessVig; //displays encrypted cipher.
                radLabel1.Visible = true;
                txtVigDecOutput.Visible = true;
            }
        }

        private void btnDecryptVig_Click(object sender, EventArgs e)
        {
            string encryptedMessVig = txtVigDecOutput.Text;
            string decryptedMess = VigenereCipher.DecryptEncryptTextVigenere(encryptedMessVig, VigKey, false);
            lstbxVigOutput.Text = decryptedMess; //displays decrypted message.
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
