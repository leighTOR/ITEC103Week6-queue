namespace order_management_system
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.imglstTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnMenu = new MaterialSkin.Controls.MaterialButton();
            this.btnQueue = new MaterialSkin.Controls.MaterialButton();
            this.btnHistory = new MaterialSkin.Controls.MaterialButton();
            this.ptbBurgerHome = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Controls.Add(this.tabMenu);
            this.materialTabControl1.Controls.Add(this.tabQueue);
            this.materialTabControl1.Controls.Add(this.tabHistory);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imglstTabIcons;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1194, 633);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.materialLabel1);
            this.tabHome.Controls.Add(this.ptbBurgerHome);
            this.tabHome.Controls.Add(this.btnHistory);
            this.tabHome.Controls.Add(this.btnQueue);
            this.tabHome.Controls.Add(this.btnMenu);
            this.tabHome.Controls.Add(this.lblHeader);
            this.tabHome.ImageKey = "home.png";
            this.tabHome.Location = new System.Drawing.Point(4, 39);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1186, 590);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // lblHeader
            // 
            this.lblHeader.Depth = 0;
            this.lblHeader.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHeader.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.lblHeader.Location = new System.Drawing.Point(49, 70);
            this.lblHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(597, 375);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Eat Well with Leigheat Restaurant.";
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.Color.White;
            this.tabMenu.ImageKey = "menu.png";
            this.tabMenu.Location = new System.Drawing.Point(4, 39);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(1186, 590);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.Text = "Menu";
            // 
            // tabQueue
            // 
            this.tabQueue.BackColor = System.Drawing.Color.White;
            this.tabQueue.ImageKey = "queue.png";
            this.tabQueue.Location = new System.Drawing.Point(4, 39);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Size = new System.Drawing.Size(1186, 590);
            this.tabQueue.TabIndex = 2;
            this.tabQueue.Text = "Queue";
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.White;
            this.tabHistory.ImageKey = "history.png";
            this.tabHistory.Location = new System.Drawing.Point(4, 39);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(1186, 590);
            this.tabHistory.TabIndex = 3;
            this.tabHistory.Text = "History";
            // 
            // imglstTabIcons
            // 
            this.imglstTabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTabIcons.ImageStream")));
            this.imglstTabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTabIcons.Images.SetKeyName(0, "queue.png");
            this.imglstTabIcons.Images.SetKeyName(1, "menu.png");
            this.imglstTabIcons.Images.SetKeyName(2, "home.png");
            this.imglstTabIcons.Images.SetKeyName(3, "history.png");
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = false;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMenu.Depth = 0;
            this.btnMenu.HighEmphasis = true;
            this.btnMenu.Icon = null;
            this.btnMenu.Location = new System.Drawing.Point(50, 451);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMenu.Size = new System.Drawing.Size(180, 36);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "ADD ORDER";
            this.btnMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMenu.UseAccentColor = false;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.AutoSize = false;
            this.btnQueue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQueue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQueue.Depth = 0;
            this.btnQueue.HighEmphasis = true;
            this.btnQueue.Icon = null;
            this.btnQueue.Location = new System.Drawing.Point(238, 451);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQueue.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQueue.Size = new System.Drawing.Size(180, 36);
            this.btnQueue.TabIndex = 1;
            this.btnQueue.Text = "VIEW ORDER  LIST";
            this.btnQueue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQueue.UseAccentColor = false;
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = false;
            this.btnHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHistory.Depth = 0;
            this.btnHistory.HighEmphasis = true;
            this.btnHistory.Icon = null;
            this.btnHistory.Location = new System.Drawing.Point(426, 451);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHistory.Size = new System.Drawing.Size(180, 36);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "VIEW ORDERS HISTORY";
            this.btnHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHistory.UseAccentColor = false;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // ptbBurgerHome
            // 
            this.ptbBurgerHome.Image = global::order_management_system.Properties.Resources.burgerhome;
            this.ptbBurgerHome.Location = new System.Drawing.Point(682, 0);
            this.ptbBurgerHome.Name = "ptbBurgerHome";
            this.ptbBurgerHome.Size = new System.Drawing.Size(555, 591);
            this.ptbBurgerHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBurgerHome.TabIndex = 2;
            this.ptbBurgerHome.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.Location = new System.Drawing.Point(46, 568);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(434, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Developed by leighTOR. 2022. For educational purposes only.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leigheat Restaurant";
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.ImageList imglstTabIcons;
        private MaterialSkin.Controls.MaterialLabel lblHeader;
        private MaterialSkin.Controls.MaterialButton btnMenu;
        private MaterialSkin.Controls.MaterialButton btnHistory;
        private MaterialSkin.Controls.MaterialButton btnQueue;
        private System.Windows.Forms.PictureBox ptbBurgerHome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

