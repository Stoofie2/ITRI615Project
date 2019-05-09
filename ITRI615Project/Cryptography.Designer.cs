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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVernamDecrypt = new System.Windows.Forms.Button();
            this.btnVernamEncrypt = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVigDecOutput = new System.Windows.Forms.TextBox();
            this.lstbxVigOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVigMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecryptVig = new System.Windows.Forms.Button();
            this.btnEncryptVig = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstbxOutputRSA = new System.Windows.Forms.TextBox();
            this.lstbxRSADecryptOutput = new System.Windows.Forms.ListBox();
            this.lblRSAOut = new System.Windows.Forms.Label();
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
            this.exportImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVernamMessEncrypted = new System.Windows.Forms.TextBox();
            this.lstbxVernamMessDecrypt = new System.Windows.Forms.ListBox();
            this.lblVernamKeyOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVernamMessageInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 419);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.menuStrip3);
            this.tabPage2.Controls.Add(this.txtVernamMessEncrypted);
            this.tabPage2.Controls.Add(this.lstbxVernamMessDecrypt);
            this.tabPage2.Controls.Add(this.lblVernamKeyOutput);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtVernamMessageInput);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnVernamDecrypt);
            this.tabPage2.Controls.Add(this.btnVernamEncrypt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vernam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVernamDecrypt
            // 
            this.btnVernamDecrypt.Location = new System.Drawing.Point(334, 92);
            this.btnVernamDecrypt.Name = "btnVernamDecrypt";
            this.btnVernamDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnVernamDecrypt.TabIndex = 1;
            this.btnVernamDecrypt.Text = "Decrypt";
            this.btnVernamDecrypt.UseVisualStyleBackColor = true;
            this.btnVernamDecrypt.Click += new System.EventHandler(this.btnVernamDecrypt_Click);
            // 
            // btnVernamEncrypt
            // 
            this.btnVernamEncrypt.Location = new System.Drawing.Point(334, 61);
            this.btnVernamEncrypt.Name = "btnVernamEncrypt";
            this.btnVernamEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnVernamEncrypt.TabIndex = 0;
            this.btnVernamEncrypt.Text = "Encrypt";
            this.btnVernamEncrypt.UseVisualStyleBackColor = true;
            this.btnVernamEncrypt.Click += new System.EventHandler(this.btnVernamEncrypt_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.menuStrip2);
            this.tabPage5.Controls.Add(this.txtVigDecOutput);
            this.tabPage5.Controls.Add(this.lstbxVigOutput);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.txtVigMessage);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.btnDecryptVig);
            this.tabPage5.Controls.Add(this.btnEncryptVig);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Vigenere";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(768, 24);
            this.menuStrip2.TabIndex = 36;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Tools";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem4.Text = "Encrypt/Decrypt Files";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem5.Text = "Encrypt";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem6.Text = "Decrypt";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // txtVigDecOutput
            // 
            this.txtVigDecOutput.Location = new System.Drawing.Point(15, 112);
            this.txtVigDecOutput.Multiline = true;
            this.txtVigDecOutput.Name = "txtVigDecOutput";
            this.txtVigDecOutput.ReadOnly = true;
            this.txtVigDecOutput.Size = new System.Drawing.Size(277, 238);
            this.txtVigDecOutput.TabIndex = 35;
            // 
            // lstbxVigOutput
            // 
            this.lstbxVigOutput.FormattingEnabled = true;
            this.lstbxVigOutput.Location = new System.Drawing.Point(477, 112);
            this.lstbxVigOutput.Name = "lstbxVigOutput";
            this.lstbxVigOutput.Size = new System.Drawing.Size(277, 238);
            this.lstbxVigOutput.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Enter message to encrypt/decrypt:";
            // 
            // txtVigMessage
            // 
            this.txtVigMessage.Location = new System.Drawing.Point(15, 61);
            this.txtVigMessage.Multiline = true;
            this.txtVigMessage.Name = "txtVigMessage";
            this.txtVigMessage.Size = new System.Drawing.Size(277, 45);
            this.txtVigMessage.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 30;
            // 
            // btnDecryptVig
            // 
            this.btnDecryptVig.Location = new System.Drawing.Point(336, 101);
            this.btnDecryptVig.Name = "btnDecryptVig";
            this.btnDecryptVig.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptVig.TabIndex = 29;
            this.btnDecryptVig.Text = "Decrypt";
            this.btnDecryptVig.UseVisualStyleBackColor = true;
            this.btnDecryptVig.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEncryptVig
            // 
            this.btnEncryptVig.Location = new System.Drawing.Point(336, 61);
            this.btnEncryptVig.Name = "btnEncryptVig";
            this.btnEncryptVig.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptVig.TabIndex = 28;
            this.btnEncryptVig.Text = "Encrypt";
            this.btnEncryptVig.UseVisualStyleBackColor = true;
            this.btnEncryptVig.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transposition";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage1.Text = "Custom Algorithm";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // lstbxRSADecryptOutput
            // 
            this.lstbxRSADecryptOutput.FormattingEnabled = true;
            this.lstbxRSADecryptOutput.Location = new System.Drawing.Point(468, 129);
            this.lstbxRSADecryptOutput.Name = "lstbxRSADecryptOutput";
            this.lstbxRSADecryptOutput.Size = new System.Drawing.Size(277, 238);
            this.lstbxRSADecryptOutput.TabIndex = 26;
            // 
            // lblRSAOut
            // 
            this.lblRSAOut.AutoSize = true;
            this.lblRSAOut.Location = new System.Drawing.Point(491, 60);
            this.lblRSAOut.Name = "lblRSAOut";
            this.lblRSAOut.Size = new System.Drawing.Size(0, 13);
            this.lblRSAOut.TabIndex = 25;
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
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
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
            this.importPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importPrivateKeyToolStripMenuItem.Text = "Import Private Key";
            // 
            // importPublicKeyToolStripMenuItem
            // 
            this.importPublicKeyToolStripMenuItem.Name = "importPublicKeyToolStripMenuItem";
            this.importPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importPublicKeyToolStripMenuItem.Text = "Import Public Key";
            // 
            // exportPrivateKeyToolStripMenuItem
            // 
            this.exportPrivateKeyToolStripMenuItem.Name = "exportPrivateKeyToolStripMenuItem";
            this.exportPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exportPrivateKeyToolStripMenuItem.Text = "Export Private Key";
            // 
            // exportPublicKeyToolStripMenuItem
            // 
            this.exportPublicKeyToolStripMenuItem.Name = "exportPublicKeyToolStripMenuItem";
            this.exportPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exportPublicKeyToolStripMenuItem.Text = "Export Public Key";
            // 
            // txtVernamMessEncrypted
            // 
            this.txtVernamMessEncrypted.Location = new System.Drawing.Point(9, 114);
            this.txtVernamMessEncrypted.Multiline = true;
            this.txtVernamMessEncrypted.Name = "txtVernamMessEncrypted";
            this.txtVernamMessEncrypted.ReadOnly = true;
            this.txtVernamMessEncrypted.Size = new System.Drawing.Size(277, 238);
            this.txtVernamMessEncrypted.TabIndex = 41;
            // 
            // lstbxVernamMessDecrypt
            // 
            this.lstbxVernamMessDecrypt.FormattingEnabled = true;
            this.lstbxVernamMessDecrypt.Location = new System.Drawing.Point(470, 114);
            this.lstbxVernamMessDecrypt.Name = "lstbxVernamMessDecrypt";
            this.lstbxVernamMessDecrypt.Size = new System.Drawing.Size(277, 238);
            this.lstbxVernamMessDecrypt.TabIndex = 40;
            // 
            // lblVernamKeyOutput
            // 
            this.lblVernamKeyOutput.AutoSize = true;
            this.lblVernamKeyOutput.Location = new System.Drawing.Point(491, 45);
            this.lblVernamKeyOutput.Name = "lblVernamKeyOutput";
            this.lblVernamKeyOutput.Size = new System.Drawing.Size(0, 13);
            this.lblVernamKeyOutput.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Enter message to encrypt/decrypt:";
            // 
            // txtVernamMessageInput
            // 
            this.txtVernamMessageInput.Location = new System.Drawing.Point(9, 61);
            this.txtVernamMessageInput.Multiline = true;
            this.txtVernamMessageInput.Name = "txtVernamMessageInput";
            this.txtVernamMessageInput.Size = new System.Drawing.Size(277, 45);
            this.txtVernamMessageInput.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 36;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(762, 24);
            this.menuStrip3.TabIndex = 42;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem2.Text = "Tools";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem3.Text = "Encrypt/Decrypt Files";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "Encrypt";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "Decrypt";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txtVigDecOutput;
        private System.Windows.Forms.ListBox lstbxVigOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVigMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecryptVig;
        private System.Windows.Forms.Button btnEncryptVig;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.TextBox txtVernamMessEncrypted;
        private System.Windows.Forms.ListBox lstbxVernamMessDecrypt;
        private System.Windows.Forms.Label lblVernamKeyOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVernamMessageInput;
    }
}

