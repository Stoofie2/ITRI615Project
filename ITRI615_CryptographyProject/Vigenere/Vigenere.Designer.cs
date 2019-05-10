namespace ITRI615_CryptographyProject.Vigenere
{
    partial class Vigenere
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.txtVigDecOutput = new Telerik.WinControls.UI.RadTextBox();
            this.txtVigMessage = new Telerik.WinControls.UI.RadTextBox();
            this.btnDecryptVig = new Telerik.WinControls.UI.RadButton();
            this.btnEncryptVig = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.rdbtnSetKeyVig = new Telerik.WinControls.UI.RadButton();
            this.rdtxtSetKeyVig = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lstbxVigOutput = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVigDecOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVigMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDecryptVig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncryptVig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnSetKeyVig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtxtSetKeyVig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbxVigOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(660, 20);
            this.radMenu1.TabIndex = 12;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2,
            this.radMenuItem5});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Tools";
            this.radMenuItem1.UseCompatibleTextRendering = false;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Encrypt/Decrypt Data";
            this.radMenuItem2.UseCompatibleTextRendering = false;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Encrypt";
            this.radMenuItem3.UseCompatibleTextRendering = false;
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Decrypt";
            this.radMenuItem4.UseCompatibleTextRendering = false;
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Reset";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // txtVigDecOutput
            // 
            this.txtVigDecOutput.Location = new System.Drawing.Point(0, 177);
            this.txtVigDecOutput.Multiline = true;
            this.txtVigDecOutput.Name = "txtVigDecOutput";
            this.txtVigDecOutput.ReadOnly = true;
            // 
            // 
            // 
            this.txtVigDecOutput.RootElement.StretchVertically = true;
            this.txtVigDecOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVigDecOutput.Size = new System.Drawing.Size(238, 132);
            this.txtVigDecOutput.TabIndex = 10;
            this.txtVigDecOutput.Visible = false;
            // 
            // txtVigMessage
            // 
            this.txtVigMessage.Location = new System.Drawing.Point(4, 47);
            this.txtVigMessage.Multiline = true;
            this.txtVigMessage.Name = "txtVigMessage";
            // 
            // 
            // 
            this.txtVigMessage.RootElement.StretchVertically = true;
            this.txtVigMessage.Size = new System.Drawing.Size(235, 100);
            this.txtVigMessage.TabIndex = 9;
            // 
            // btnDecryptVig
            // 
            this.btnDecryptVig.Location = new System.Drawing.Point(251, 100);
            this.btnDecryptVig.Name = "btnDecryptVig";
            this.btnDecryptVig.Size = new System.Drawing.Size(110, 24);
            this.btnDecryptVig.TabIndex = 8;
            this.btnDecryptVig.Text = "Decrypt";
            this.btnDecryptVig.Click += new System.EventHandler(this.btnDecryptVig_Click);
            // 
            // btnEncryptVig
            // 
            this.btnEncryptVig.Location = new System.Drawing.Point(251, 47);
            this.btnEncryptVig.Name = "btnEncryptVig";
            this.btnEncryptVig.Size = new System.Drawing.Size(110, 24);
            this.btnEncryptVig.TabIndex = 7;
            this.btnEncryptVig.Text = "Encrypt";
            this.btnEncryptVig.Click += new System.EventHandler(this.btnEncryptVig_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(4, 153);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 18);
            this.radLabel1.TabIndex = 13;
            this.radLabel1.Text = "Encrypted Text:";
            this.radLabel1.Visible = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(4, 26);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(107, 18);
            this.radLabel2.TabIndex = 14;
            this.radLabel2.Text = "Enter message here:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(372, 153);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(84, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Decrypted Text:";
            this.radLabel3.Visible = false;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel6);
            this.radPanel1.Controls.Add(this.rdbtnSetKeyVig);
            this.radPanel1.Controls.Add(this.rdtxtSetKeyVig);
            this.radPanel1.Location = new System.Drawing.Point(372, 47);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(283, 100);
            this.radPanel1.TabIndex = 15;
            // 
            // rdbtnSetKeyVig
            // 
            this.rdbtnSetKeyVig.Location = new System.Drawing.Point(146, 35);
            this.rdbtnSetKeyVig.Name = "rdbtnSetKeyVig";
            this.rdbtnSetKeyVig.Size = new System.Drawing.Size(110, 24);
            this.rdbtnSetKeyVig.TabIndex = 1;
            this.rdbtnSetKeyVig.Text = "Set key";
            this.rdbtnSetKeyVig.Click += new System.EventHandler(this.rdbtnSetKeyVig_Click);
            // 
            // rdtxtSetKeyVig
            // 
            this.rdtxtSetKeyVig.Location = new System.Drawing.Point(12, 37);
            this.rdtxtSetKeyVig.Name = "rdtxtSetKeyVig";
            this.rdtxtSetKeyVig.Size = new System.Drawing.Size(100, 20);
            this.rdtxtSetKeyVig.TabIndex = 0;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(372, 23);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(95, 18);
            this.radLabel4.TabIndex = 16;
            this.radLabel4.Text = "Enter manual key:";
            // 
            // radLabel5
            // 
            this.radLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radLabel5.Location = new System.Drawing.Point(473, 23);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(11, 18);
            this.radLabel5.TabIndex = 17;
            this.radLabel5.Text = "?";
            // 
            // lstbxVigOutput
            // 
            this.lstbxVigOutput.Location = new System.Drawing.Point(372, 177);
            this.lstbxVigOutput.Multiline = true;
            this.lstbxVigOutput.Name = "lstbxVigOutput";
            this.lstbxVigOutput.ReadOnly = true;
            // 
            // 
            // 
            this.lstbxVigOutput.RootElement.StretchVertically = true;
            this.lstbxVigOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lstbxVigOutput.Size = new System.Drawing.Size(283, 132);
            this.lstbxVigOutput.TabIndex = 18;
            this.lstbxVigOutput.Visible = false;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(12, 79);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(66, 18);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "Current key:";
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstbxVigOutput);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.txtVigDecOutput);
            this.Controls.Add(this.txtVigMessage);
            this.Controls.Add(this.btnDecryptVig);
            this.Controls.Add(this.btnEncryptVig);
            this.Name = "Vigenere";
            this.Size = new System.Drawing.Size(660, 325);
            this.Load += new System.EventHandler(this.Vigenere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVigDecOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVigMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDecryptVig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncryptVig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnSetKeyVig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtxtSetKeyVig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbxVigOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadTextBox txtVigDecOutput;
        private Telerik.WinControls.UI.RadTextBox txtVigMessage;
        private Telerik.WinControls.UI.RadButton btnDecryptVig;
        private Telerik.WinControls.UI.RadButton btnEncryptVig;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton rdbtnSetKeyVig;
        private Telerik.WinControls.UI.RadTextBox rdtxtSetKeyVig;
        private Telerik.WinControls.UI.RadTextBox lstbxVigOutput;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}
