namespace ITRI615_CryptographyProject.Vernam
{
    partial class VernamForm
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
            this.txtVernamMessageInput = new Telerik.WinControls.UI.RadTextBox();
            this.rdbtnVernamDecrypt = new Telerik.WinControls.UI.RadButton();
            this.rdbtnVernamEncrypt = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.rdbtnSetKeyVig = new Telerik.WinControls.UI.RadButton();
            this.rdtxtSetKeyVig = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lstbxVernamMessDecrypt = new Telerik.WinControls.UI.RadTextBox();
            this.txtVernamMessEncrypted = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVernamMessageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnVernamDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnVernamEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnSetKeyVig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtxtSetKeyVig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbxVernamMessDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVernamMessEncrypted)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(749, 20);
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
            // txtVernamMessageInput
            // 
            this.txtVernamMessageInput.Location = new System.Drawing.Point(247, 50);
            this.txtVernamMessageInput.Multiline = true;
            this.txtVernamMessageInput.Name = "txtVernamMessageInput";
            // 
            // 
            // 
            this.txtVernamMessageInput.RootElement.StretchVertically = true;
            this.txtVernamMessageInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVernamMessageInput.Size = new System.Drawing.Size(235, 36);
            this.txtVernamMessageInput.TabIndex = 9;
            this.txtVernamMessageInput.TextChanged += new System.EventHandler(this.txtVernamMessageInput_TextChanged);
            // 
            // rdbtnVernamDecrypt
            // 
            this.rdbtnVernamDecrypt.Location = new System.Drawing.Point(488, 56);
            this.rdbtnVernamDecrypt.Name = "rdbtnVernamDecrypt";
            this.rdbtnVernamDecrypt.Size = new System.Drawing.Size(110, 24);
            this.rdbtnVernamDecrypt.TabIndex = 8;
            this.rdbtnVernamDecrypt.Text = "Decrypt";
            this.rdbtnVernamDecrypt.Click += new System.EventHandler(this.rdbtnVernamDecrypt_Click);
            // 
            // rdbtnVernamEncrypt
            // 
            this.rdbtnVernamEncrypt.Location = new System.Drawing.Point(488, 26);
            this.rdbtnVernamEncrypt.Name = "rdbtnVernamEncrypt";
            this.rdbtnVernamEncrypt.Size = new System.Drawing.Size(110, 24);
            this.rdbtnVernamEncrypt.TabIndex = 7;
            this.rdbtnVernamEncrypt.Text = "Encrypt";
            this.rdbtnVernamEncrypt.Click += new System.EventHandler(this.rdbtnVernamEncrypt_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radLabel5.Location = new System.Drawing.Point(359, 92);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(11, 18);
            this.radLabel5.TabIndex = 23;
            this.radLabel5.Text = "?";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(247, 92);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(95, 18);
            this.radLabel4.TabIndex = 22;
            this.radLabel4.Text = "Enter manual key:";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radLabel6);
            this.radPanel1.Controls.Add(this.rdbtnSetKeyVig);
            this.radPanel1.Controls.Add(this.rdtxtSetKeyVig);
            this.radPanel1.Location = new System.Drawing.Point(247, 116);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(235, 100);
            this.radPanel1.TabIndex = 21;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(12, 79);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(66, 18);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "Current key:";
            // 
            // rdbtnSetKeyVig
            // 
            this.rdbtnSetKeyVig.Location = new System.Drawing.Point(118, 35);
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
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(488, 92);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(84, 18);
            this.radLabel3.TabIndex = 18;
            this.radLabel3.Text = "Decrypted Text:";
            this.radLabel3.Visible = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(247, 26);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(107, 18);
            this.radLabel2.TabIndex = 20;
            this.radLabel2.Text = "Enter message here:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 92);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 18);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "Encrypted Text:";
            this.radLabel1.Visible = false;
            // 
            // lstbxVernamMessDecrypt
            // 
            this.lstbxVernamMessDecrypt.Location = new System.Drawing.Point(488, 116);
            this.lstbxVernamMessDecrypt.Multiline = true;
            this.lstbxVernamMessDecrypt.Name = "lstbxVernamMessDecrypt";
            this.lstbxVernamMessDecrypt.ReadOnly = true;
            // 
            // 
            // 
            this.lstbxVernamMessDecrypt.RootElement.StretchVertically = true;
            this.lstbxVernamMessDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lstbxVernamMessDecrypt.Size = new System.Drawing.Size(238, 132);
            this.lstbxVernamMessDecrypt.TabIndex = 25;
            this.lstbxVernamMessDecrypt.Visible = false;
            // 
            // txtVernamMessEncrypted
            // 
            this.txtVernamMessEncrypted.Location = new System.Drawing.Point(3, 116);
            this.txtVernamMessEncrypted.Multiline = true;
            this.txtVernamMessEncrypted.Name = "txtVernamMessEncrypted";
            this.txtVernamMessEncrypted.ReadOnly = true;
            // 
            // 
            // 
            this.txtVernamMessEncrypted.RootElement.StretchVertically = true;
            this.txtVernamMessEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVernamMessEncrypted.Size = new System.Drawing.Size(238, 132);
            this.txtVernamMessEncrypted.TabIndex = 24;
            this.txtVernamMessEncrypted.Visible = false;
            // 
            // VernamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstbxVernamMessDecrypt);
            this.Controls.Add(this.txtVernamMessEncrypted);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.txtVernamMessageInput);
            this.Controls.Add(this.rdbtnVernamDecrypt);
            this.Controls.Add(this.rdbtnVernamEncrypt);
            this.Name = "VernamForm";
            this.Size = new System.Drawing.Size(749, 285);
            this.Load += new System.EventHandler(this.VernamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVernamMessageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnVernamDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnVernamEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbtnSetKeyVig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtxtSetKeyVig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstbxVernamMessDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVernamMessEncrypted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadTextBox txtVernamMessageInput;
        private Telerik.WinControls.UI.RadButton rdbtnVernamDecrypt;
        private Telerik.WinControls.UI.RadButton rdbtnVernamEncrypt;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton rdbtnSetKeyVig;
        private Telerik.WinControls.UI.RadTextBox rdtxtSetKeyVig;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox lstbxVernamMessDecrypt;
        private Telerik.WinControls.UI.RadTextBox txtVernamMessEncrypted;
    }
}
