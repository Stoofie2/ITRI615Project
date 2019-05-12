namespace ITRI615_CryptographyProject.Transposition
{
    partial class Transposition
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblColumns = new Telerik.WinControls.UI.RadLabel();
            this.btnSetColumns = new Telerik.WinControls.UI.RadButton();
            this.txtSetColumns = new Telerik.WinControls.UI.RadTextBox();
            this.lblDecrypt = new Telerik.WinControls.UI.RadLabel();
            this.lblEnter = new Telerik.WinControls.UI.RadLabel();
            this.lblEncrypt = new Telerik.WinControls.UI.RadLabel();
            this.lbxTransDecrypted = new Telerik.WinControls.UI.RadListView();
            this.txtTransEncrypted = new Telerik.WinControls.UI.RadTextBox();
            this.txtTransMessage = new Telerik.WinControls.UI.RadTextBox();
            this.btnTransDecrypt = new Telerik.WinControls.UI.RadButton();
            this.btnTransEncrypt = new Telerik.WinControls.UI.RadButton();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxTransDecrypted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransEncrypted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblColumns);
            this.radPanel1.Controls.Add(this.btnSetColumns);
            this.radPanel1.Controls.Add(this.txtSetColumns);
            this.radPanel1.Location = new System.Drawing.Point(257, 113);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(283, 130);
            this.radPanel1.TabIndex = 32;
            // 
            // lblColumns
            // 
            this.lblColumns.Location = new System.Drawing.Point(15, 76);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(113, 18);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Number of Columns: ";
            // 
            // btnSetColumns
            // 
            this.btnSetColumns.Location = new System.Drawing.Point(135, 32);
            this.btnSetColumns.Name = "btnSetColumns";
            this.btnSetColumns.Size = new System.Drawing.Size(138, 24);
            this.btnSetColumns.TabIndex = 1;
            this.btnSetColumns.Text = "Set number of columns";
            this.btnSetColumns.Click += new System.EventHandler(this.btnSetColumns_Click);
            // 
            // txtSetColumns
            // 
            this.txtSetColumns.Location = new System.Drawing.Point(15, 34);
            this.txtSetColumns.Name = "txtSetColumns";
            this.txtSetColumns.Size = new System.Drawing.Size(100, 20);
            this.txtSetColumns.TabIndex = 0;
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.Location = new System.Drawing.Point(648, 89);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(84, 18);
            this.lblDecrypt.TabIndex = 29;
            this.lblDecrypt.Text = "Decrypted Text:";
            this.lblDecrypt.Visible = false;
            // 
            // lblEnter
            // 
            this.lblEnter.Location = new System.Drawing.Point(5, 26);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(107, 18);
            this.lblEnter.TabIndex = 31;
            this.lblEnter.Text = "Enter message here:";
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.Location = new System.Drawing.Point(62, 89);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(83, 18);
            this.lblEncrypt.TabIndex = 30;
            this.lblEncrypt.Text = "Encrypted Text:";
            this.lblEncrypt.Visible = false;
            // 
            // lbxTransDecrypted
            // 
            this.lbxTransDecrypted.AllowEdit = false;
            this.lbxTransDecrypted.AllowRemove = false;
            this.lbxTransDecrypted.Location = new System.Drawing.Point(546, 113);
            this.lbxTransDecrypted.Name = "lbxTransDecrypted";
            this.lbxTransDecrypted.Size = new System.Drawing.Size(283, 130);
            this.lbxTransDecrypted.TabIndex = 28;
            // 
            // txtTransEncrypted
            // 
            this.txtTransEncrypted.Location = new System.Drawing.Point(5, 113);
            this.txtTransEncrypted.Multiline = true;
            this.txtTransEncrypted.Name = "txtTransEncrypted";
            // 
            // 
            // 
            this.txtTransEncrypted.RootElement.StretchVertically = true;
            this.txtTransEncrypted.Size = new System.Drawing.Size(238, 130);
            this.txtTransEncrypted.TabIndex = 27;
            // 
            // txtTransMessage
            // 
            this.txtTransMessage.Location = new System.Drawing.Point(5, 50);
            this.txtTransMessage.Multiline = true;
            this.txtTransMessage.Name = "txtTransMessage";
            // 
            // 
            // 
            this.txtTransMessage.RootElement.StretchVertically = true;
            this.txtTransMessage.Size = new System.Drawing.Size(487, 30);
            this.txtTransMessage.TabIndex = 26;
            // 
            // btnTransDecrypt
            // 
            this.btnTransDecrypt.Location = new System.Drawing.Point(622, 50);
            this.btnTransDecrypt.Name = "btnTransDecrypt";
            this.btnTransDecrypt.Size = new System.Drawing.Size(110, 24);
            this.btnTransDecrypt.TabIndex = 25;
            this.btnTransDecrypt.Text = "Decrypt";
            this.btnTransDecrypt.Click += new System.EventHandler(this.btnTransDecrypt_Click);
            // 
            // btnTransEncrypt
            // 
            this.btnTransEncrypt.Location = new System.Drawing.Point(498, 50);
            this.btnTransEncrypt.Name = "btnTransEncrypt";
            this.btnTransEncrypt.Size = new System.Drawing.Size(110, 24);
            this.btnTransEncrypt.TabIndex = 24;
            this.btnTransEncrypt.Text = "Encrypt";
            this.btnTransEncrypt.Click += new System.EventHandler(this.btnTransEncrypt_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(842, 20);
            this.radMenu1.TabIndex = 33;
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
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click_1);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Decrypt";
            this.radMenuItem4.UseCompatibleTextRendering = false;
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click_1);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Reset";
            this.radMenuItem5.UseCompatibleTextRendering = false;
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click_1);
            // 
            // Transposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.lblDecrypt);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.lbxTransDecrypted);
            this.Controls.Add(this.txtTransEncrypted);
            this.Controls.Add(this.txtTransMessage);
            this.Controls.Add(this.btnTransDecrypt);
            this.Controls.Add(this.btnTransEncrypt);
            this.Name = "Transposition";
            this.Size = new System.Drawing.Size(842, 276);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxTransDecrypted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransEncrypted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblColumns;
        private Telerik.WinControls.UI.RadButton btnSetColumns;
        private Telerik.WinControls.UI.RadTextBox txtSetColumns;
        private Telerik.WinControls.UI.RadLabel lblDecrypt;
        private Telerik.WinControls.UI.RadLabel lblEnter;
        private Telerik.WinControls.UI.RadLabel lblEncrypt;
        private Telerik.WinControls.UI.RadListView lbxTransDecrypted;
        private Telerik.WinControls.UI.RadTextBox txtTransEncrypted;
        private Telerik.WinControls.UI.RadTextBox txtTransMessage;
        private Telerik.WinControls.UI.RadButton btnTransDecrypt;
        private Telerik.WinControls.UI.RadButton btnTransEncrypt;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
    }
}
