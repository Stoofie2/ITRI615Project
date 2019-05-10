using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using ITRI615_CryptographyProject.Properties;
using System.IO;
using System.Diagnostics;

namespace ITRI615_CryptographyProject
{
    public partial class rdfrmCryptography : Telerik.WinControls.UI.RadForm
    {
        public const int WM_SIZE = 5;

        private LightVisualElement examplePage;
        private RadButtonElement backButton;
        private LightVisualElement headerLabel;
        private RadTitleBarElement titleBar;

        private bool isFormMoving = false;
        private string currentExample = string.Empty;
        private Dictionary<string, UserControl> exampleControls;

        public rdfrmCryptography()
        {
            InitializeComponent();

            new TelerikMetroBlueTheme();
            ThemeResolutionService.LoadPackageResource("ITRI615_CryptographyProject.PanoramaDemo.tssp");
            this.ThemeName = "PanoramaDemo";

            this.radPanorama1.ThemeName = "PanoramaDemo";
            this.radPanorama1.ScrollingBackground = true;
            this.radPanorama1.PanelImage = Resources.bg_pattern;
            this.radPanorama1.PanoramaElement.BackgroundImagePrimitive.ImageLayout = ImageLayout.Tile;
            this.radPanorama1.SizeChanged += new EventHandler(radTilePanel1_SizeChanged);
            this.radPanorama1.ScrollBarAlignment = HorizontalScrollAlignment.Bottom;
            this.radPanorama1.ScrollBarThickness = 5;
            this.radPanorama1.PanoramaElement.GradientStyle = GradientStyles.Solid;
            this.radPanorama1.PanoramaElement.DrawFill = true;
            this.radPanorama1.PanoramaElement.BackColor = System.Drawing.Color.FromArgb(1, 23, 117);
            this.FormElement.TitleBar.MaxSize = new Size(0, 1);
            this.Text = "Cryptography System";

            this.PrepareHeader();
            this.PrepareTitleBar();
            this.PrepareExamples();
        }

        private void applicationsGroup_Click(object sender, EventArgs e)
        {

        }

        protected override void OnShown(EventArgs e)
        {
            this.radTilePanel1_SizeChanged(this, EventArgs.Empty);
            foreach (KeyValuePair<string, UserControl> entry in this.exampleControls)
            {
                entry.Value.PerformLayout();
                this.Controls.Remove(entry.Value);
            }

            base.OnShown(e);
        }




        private void PrepareExamples()
        {
            examplePage = new LightVisualElement();
            examplePage.DrawText = false;
            examplePage.DrawFill = true;
            examplePage.BackColor = Color.White;
            examplePage.GradientStyle = GradientStyles.Solid;
            examplePage.Visibility = ElementVisibility.Collapsed;
            this.radPanorama1.PanoramaElement.Children.Add(examplePage);
            examplePage.Margin = new Padding(0, 140, 0, 0);

            this.exampleControls = new Dictionary<string, UserControl>();
            this.exampleControls.Add("VernamView", new ITRI615_CryptographyProject.Vernam.VernamForm());
            this.exampleControls.Add("VignereView", new ITRI615_CryptographyProject.Vigenere.Vigenere());
            this.exampleControls.Add("TranspositionView", new ITRI615_CryptographyProject.Transposition.Transposition());
            this.exampleControls.Add("CustomAlgoView", new ITRI615_CryptographyProject.Custom.CustomAlgorithm());
            this.PreloadControls();
        }

        private void PreloadControls()
        {
            foreach (KeyValuePair<string, UserControl> entry in this.exampleControls)
            {
                this.Controls.Add(entry.Value);
                entry.Value.Location = new Point(120, 180);
            }
        }

