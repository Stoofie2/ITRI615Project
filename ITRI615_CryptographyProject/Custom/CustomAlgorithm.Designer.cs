namespace ITRI615_CryptographyProject.Custom
{
    partial class CustomAlgorithm
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.lblCustomColumns = new Telerik.WinControls.UI.RadLabel();
            this.btnCustomSetColumn = new Telerik.WinControls.UI.RadButton();
            this.txtCustomColumns = new Telerik.WinControls.UI.RadTextBox();
            this.lblDecrypt = new Telerik.WinControls.UI.RadLabel();
            this.lblEnter = new Telerik.WinControls.UI.RadLabel();
            this.lblEncrypt = new Telerik.WinControls.UI.RadLabel();
            this.lbxCustomDecrypt = new Telerik.WinControls.UI.RadListView();
            this.txtCustomEncrypt = new Telerik.WinControls.UI.RadTextBox();
            this.txtCustomMessage = new Telerik.WinControls.UI.RadTextBox();
            this.btnCustomDecrypt = new Telerik.WinControls.UI.RadButton();
            this.btnCustomEncrypt = new Telerik.WinControls.UI.RadButton();
            this.lblCustomShift = new Telerik.WinControls.UI.RadLabel();
            this.btnCustomSetShift = new Telerik.WinControls.UI.RadButton();
            this.txtCustomShift = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomSetColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxCustomDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomSetShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomShift)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(846, 20);
            this.radMenu1.TabIndex = 43;
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
            this.radMenuItem5.UseCompatibleTextRendering = false;
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.lblCustomShift);
            this.radPanel1.Controls.Add(this.lblCustomColumns);
            this.radPanel1.Controls.Add(this.btnCustomSetShift);
            this.radPanel1.Controls.Add(this.btnCustomSetColumn);
            this.radPanel1.Controls.Add(this.txtCustomShift);
            this.radPanel1.Controls.Add(this.txtCustomColumns);
            this.radPanel1.Location = new System.Drawing.Point(261, 112);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(283, 130);
            this.radPanel1.TabIndex = 42;
            // 
            // lblCustomColumns
            // 
            this.lblCustomColumns.Location = new System.Drawing.Point(16, 103);
            this.lblCustomColumns.Name = "lblCustomColumns";
            this.lblCustomColumns.Size = new System.Drawing.Size(113, 18);
            this.lblCustomColumns.TabIndex = 2;
            this.lblCustomColumns.Text = "Number of Columns: ";
            // 
            // btnCustomSetColumn
            // 
            this.btnCustomSetColumn.Location = new System.Drawing.Point(136, 75);
            this.btnCustomSetColumn.Name = "btnCustomSetColumn";
            this.btnCustomSetColumn.Size = new System.Drawing.Size(138, 24);
            this.btnCustomSetColumn.TabIndex = 1;
            this.btnCustomSetColumn.Text = "Set number of columns";
            this.btnCustomSetColumn.Click += new System.EventHandler(this.btnCustomSetColumn_Click);
            // 
            // txtCustomColumns
            // 
            this.txtCustomColumns.Location = new System.Drawing.Point(16, 77);
            this.txtCustomColumns.Name = "txtCustomColumns";
            this.txtCustomColumns.Size = new System.Drawing.Size(100, 20);
            this.txtCustomColumns.TabIndex = 0;
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.Location = new System.Drawing.Point(652, 88);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(84, 18);
            this.lblDecrypt.TabIndex = 39;
            this.lblDecrypt.Text = "Decrypted Text:";
            this.lblDecrypt.Visible = false;
            // 
            // lblEnter
            // 
            this.lblEnter.Location = new System.Drawing.Point(9, 25);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(107, 18);
            this.lblEnter.TabIndex = 41;
            this.lblEnter.Text = "Enter message here:";
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.Location = new System.Drawing.Point(66, 88);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(83, 18);
            this.lblEncrypt.TabIndex = 40;
            this.lblEncrypt.Text = "Encrypted Text:";
            this.lblEncrypt.Visible = false;
            // 
            // lbxCustomDecrypt
            // 
            this.lbxCustomDecrypt.AllowEdit = false;
            this.lbxCustomDecrypt.AllowRemove = false;
            this.lbxCustomDecrypt.Location = new System.Drawing.Point(550, 112);
            this.lbxCustomDecrypt.Name = "lbxCustomDecrypt";
            this.lbxCustomDecrypt.Size = new System.Drawing.Size(283, 130);
            this.lbxCustomDecrypt.TabIndex = 38;
            // 
            // txtCustomEncrypt
            // 
            this.txtCustomEncrypt.Location = new System.Drawing.Point(9, 112);
            this.txtCustomEncrypt.Multiline = true;
            this.txtCustomEncrypt.Name = "txtCustomEncrypt";
            // 
            // 
            // 
            this.txtCustomEncrypt.RootElement.StretchVertically = true;
            this.txtCustomEncrypt.Size = new System.Drawing.Size(238, 130);
            this.txtCustomEncrypt.TabIndex = 37;
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Location = new System.Drawing.Point(9, 49);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            // 
            // 
            // 
            this.txtCustomMessage.RootElement.StretchVertically = true;
            this.txtCustomMessage.Size = new System.Drawing.Size(487, 30);
            this.txtCustomMessage.TabIndex = 36;
            // 
            // btnCustomDecrypt
            // 
            this.btnCustomDecrypt.Location = new System.Drawing.Point(626, 49);
            this.btnCustomDecrypt.Name = "btnCustomDecrypt";
            this.btnCustomDecrypt.Size = new System.Drawing.Size(110, 24);
            this.btnCustomDecrypt.TabIndex = 35;
            this.btnCustomDecrypt.Text = "Decrypt";
            this.btnCustomDecrypt.Click += new System.EventHandler(this.btnCustomDecrypt_Click);
            // 
            // btnCustomEncrypt
            // 
            this.btnCustomEncrypt.Location = new System.Drawing.Point(502, 49);
            this.btnCustomEncrypt.Name = "btnCustomEncrypt";
            this.btnCustomEncrypt.Size = new System.Drawing.Size(110, 24);
            this.btnCustomEncrypt.TabIndex = 34;
            this.btnCustomEncrypt.Text = "Encrypt";
            this.btnCustomEncrypt.Click += new System.EventHandler(this.btnCustomEncrypt_Click);
            // 
            // lblCustomShift
            // 
            this.lblCustomShift.Location = new System.Drawing.Point(16, 40);
            this.lblCustomShift.Name = "lblCustomShift";
            this.lblCustomShift.Size = new System.Drawing.Size(52, 18);
            this.lblCustomShift.TabIndex = 5;
            this.lblCustomShift.Text = "Shift Key:";
            // 
            // btnCustomSetShift
            // 
            this.btnCustomSetShift.Location = new System.Drawing.Point(136, 12);
            this.btnCustomSetShift.Name = "btnCustomSetShift";
            this.btnCustomSetShift.Size = new System.Drawing.Size(138, 24);
            this.btnCustomSetShift.TabIndex = 4;
            this.btnCustomSetShift.Text = "Set shift key";
            this.btnCustomSetShift.Click += new System.EventHandler(this.btnCustomSetShift_Click);
            // 
            // txtCustomShift
            // 
            this.txtCustomShift.Location = new System.Drawing.Point(16, 14);
            this.txtCustomShift.Name = "txtCustomShift";
            this.txtCustomShift.Size = new System.Drawing.Size(100, 20);
            this.txtCustomShift.TabIndex = 3;
            // 
            // CustomAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.lblDecrypt);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.lbxCustomDecrypt);
            this.Controls.Add(this.txtCustomEncrypt);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.btnCustomDecrypt);
            this.Controls.Add(this.btnCustomEncrypt);
            this.Name = "CustomAlgorithm";
            this.Size = new System.Drawing.Size(846, 260);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomSetColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxCustomDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomSetShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel lblCustomColumns;
        private Telerik.WinControls.UI.RadButton btnCustomSetColumn;
        private Telerik.WinControls.UI.RadTextBox txtCustomColumns;
        private Telerik.WinControls.UI.RadLabel lblDecrypt;
        private Telerik.WinControls.UI.RadLabel lblEnter;
        private Telerik.WinControls.UI.RadLabel lblEncrypt;
        private Telerik.WinControls.UI.RadListView lbxCustomDecrypt;
        private Telerik.WinControls.UI.RadTextBox txtCustomEncrypt;
        private Telerik.WinControls.UI.RadTextBox txtCustomMessage;
        private Telerik.WinControls.UI.RadButton btnCustomDecrypt;
        private Telerik.WinControls.UI.RadButton btnCustomEncrypt;
        private Telerik.WinControls.UI.RadLabel lblCustomShift;
        private Telerik.WinControls.UI.RadButton btnCustomSetShift;
        private Telerik.WinControls.UI.RadTextBox txtCustomShift;
    }
}
