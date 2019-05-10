namespace ITRI615_CryptographyProject
{
    partial class rdfrmCryptography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rdfrmCryptography));
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.algorithmGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.transpositionTile = new Telerik.WinControls.UI.RadTileElement();
            this.customAlgorithmTile = new Telerik.WinControls.UI.RadTileElement();
            this.vernamTile = new Telerik.WinControls.UI.RadTileElement();
            this.vignereTile = new Telerik.WinControls.UI.RadTileElement();
            this.resourcesGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.fileExplorerTile = new Telerik.WinControls.UI.RadTileElement();
            this.linkGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.githubTile = new Telerik.WinControls.UI.RadTileElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanorama1
            // 
            this.radPanorama1.AutoArrangeNewTiles = false;
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.algorithmGroup,
            this.resourcesGroup,
            this.linkGroup});
            this.radPanorama1.Location = new System.Drawing.Point(0, 0);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.PanelImageSize = new System.Drawing.Size(1024, 768);
            this.radPanorama1.RowsCount = 2;
            this.radPanorama1.ShowGroups = true;
            this.radPanorama1.Size = new System.Drawing.Size(912, 566);
            this.radPanorama1.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPanoramaElement)(this.radPanorama1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(117)))));
            // 
            // algorithmGroup
            // 
            this.algorithmGroup.CellSize = new System.Drawing.Size(155, 155);
            this.algorithmGroup.ClickMode = Telerik.WinControls.ClickMode.Release;
            this.algorithmGroup.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.algorithmGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.algorithmGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.algorithmGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.transpositionTile,
            this.customAlgorithmTile,
            this.vernamTile,
            this.vignereTile});
            this.algorithmGroup.Margin = new System.Windows.Forms.Padding(120, 130, 65, 0);
            this.algorithmGroup.Name = "algorithmGroup";
            this.algorithmGroup.RowsCount = 2;
            this.algorithmGroup.Text = "Algorithms";
            this.algorithmGroup.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.algorithmGroup.UseCompatibleTextRendering = true;
            this.algorithmGroup.Click += new System.EventHandler(this.applicationsGroup_Click);
            // 
            // transpositionTile
            // 
            this.transpositionTile.AccessibleDescription = "radTileElement2";
            this.transpositionTile.AccessibleName = "radTileElement2";
            this.transpositionTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.transpositionTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.transpositionTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.transpositionTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.transpositionTile.Column = 1;
            this.transpositionTile.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.transpositionTile.DrawBorder = true;
            this.transpositionTile.GradientAngle = 0F;
            this.transpositionTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.transpositionTile.Image = global::ITRI615_CryptographyProject.Properties.Resources.transposition;
            this.transpositionTile.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.transpositionTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transpositionTile.Name = "transpositionTile";
            this.transpositionTile.Padding = new System.Windows.Forms.Padding(15, 15, 0, 10);
            this.transpositionTile.Text = "Transposition";
            this.transpositionTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.transpositionTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.transpositionTile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.transpositionTile.UseCompatibleTextRendering = false;
            this.transpositionTile.Click += new System.EventHandler(this.transpositionTile_Click);
            // 
            // customAlgorithmTile
            // 
            this.customAlgorithmTile.AccessibleDescription = "radTileElement3";
            this.customAlgorithmTile.AccessibleName = "radTileElement3";
            this.customAlgorithmTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.customAlgorithmTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.customAlgorithmTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.customAlgorithmTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.customAlgorithmTile.Column = 1;
            this.customAlgorithmTile.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.customAlgorithmTile.DrawBorder = true;
            this.customAlgorithmTile.GradientAngle = 0F;
            this.customAlgorithmTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.customAlgorithmTile.Image = global::ITRI615_CryptographyProject.Properties.Resources.custom;
            this.customAlgorithmTile.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.customAlgorithmTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customAlgorithmTile.Name = "customAlgorithmTile";
            this.customAlgorithmTile.Padding = new System.Windows.Forms.Padding(15, 15, 0, 10);
            this.customAlgorithmTile.Row = 1;
            this.customAlgorithmTile.Text = "Custom";
            this.customAlgorithmTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.customAlgorithmTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.customAlgorithmTile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.customAlgorithmTile.UseCompatibleTextRendering = false;
            this.customAlgorithmTile.Click += new System.EventHandler(this.customAlgorithmTile_Click);
            // 
            // vernamTile
            // 
            this.vernamTile.AccessibleDescription = "radTileElement4";
            this.vernamTile.AccessibleName = "radTileElement4";
            this.vernamTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.vernamTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.vernamTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.vernamTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.vernamTile.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.vernamTile.DrawBorder = true;
            this.vernamTile.GradientAngle = 0F;
            this.vernamTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.vernamTile.Image = global::ITRI615_CryptographyProject.Properties.Resources.vernam;
            this.vernamTile.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.vernamTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vernamTile.Name = "vernamTile";
            this.vernamTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.vernamTile.Row = 1;
            this.vernamTile.Text = "Vernam";
            this.vernamTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vernamTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.vernamTile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.vernamTile.UseCompatibleTextRendering = false;
            this.vernamTile.Click += new System.EventHandler(this.vernamTile_Click);
            // 
            // vignereTile
            // 
            this.vignereTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.vignereTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.vignereTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.vignereTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.vignereTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.vignereTile.Image = global::ITRI615_CryptographyProject.Properties.Resources.vig1;
            this.vignereTile.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.vignereTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vignereTile.Name = "vignereTile";
            this.vignereTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.vignereTile.Text = "Vigenere";
            this.vignereTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vignereTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.vignereTile.UseCompatibleTextRendering = false;
            this.vignereTile.Click += new System.EventHandler(this.vignereTile_Click);
            // 
            // resourcesGroup
            // 
            this.resourcesGroup.AutoSize = true;
            this.resourcesGroup.CellSize = new System.Drawing.Size(155, 155);
            this.resourcesGroup.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.resourcesGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resourcesGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.resourcesGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.fileExplorerTile});
            this.resourcesGroup.Margin = new System.Windows.Forms.Padding(0, 130, 65, 0);
            this.resourcesGroup.Name = "resourcesGroup";
            this.resourcesGroup.RowsCount = 2;
            this.resourcesGroup.Text = "Resources";
            this.resourcesGroup.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.resourcesGroup.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.resourcesGroup.UseCompatibleTextRendering = false;
            // 
            // fileExplorerTile
            // 
            this.fileExplorerTile.AccessibleDescription = "radTileElement1";
            this.fileExplorerTile.AccessibleName = "radTileElement1";
            this.fileExplorerTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.fileExplorerTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.fileExplorerTile.ColSpan = 2;
            this.fileExplorerTile.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.fileExplorerTile.DrawBorder = true;
            this.fileExplorerTile.Image = global::ITRI615_CryptographyProject.Properties.Resources.File_Explorer_icon1;
            this.fileExplorerTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.fileExplorerTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileExplorerTile.Name = "fileExplorerTile";
            this.fileExplorerTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.fileExplorerTile.Text = "Directory";
            this.fileExplorerTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.fileExplorerTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fileExplorerTile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.fileExplorerTile.UseCompatibleTextRendering = false;
            this.fileExplorerTile.Click += new System.EventHandler(this.fileExplorerTile_Click);
            // 
            // linkGroup
            // 
            this.linkGroup.CellSize = new System.Drawing.Size(155, 155);
            this.linkGroup.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linkGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.linkGroup.Image = null;
            this.linkGroup.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.githubTile});
            this.linkGroup.Margin = new System.Windows.Forms.Padding(0, 130, 65, 0);
            this.linkGroup.Name = "linkGroup";
            this.linkGroup.RowsCount = 2;
            this.linkGroup.Text = "Github";
            this.linkGroup.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linkGroup.UseCompatibleTextRendering = false;
            this.linkGroup.Click += new System.EventHandler(this.linkGroup_Click);
            // 
            // githubTile
            // 
            this.githubTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(177)))), ((int)(((byte)(69)))));
            this.githubTile.Image = global::ITRI615_CryptographyProject.Properties.Resources.github_logo;
            this.githubTile.Name = "githubTile";
            this.githubTile.Text = "";
            this.githubTile.Click += new System.EventHandler(this.githubTile_Click);
            // 
            // rdfrmCryptography
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(912, 566);
            this.Controls.Add(this.radPanorama1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rdfrmCryptography";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RadForm1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RadForm1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.UI.TileGroupElement algorithmGroup;
        private Telerik.WinControls.UI.RadTileElement transpositionTile;
        private Telerik.WinControls.UI.RadTileElement customAlgorithmTile;
        private Telerik.WinControls.UI.RadTileElement vernamTile;
        private Telerik.WinControls.UI.TileGroupElement resourcesGroup;
        private Telerik.WinControls.UI.RadTileElement fileExplorerTile;
        private Telerik.WinControls.UI.TileGroupElement linkGroup;
        private Telerik.WinControls.UI.RadTileElement vignereTile;
        private Telerik.WinControls.UI.RadTileElement githubTile;
    }
}