        private void PrepareTitleBar()
        {
            titleBar = new RadTitleBarElement();

            titleBar.FillPrimitive.Visibility = ElementVisibility.Hidden;
            titleBar.MaxSize = new Size(0, 50);
            titleBar.Children[1].Visibility = ElementVisibility.Hidden;

            titleBar.CloseButton.Parent.PositionOffset = new SizeF(0, -10);
            titleBar.CloseButton.MinSize = new Size(50, 50);
            titleBar.CloseButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.MinimizeButton.MinSize = new Size(50, 50);
            titleBar.MinimizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.MaximizeButton.MinSize = new Size(50, 50);
            titleBar.MaximizeButton.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            titleBar.CloseButton.SetValue(RadFormElement.IsFormActiveProperty, true);
            titleBar.MinimizeButton.SetValue(RadFormElement.IsFormActiveProperty, true);
            titleBar.MaximizeButton.SetValue(RadFormElement.IsFormActiveProperty, true);

            titleBar.Close += new TitleBarSystemEventHandler(titleBar_Close);
            titleBar.Minimize += new TitleBarSystemEventHandler(titleBar_Minimize);
            titleBar.MaximizeRestore += new TitleBarSystemEventHandler(titleBar_MaximizeRestore);
            this.radPanorama1.PanoramaElement.PanGesture += new PanGestureEventHandler(radTilePanel1_PanGesture);
            this.radPanorama1.PanoramaElement.Children.Add(titleBar);
        }


        private void PrepareHeader()
        {
            StackLayoutElement headerLayout = new StackLayoutElement();
            headerLayout.Orientation = Orientation.Horizontal;
            headerLayout.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            headerLayout.NotifyParentOnMouseInput = true;
            headerLayout.ShouldHandleMouseInput = false;
            headerLayout.StretchHorizontally = false;

            this.backButton = new RadButtonElement() { StretchHorizontally = false };
            this.backButton.Margin = new Padding(40, 0, 28, 0);
            this.backButton.Click += new EventHandler(backButton_Click);
            this.backButton.Visibility = ElementVisibility.Hidden;
            headerLayout.Children.Add(this.backButton);

            this.headerLabel = new LightVisualElement();
            this.headerLabel.Text = "Cryptography System";
            this.headerLabel.Font = new Font("Segoe UI Light", 42, GraphicsUnit.Point);
            this.headerLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.headerLabel.ForeColor = Color.White;
            this.headerLabel.TextAlignment = ContentAlignment.MiddleLeft;
            this.headerLabel.MaxSize = new Size(630, 110);
            this.headerLabel.NotifyParentOnMouseInput = true;
            this.headerLabel.ShouldHandleMouseInput = false;
            this.headerLabel.StretchHorizontally = false;
            headerLayout.Children.Add(this.headerLabel);

            this.radPanorama1.PanoramaElement.Children.Add(headerLayout);
        }

        void backButton_Click(object sender, EventArgs e)
        {
            UnloadExample();
        }

        void titleBar_MaximizeRestore(object sender, EventArgs args)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        void titleBar_Minimize(object sender, EventArgs args)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void titleBar_Close(object sender, EventArgs args)
        {
            Application.Exit();
        }


        void radTilePanel1_PanGesture(object sender, PanGestureEventArgs e)
        {
            if (e.IsBegin && this.titleBar.ControlBoundingRectangle.Contains(e.Location))
            {
                isFormMoving = true;
            }

            if (isFormMoving)
            {
                this.Location = new Point(this.Location.X + e.Offset.Width, this.Location.Y + e.Offset.Height);
            }
            else
            {
                e.Handled = false;
            }

            if (e.IsEnd)
            {
                isFormMoving = false;
            }
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                { Arguments = folderPath, FileName = "explorer.exe" };
                Process.Start(startInfo);
            }
        }



        void radTilePanel1_SizeChanged(object sender, EventArgs e)
        {
            int width = this.radPanorama1.Width + Math.Max((this.radPanorama1.PanoramaElement.ScrollBar.Maximum - this.radPanorama1.Width) / 4, 1);
            this.radPanorama1.PanelImageSize = new Size(width, 768);
            this.radPanorama1.PanoramaElement.UpdateViewOnScroll();

            UpdateExampleControlPosition();
        }

        private void LoadExample(string exampleName, RadTileElement tile)
        {
            if (currentExample != string.Empty)
            {
                return;
            }

            this.currentExample = exampleName;

            this.headerLabel.Text = tile.Text;
            this.backButton.Visibility = ElementVisibility.Visible;

            this.examplePage.PositionOffset = new SizeF(-this.radPanorama1.Width, 0);
            examplePage.Visibility = ElementVisibility.Visible;
            AnimatedPropertySetting setting =
            new AnimatedPropertySetting(RadElement.PositionOffsetProperty,
                                        new SizeF(-this.radPanorama1.Width, 0),
                                        SizeF.Empty, (int)(10d * 800d / this.Width), 10);

            setting.AnimationFinished += new AnimationFinishedEventHandler(OnExampleOpened);
            setting.ApplyValue(this.examplePage);
        }


