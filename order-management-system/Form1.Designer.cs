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
            this.tabcontMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblDeveloper = new MaterialSkin.Controls.MaterialLabel();
            this.btnHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnQueue = new MaterialSkin.Controls.MaterialButton();
            this.btnTheme = new MaterialSkin.Controls.MaterialButton();
            this.btnMenu = new MaterialSkin.Controls.MaterialButton();
            this.lblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.imglstTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkbBurger = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.chkbChicken = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.chkbPizza = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.chkbFries = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.chkbCoffee = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.chckCoke = new MaterialSkin.Controls.MaterialCheckbox();
            this.ptbBurgerHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tbCustomersName = new MaterialSkin.Controls.MaterialTextBox();
            this.lstbOrders = new MaterialSkin.Controls.MaterialListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnSendOrder = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabcontMenu.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontMenu
            // 
            this.tabcontMenu.Controls.Add(this.tabHome);
            this.tabcontMenu.Controls.Add(this.tabMenu);
            this.tabcontMenu.Controls.Add(this.tabQueue);
            this.tabcontMenu.Controls.Add(this.tabHistory);
            this.tabcontMenu.Depth = 0;
            this.tabcontMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontMenu.ImageList = this.imglstTabIcons;
            this.tabcontMenu.Location = new System.Drawing.Point(3, 64);
            this.tabcontMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontMenu.Multiline = true;
            this.tabcontMenu.Name = "tabcontMenu";
            this.tabcontMenu.SelectedIndex = 0;
            this.tabcontMenu.Size = new System.Drawing.Size(1194, 633);
            this.tabcontMenu.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.lblDeveloper);
            this.tabHome.Controls.Add(this.ptbBurgerHome);
            this.tabHome.Controls.Add(this.btnHistory);
            this.tabHome.Controls.Add(this.btnQueue);
            this.tabHome.Controls.Add(this.btnTheme);
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
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Depth = 0;
            this.lblDeveloper.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeveloper.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblDeveloper.Location = new System.Drawing.Point(46, 568);
            this.lblDeveloper.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(434, 19);
            this.lblDeveloper.TabIndex = 3;
            this.lblDeveloper.Text = "Developed by leighTOR. 2022. For educational purposes only.";
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
            // btnTheme
            // 
            this.btnTheme.AutoSize = false;
            this.btnTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTheme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTheme.Depth = 0;
            this.btnTheme.HighEmphasis = true;
            this.btnTheme.Icon = null;
            this.btnTheme.Location = new System.Drawing.Point(50, 9);
            this.btnTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTheme.Size = new System.Drawing.Size(116, 36);
            this.btnTheme.TabIndex = 1;
            this.btnTheme.Text = "LIGHT MODE";
            this.btnTheme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTheme.UseAccentColor = false;
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
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
            this.tabMenu.Controls.Add(this.materialButton1);
            this.tabMenu.Controls.Add(this.btnAdd);
            this.tabMenu.Controls.Add(this.btnRemove);
            this.tabMenu.Controls.Add(this.panel7);
            this.tabMenu.Controls.Add(this.lstbOrders);
            this.tabMenu.Controls.Add(this.tbCustomersName);
            this.tabMenu.Controls.Add(this.flowLayoutPanel1);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(671, 584);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chkbBurger);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 201);
            this.panel1.TabIndex = 1;
            // 
            // chkbBurger
            // 
            this.chkbBurger.AutoSize = true;
            this.chkbBurger.Depth = 0;
            this.chkbBurger.Location = new System.Drawing.Point(4, 159);
            this.chkbBurger.Margin = new System.Windows.Forms.Padding(0);
            this.chkbBurger.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbBurger.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbBurger.Name = "chkbBurger";
            this.chkbBurger.ReadOnly = false;
            this.chkbBurger.Ripple = true;
            this.chkbBurger.Size = new System.Drawing.Size(108, 37);
            this.chkbBurger.TabIndex = 0;
            this.chkbBurger.Text = "Big Burger";
            this.chkbBurger.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(240, 162);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "P50.00";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.chkbChicken);
            this.panel2.Location = new System.Drawing.Point(329, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 201);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(241, 162);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "P80.00";
            // 
            // chkbChicken
            // 
            this.chkbChicken.AutoSize = true;
            this.chkbChicken.Depth = 0;
            this.chkbChicken.Location = new System.Drawing.Point(4, 159);
            this.chkbChicken.Margin = new System.Windows.Forms.Padding(0);
            this.chkbChicken.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbChicken.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbChicken.Name = "chkbChicken";
            this.chkbChicken.ReadOnly = false;
            this.chkbChicken.Ripple = true;
            this.chkbChicken.Size = new System.Drawing.Size(127, 37);
            this.chkbChicken.TabIndex = 0;
            this.chkbChicken.Text = "Cool Chicken";
            this.chkbChicken.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.chkbPizza);
            this.panel3.Location = new System.Drawing.Point(3, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 201);
            this.panel3.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(229, 162);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "P100.00";
            // 
            // chkbPizza
            // 
            this.chkbPizza.AutoSize = true;
            this.chkbPizza.Depth = 0;
            this.chkbPizza.Location = new System.Drawing.Point(4, 159);
            this.chkbPizza.Margin = new System.Windows.Forms.Padding(0);
            this.chkbPizza.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbPizza.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbPizza.Name = "chkbPizza";
            this.chkbPizza.ReadOnly = false;
            this.chkbPizza.Ripple = true;
            this.chkbPizza.Size = new System.Drawing.Size(119, 37);
            this.chkbPizza.TabIndex = 0;
            this.chkbPizza.Text = "Pretty Pizza";
            this.chkbPizza.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.materialLabel4);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.chkbFries);
            this.panel4.Location = new System.Drawing.Point(329, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 201);
            this.panel4.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(241, 162);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 24);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "P90.00";
            // 
            // chkbFries
            // 
            this.chkbFries.AutoSize = true;
            this.chkbFries.Depth = 0;
            this.chkbFries.Location = new System.Drawing.Point(4, 159);
            this.chkbFries.Margin = new System.Windows.Forms.Padding(0);
            this.chkbFries.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbFries.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbFries.Name = "chkbFries";
            this.chkbFries.ReadOnly = false;
            this.chkbFries.Ripple = true;
            this.chkbFries.Size = new System.Drawing.Size(116, 37);
            this.chkbFries.TabIndex = 0;
            this.chkbFries.Text = "Fancy Fries";
            this.chkbFries.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.materialLabel5);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.chkbCoffee);
            this.panel5.Location = new System.Drawing.Point(3, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 201);
            this.panel5.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(240, 162);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 24);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "P60.00";
            // 
            // chkbCoffee
            // 
            this.chkbCoffee.AutoSize = true;
            this.chkbCoffee.Depth = 0;
            this.chkbCoffee.Location = new System.Drawing.Point(4, 159);
            this.chkbCoffee.Margin = new System.Windows.Forms.Padding(0);
            this.chkbCoffee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbCoffee.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbCoffee.Name = "chkbCoffee";
            this.chkbCoffee.ReadOnly = false;
            this.chkbCoffee.Ripple = true;
            this.chkbCoffee.Size = new System.Drawing.Size(145, 37);
            this.chkbCoffee.TabIndex = 0;
            this.chkbCoffee.Text = "Calming Coffee";
            this.chkbCoffee.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.materialLabel6);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.chckCoke);
            this.panel6.Location = new System.Drawing.Point(329, 417);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 201);
            this.panel6.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(240, 162);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 24);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "P30.00";
            // 
            // chckCoke
            // 
            this.chckCoke.AutoSize = true;
            this.chckCoke.Depth = 0;
            this.chckCoke.Location = new System.Drawing.Point(4, 159);
            this.chckCoke.Margin = new System.Windows.Forms.Padding(0);
            this.chckCoke.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckCoke.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckCoke.Name = "chckCoke";
            this.chckCoke.ReadOnly = false;
            this.chckCoke.Ripple = true;
            this.chckCoke.Size = new System.Drawing.Size(106, 37);
            this.chckCoke.TabIndex = 0;
            this.chckCoke.Text = "Cold Coke";
            this.chckCoke.UseVisualStyleBackColor = true;
            // 
            // ptbBurgerHome
            // 
            this.ptbBurgerHome.Image = global::order_management_system.Properties.Resources.burgerhome;
            this.ptbBurgerHome.Location = new System.Drawing.Point(682, 21);
            this.ptbBurgerHome.Name = "ptbBurgerHome";
            this.ptbBurgerHome.Size = new System.Drawing.Size(555, 591);
            this.ptbBurgerHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBurgerHome.TabIndex = 2;
            this.ptbBurgerHome.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::order_management_system.Properties.Resources.burger;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::order_management_system.Properties.Resources.chicken;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::order_management_system.Properties.Resources.pizza;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::order_management_system.Properties.Resources.fries;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(320, 156);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::order_management_system.Properties.Resources.coffee;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(320, 156);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::order_management_system.Properties.Resources.coke;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(320, 156);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // tbCustomersName
            // 
            this.tbCustomersName.AnimateReadOnly = false;
            this.tbCustomersName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomersName.Depth = 0;
            this.tbCustomersName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCustomersName.Hint = "Customer\'s name";
            this.tbCustomersName.LeadingIcon = null;
            this.tbCustomersName.Location = new System.Drawing.Point(707, 32);
            this.tbCustomersName.MaxLength = 50;
            this.tbCustomersName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCustomersName.Multiline = false;
            this.tbCustomersName.Name = "tbCustomersName";
            this.tbCustomersName.Size = new System.Drawing.Size(394, 50);
            this.tbCustomersName.TabIndex = 1;
            this.tbCustomersName.Text = "";
            this.tbCustomersName.TrailingIcon = null;
            // 
            // lstbOrders
            // 
            this.lstbOrders.BackColor = System.Drawing.Color.White;
            this.lstbOrders.BorderColor = System.Drawing.Color.LightGray;
            this.lstbOrders.Depth = 0;
            this.lstbOrders.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstbOrders.Location = new System.Drawing.Point(707, 102);
            this.lstbOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstbOrders.Name = "lstbOrders";
            this.lstbOrders.SelectedIndex = -1;
            this.lstbOrders.SelectedItem = null;
            this.lstbOrders.Size = new System.Drawing.Size(394, 271);
            this.lstbOrders.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.materialLabel9);
            this.panel7.Controls.Add(this.materialLabel8);
            this.panel7.Controls.Add(this.materialLabel7);
            this.panel7.Controls.Add(this.btnSendOrder);
            this.panel7.Location = new System.Drawing.Point(707, 439);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(394, 145);
            this.panel7.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = false;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemove.Depth = 0;
            this.btnRemove.HighEmphasis = true;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(845, 382);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(130, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemove.UseAccentColor = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(707, 383);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(130, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.AutoSize = false;
            this.btnSendOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSendOrder.Depth = 0;
            this.btnSendOrder.HighEmphasis = true;
            this.btnSendOrder.Icon = null;
            this.btnSendOrder.Location = new System.Drawing.Point(216, 64);
            this.btnSendOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSendOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSendOrder.Size = new System.Drawing.Size(161, 61);
            this.btnSendOrder.TabIndex = 4;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSendOrder.UseAccentColor = false;
            this.btnSendOrder.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(14, 13);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(258, 29);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "Customer\'s name: Leigh";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.ForeColor = System.Drawing.Color.OrangeRed;
            this.materialLabel8.Location = new System.Drawing.Point(15, 64);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(114, 24);
            this.materialLabel8.TabIndex = 5;
            this.materialLabel8.Text = "Total Item: 4";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.ForeColor = System.Drawing.Color.OrangeRed;
            this.materialLabel9.Location = new System.Drawing.Point(15, 98);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(182, 24);
            this.materialLabel9.TabIndex = 5;
            this.materialLabel9.Text = "Total Price: P180.00";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(983, 382);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(118, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Clear";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabcontMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabcontMenu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leigheat Restaurant";
            this.tabcontMenu.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabcontMenu;
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
        private MaterialSkin.Controls.MaterialLabel lblDeveloper;
        private MaterialSkin.Controls.MaterialButton btnTheme;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckbox chkbBurger;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckbox chkbChicken;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialCheckbox chkbPizza;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialCheckbox chkbFries;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialCheckbox chkbCoffee;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialCheckbox chckCoke;
        private MaterialSkin.Controls.MaterialTextBox tbCustomersName;
        private MaterialSkin.Controls.MaterialListBox lstbOrders;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialButton btnSendOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

