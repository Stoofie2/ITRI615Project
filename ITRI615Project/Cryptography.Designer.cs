namespace ITRI615Project
{
    partial class frmHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblOutputRSA = new System.Windows.Forms.Label();
            this.txtRSAPlainText = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.encryptDecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptDecryptFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVernamDecrypt = new System.Windows.Forms.Button();
            this.btnVernamEncrypt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblRSAOut = new System.Windows.Forms.Label();
            this.lstbxRSADecryptOutput = new System.Windows.Forms.ListBox();
            this.lstbxOutputRSA = new System.Windows.Forms.TextBox();
            this.exportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 419);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstbxOutputRSA);
            this.tabPage1.Controls.Add(this.lstbxRSADecryptOutput);
            this.tabPage1.Controls.Add(this.lblRSAOut);
            this.tabPage1.Controls.Add(this.lblOutputRSA);
            this.tabPage1.Controls.Add(this.txtRSAPlainText);
            this.tabPage1.Controls.Add(this.lblOutput);
            this.tabPage1.Controls.Add(this.btnDecrypt);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA Algorithm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblOutputRSA
            // 
            this.lblOutputRSA.AutoSize = true;
            this.lblOutputRSA.Location = new System.Drawing.Point(6, 60);
            this.lblOutputRSA.Name = "lblOutputRSA";
            this.lblOutputRSA.Size = new System.Drawing.Size(170, 13);
            this.lblOutputRSA.TabIndex = 24;
            this.lblOutputRSA.Text = "Enter message to encrypt/decrypt:";
            // 
            // txtRSAPlainText
            // 
            this.txtRSAPlainText.Location = new System.Drawing.Point(6, 78);
            this.txtRSAPlainText.Multiline = true;
            this.txtRSAPlainText.Name = "txtRSAPlainText";
            this.txtRSAPlainText.Size = new System.Drawing.Size(277, 45);
            this.txtRSAPlainText.TabIndex = 23;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(387, 336);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 17;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(327, 118);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(327, 78);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptDecryptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // encryptDecryptToolStripMenuItem
            // 
            this.encryptDecryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.resetKeysToolStripMenuItem,
            this.encryptDecryptFilesToolStripMenuItem,
            this.exportImportToolStripMenuItem});
            this.encryptDecryptToolStripMenuItem.Name = "encryptDecryptToolStripMenuItem";
            this.encryptDecryptToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.encryptDecryptToolStripMenuItem.Text = "Tools";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetToolStripMenuItem.Text = "Generate Keys";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // resetKeysToolStripMenuItem
            // 
            this.resetKeysToolStripMenuItem.Name = "resetKeysToolStripMenuItem";
            this.resetKeysToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetKeysToolStripMenuItem.Text = "Reset Keys";
            // 
            // encryptDecryptFilesToolStripMenuItem
            // 
            this.encryptDecryptFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.encryptDecryptFilesToolStripMenuItem.Enabled = false;
            this.encryptDecryptFilesToolStripMenuItem.Name = "encryptDecryptFilesToolStripMenuItem";
            this.encryptDecryptFilesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.encryptDecryptFilesToolStripMenuItem.Text = "Encrypt/Decrypt Files";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnVernamDecrypt);
            this.tabPage2.Controls.Add(this.btnVernamEncrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vernam Algorithm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVernamDecrypt
            // 
            this.btnVernamDecrypt.Location = new System.Drawing.Point(24, 109);
            this.btnVernamDecrypt.Name = "btnVernamDecrypt";
            this.btnVernamDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnVernamDecrypt.TabIndex = 1;
            this.btnVernamDecrypt.Text = "Decrypt";
            this.btnVernamDecrypt.UseVisualStyleBackColor = true;
            this.btnVernamDecrypt.Click += new System.EventHandler(this.btnVernamDecrypt_Click);
            // 
            // btnVernamEncrypt
            // 
            this.btnVernamEncrypt.Location = new System.Drawing.Point(24, 61);
            this.btnVernamEncrypt.Name = "btnVernamEncrypt";
            this.btnVernamEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnVernamEncrypt.TabIndex = 0;
            this.btnVernamEncrypt.Text = "Encrypt";
            this.btnVernamEncrypt.UseVisualStyleBackColor = true;
            this.btnVernamEncrypt.Click += new System.EventHandler(this.btnVernamEncrypt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mott Algorithm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Custom Algorithm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblRSAOut
            // 
            this.lblRSAOut.AutoSize = true;
            this.lblRSAOut.Location = new System.Drawing.Point(491, 60);
            this.lblRSAOut.Name = "lblRSAOut";
            this.lblRSAOut.Size = new System.Drawing.Size(0, 13);
            this.lblRSAOut.TabIndex = 25;
            // 
            // lstbxRSADecryptOutput
            // 
            this.lstbxRSADecryptOutput.FormattingEnabled = true;
            this.lstbxRSADecryptOutput.Location = new System.Drawing.Point(468, 129);
            this.lstbxRSADecryptOutput.Name = "lstbxRSADecryptOutput";
            this.lstbxRSADecryptOutput.Size = new System.Drawing.Size(277, 238);
            this.lstbxRSADecryptOutput.TabIndex = 26;
            // 
            // lstbxOutputRSA
            // 
            this.lstbxOutputRSA.Location = new System.Drawing.Point(6, 129);
            this.lstbxOutputRSA.Multiline = true;
            this.lstbxOutputRSA.Name = "lstbxOutputRSA";
            this.lstbxOutputRSA.ReadOnly = true;
            this.lstbxOutputRSA.Size = new System.Drawing.Size(277, 238);
            this.lstbxOutputRSA.TabIndex = 27;
            // 
            // exportImportToolStripMenuItem
            // 
            this.exportImportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPrivateKeyToolStripMenuItem,
            this.importPublicKeyToolStripMenuItem,
            this.exportPrivateKeyToolStripMenuItem,
            this.exportPublicKeyToolStripMenuItem});
            this.exportImportToolStripMenuItem.Enabled = false;
            this.exportImportToolStripMenuItem.Name = "exportImportToolStripMenuItem";
            this.exportImportToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exportImportToolStripMenuItem.Text = "Export/Import";
            // 
            // importPrivateKeyToolStripMenuItem
            // 
            this.importPrivateKeyToolStripMenuItem.Name = "importPrivateKeyToolStripMenuItem";
            this.importPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importPrivateKeyToolStripMenuItem.Text = "Import Private Key";
            // 
            // importPublicKeyToolStripMenuItem
            // 
            this.importPublicKeyToolStripMenuItem.Name = "importPublicKeyToolStripMenuItem";
            this.importPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importPublicKeyToolStripMenuItem.Text = "Import Public Key";
            // 
            // exportPrivateKeyToolStripMenuItem
            // 
            this.exportPrivateKeyToolStripMenuItem.Name = "exportPrivateKeyToolStripMenuItem";
            this.exportPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportPrivateKeyToolStripMenuItem.Text = "Export Private Key";
            // 
            // exportPublicKeyToolStripMenuItem
            // 
            this.exportPublicKeyToolStripMenuItem.Name = "exportPublicKeyToolStripMenuItem";
            this.exportPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportPublicKeyToolStripMenuItem.Text = "Export Public Key";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnVernamDecrypt;
        private System.Windows.Forms.Button btnVernamEncrypt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem encryptDecryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetKeysToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRSAPlainText;
        private System.Windows.Forms.ToolStripMenuItem encryptDecryptFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.Label lblOutputRSA;
        private System.Windows.Forms.Label lblRSAOut;
        private System.Windows.Forms.ListBox lstbxRSADecryptOutput;
        private System.Windows.Forms.TextBox lstbxOutputRSA;
        private System.Windows.Forms.ToolStripMenuItem exportImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPrivateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPublicKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPrivateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPublicKeyToolStripMenuItem;
    }
}

