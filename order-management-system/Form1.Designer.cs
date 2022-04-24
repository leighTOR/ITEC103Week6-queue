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
            this.home = new System.Windows.Forms.TabPage();
            this.lblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.menu = new System.Windows.Forms.TabPage();
            this.queue = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMenu = new MaterialSkin.Controls.MaterialButton();
            this.btnQueue = new MaterialSkin.Controls.MaterialButton();
            this.btnHistory = new MaterialSkin.Controls.MaterialButton();
            this.ptbBurgerHome = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.home);
            this.materialTabControl1.Controls.Add(this.menu);
            this.materialTabControl1.Controls.Add(this.queue);
            this.materialTabControl1.Controls.Add(this.history);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1194, 633);
            this.materialTabControl1.TabIndex = 0;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.White;
            this.home.Controls.Add(this.materialLabel1);
            this.home.Controls.Add(this.ptbBurgerHome);
            this.home.Controls.Add(this.btnHistory);
            this.home.Controls.Add(this.btnQueue);
            this.home.Controls.Add(this.btnMenu);
            this.home.Controls.Add(this.lblHeader);
            this.home.ImageKey = "home.png";
            this.home.Location = new System.Drawing.Point(4, 39);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1186, 590);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
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
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageKey = "menu.png";
            this.menu.Location = new System.Drawing.Point(4, 39);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(3);
            this.menu.Size = new System.Drawing.Size(1186, 590);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // queue
            // 
            this.queue.BackColor = System.Drawing.Color.White;
            this.queue.ImageKey = "queue.png";
            this.queue.Location = new System.Drawing.Point(4, 39);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(1186, 590);
            this.queue.TabIndex = 2;
            this.queue.Text = "Queue";
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.ImageKey = "history.png";
            this.history.Location = new System.Drawing.Point(4, 39);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(1186, 590);
            this.history.TabIndex = 3;
            this.history.Text = "History";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "queue.png");
            this.imageList1.Images.SetKeyName(1, "menu.png");
            this.imageList1.Images.SetKeyName(2, "home.png");
            this.imageList1.Images.SetKeyName(3, "history.png");
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
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage menu;
        private System.Windows.Forms.TabPage queue;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel lblHeader;
        private MaterialSkin.Controls.MaterialButton btnMenu;
        private MaterialSkin.Controls.MaterialButton btnHistory;
        private MaterialSkin.Controls.MaterialButton btnQueue;
        private System.Windows.Forms.PictureBox ptbBurgerHome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