        private void UnloadExample()
        {
            this.Controls.Remove(this.GetCurrentExampleControl());

            this.backButton.Visibility = ElementVisibility.Hidden;
            this.headerLabel.Text = "Cryptography System";

            this.examplePage.PositionOffset = new SizeF(-this.radPanorama1.Width, 0);
            examplePage.Visibility = ElementVisibility.Visible;
            AnimatedPropertySetting setting =
            new AnimatedPropertySetting(RadElement.PositionOffsetProperty,
                                        SizeF.Empty,
                                        new SizeF(-this.radPanorama1.Width, 0),
                                        (int)(10d * 800d / this.Width), 10);

            setting.AnimationFinished += new AnimationFinishedEventHandler(OnExampleClosed);
            setting.ApplyValue(this.examplePage);
        }

        private void OnExampleOpened(object sender, AnimationStatusEventArgs e)
        {
            UserControl ctrl = this.GetCurrentExampleControl();
            if (ctrl != null)
            {
                this.Controls.Add(ctrl);
                ctrl.BringToFront();
                this.UpdateExampleControlPosition();
            }
        }

        private void OnExampleClosed(object sender, AnimationStatusEventArgs e)
        {
            ((AnimatedPropertySetting)sender).AnimationFinished -= OnExampleClosed;
            this.examplePage.Visibility = ElementVisibility.Collapsed;
            this.currentExample = string.Empty;
        }

        private void UpdateExampleControlPosition()
        {
            UserControl ctrl = this.GetCurrentExampleControl();
            if (ctrl != null)
            {
                ctrl.Bounds = new Rectangle(
                    new Point(120, this.examplePage.ControlBoundingRectangle.Y + 60),
                    new Size(this.Width - 180, this.Height - this.examplePage.ControlBoundingRectangle.Y - 120));
            }
        }

        private UserControl GetCurrentExampleControl()
        {
            if (this.currentExample != "" && this.exampleControls.ContainsKey(this.currentExample))
            {
                return this.exampleControls[this.currentExample];
            }

            return null;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SIZE && titleBar != null)
            {
                titleBar.CloseButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
                titleBar.MinimizeButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
                titleBar.MaximizeButton.SetValue(RadFormElement.FormWindowStateProperty, this.WindowState);
            }

            base.WndProc(ref m);
        }

        protected override FormControlBehavior InitializeFormBehavior()
        {
            return new MyFormBehavior(this, true);
        }

        private void radPanorama1_Click(object sender, EventArgs e)
        {



        }

 
        private void vignereTile_Click(object sender, EventArgs e)
        {
            LoadExample("VignereView", (RadTileElement)sender);
        }

        private void vernamTile_Click(object sender, EventArgs e)
        {
            LoadExample("VernamView", (RadTileElement)sender);
        }

        private void transpositionTile_Click(object sender, EventArgs e)
        {
            LoadExample("TranspositionView", (RadTileElement)sender);
        }

        private void customAlgorithmTile_Click(object sender, EventArgs e)
        {
            LoadExample("CustomAlgoView", (RadTileElement)sender);
        }

        private void fileExplorerTile_Click(object sender, EventArgs e)
        {
            string directoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            OpenFolder(directoryPath);
        }

        private void linkGroup_Click(object sender, EventArgs e)
        {
            RadTileElement senderTile = sender as RadTileElement;
            if (senderTile != null)
            {
                string link = (string)senderTile.Tag;
                System.Diagnostics.Process.Start(new ProcessStartInfo(link));
            }
        }

        private void githubTile_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Stoofie2/ITRI615Project");
        }

        private void RadForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RadForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    public class MyFormBehavior : RadFormBehavior
    {
        public MyFormBehavior(IComponentTreeHandler treeHandler, bool shouldCreateChildren) :
            base(treeHandler, shouldCreateChildren)
        {
        }

        public override Padding BorderWidth
        {
            get
            {
                return new Padding(1);
            }
        }
    }
}
