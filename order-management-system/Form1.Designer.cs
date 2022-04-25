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
            this.ptbBurgerHome = new System.Windows.Forms.PictureBox();
            this.btnHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnQueue = new MaterialSkin.Controls.MaterialButton();
            this.btnTheme = new MaterialSkin.Controls.MaterialButton();
            this.btnMenu = new MaterialSkin.Controls.MaterialButton();
            this.lblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.lstbOrders = new System.Windows.Forms.ListBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalItem = new MaterialSkin.Controls.MaterialLabel();
            this.lblCustomersName = new MaterialSkin.Controls.MaterialLabel();
            this.btnSendOrder = new MaterialSkin.Controls.MaterialButton();
            this.tbCustomersName = new MaterialSkin.Controls.MaterialTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBurgerPrice = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkbBurger = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblChickenPrice = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkbChicken = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPizzaPrice = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkbPizza = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFriesPrice = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkbFries = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCoffee = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.chkbCoffee = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCokePrice = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.chkbCoke = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.imglstTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabcontMenu.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.tabMenu.Controls.Add(this.lstbOrders);
            this.tabMenu.Controls.Add(this.btnClear);
            this.tabMenu.Controls.Add(this.btnAdd);
            this.tabMenu.Controls.Add(this.btnRemove);
            this.tabMenu.Controls.Add(this.panel7);
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
            // lstbOrders
            // 
            this.lstbOrders.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbOrders.FormattingEnabled = true;
            this.lstbOrders.ItemHeight = 33;
            this.lstbOrders.Location = new System.Drawing.Point(707, 104);
            this.lstbOrders.Name = "lstbOrders";
            this.lstbOrders.Size = new System.Drawing.Size(394, 235);
            this.lstbOrders.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = false;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(983, 382);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(118, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblTotalPrice);
            this.panel7.Controls.Add(this.lblTotalItem);
            this.panel7.Controls.Add(this.lblCustomersName);
            this.panel7.Controls.Add(this.btnSendOrder);
            this.panel7.Location = new System.Drawing.Point(707, 439);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(394, 145);
            this.panel7.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Depth = 0;
            this.lblTotalPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalPrice.Location = new System.Drawing.Point(15, 98);
            this.lblTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(108, 24);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Total Price: ";
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.Depth = 0;
            this.lblTotalItem.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalItem.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTotalItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalItem.Location = new System.Drawing.Point(15, 64);
            this.lblTotalItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(103, 24);
            this.lblTotalItem.TabIndex = 5;
            this.lblTotalItem.Text = "Total Item: ";
            // 
            // lblCustomersName
            // 
            this.lblCustomersName.AutoSize = true;
            this.lblCustomersName.Depth = 0;
            this.lblCustomersName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomersName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblCustomersName.Location = new System.Drawing.Point(14, 13);
            this.lblCustomersName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCustomersName.Name = "lblCustomersName";
            this.lblCustomersName.Size = new System.Drawing.Size(200, 29);
            this.lblCustomersName.TabIndex = 5;
            this.lblCustomersName.Text = "Customer\'s name: ";
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
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
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
            this.panel1.Controls.Add(this.lblBurgerPrice);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chkbBurger);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 201);
            this.panel1.TabIndex = 1;
            // 
            // lblBurgerPrice
            // 
            this.lblBurgerPrice.AutoSize = true;
            this.lblBurgerPrice.Depth = 0;
            this.lblBurgerPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBurgerPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblBurgerPrice.Location = new System.Drawing.Point(240, 162);
            this.lblBurgerPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBurgerPrice.Name = "lblBurgerPrice";
            this.lblBurgerPrice.Size = new System.Drawing.Size(64, 24);
            this.lblBurgerPrice.TabIndex = 2;
            this.lblBurgerPrice.Text = "P50.00";
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblChickenPrice);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.chkbChicken);
            this.panel2.Location = new System.Drawing.Point(329, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 201);
            this.panel2.TabIndex = 1;
            // 
            // lblChickenPrice
            // 
            this.lblChickenPrice.AutoSize = true;
            this.lblChickenPrice.Depth = 0;
            this.lblChickenPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblChickenPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblChickenPrice.Location = new System.Drawing.Point(241, 162);
            this.lblChickenPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChickenPrice.Name = "lblChickenPrice";
            this.lblChickenPrice.Size = new System.Drawing.Size(64, 24);
            this.lblChickenPrice.TabIndex = 2;
            this.lblChickenPrice.Text = "P80.00";
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
            this.panel3.Controls.Add(this.lblPizzaPrice);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.chkbPizza);
            this.panel3.Location = new System.Drawing.Point(3, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 201);
            this.panel3.TabIndex = 1;
            // 
            // lblPizzaPrice
            // 
            this.lblPizzaPrice.AutoSize = true;
            this.lblPizzaPrice.Depth = 0;
            this.lblPizzaPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPizzaPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblPizzaPrice.Location = new System.Drawing.Point(229, 162);
            this.lblPizzaPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPizzaPrice.Name = "lblPizzaPrice";
            this.lblPizzaPrice.Size = new System.Drawing.Size(75, 24);
            this.lblPizzaPrice.TabIndex = 2;
            this.lblPizzaPrice.Text = "P100.00";
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
            this.panel4.Controls.Add(this.lblFriesPrice);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.chkbFries);
            this.panel4.Location = new System.Drawing.Point(329, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 201);
            this.panel4.TabIndex = 1;
            // 
            // lblFriesPrice
            // 
            this.lblFriesPrice.AutoSize = true;
            this.lblFriesPrice.Depth = 0;
            this.lblFriesPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFriesPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblFriesPrice.Location = new System.Drawing.Point(241, 162);
            this.lblFriesPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFriesPrice.Name = "lblFriesPrice";
            this.lblFriesPrice.Size = new System.Drawing.Size(64, 24);
            this.lblFriesPrice.TabIndex = 2;
            this.lblFriesPrice.Text = "P90.00";
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
            this.panel5.Controls.Add(this.lblCoffee);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.chkbCoffee);
            this.panel5.Location = new System.Drawing.Point(3, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 201);
            this.panel5.TabIndex = 1;
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Depth = 0;
            this.lblCoffee.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCoffee.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCoffee.Location = new System.Drawing.Point(240, 162);
            this.lblCoffee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(64, 24);
            this.lblCoffee.TabIndex = 2;
            this.lblCoffee.Text = "P60.00";
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
            this.panel6.Controls.Add(this.lblCokePrice);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.chkbCoke);
            this.panel6.Location = new System.Drawing.Point(329, 417);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(320, 201);
            this.panel6.TabIndex = 1;
            // 
            // lblCokePrice
            // 
            this.lblCokePrice.AutoSize = true;
            this.lblCokePrice.Depth = 0;
            this.lblCokePrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCokePrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCokePrice.Location = new System.Drawing.Point(240, 162);
            this.lblCokePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCokePrice.Name = "lblCokePrice";
            this.lblCokePrice.Size = new System.Drawing.Size(64, 24);
            this.lblCokePrice.TabIndex = 2;
            this.lblCokePrice.Text = "P30.00";
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
            // chkbCoke
            // 
            this.chkbCoke.AutoSize = true;
            this.chkbCoke.Depth = 0;
            this.chkbCoke.Location = new System.Drawing.Point(4, 159);
            this.chkbCoke.Margin = new System.Windows.Forms.Padding(0);
            this.chkbCoke.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkbCoke.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkbCoke.Name = "chkbCoke";
            this.chkbCoke.ReadOnly = false;
            this.chkbCoke.Ripple = true;
            this.chkbCoke.Size = new System.Drawing.Size(106, 37);
            this.chkbCoke.TabIndex = 0;
            this.chkbCoke.Text = "Cold Coke";
            this.chkbCoke.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel lblBurgerPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckbox chkbBurger;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblChickenPrice;
        private MaterialSkin.Controls.MaterialCheckbox chkbChicken;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel lblPizzaPrice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialCheckbox chkbPizza;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel lblFriesPrice;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialCheckbox chkbFries;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialLabel lblCoffee;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialCheckbox chkbCoffee;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel lblCokePrice;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialCheckbox chkbCoke;
        private MaterialSkin.Controls.MaterialTextBox tbCustomersName;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialButton btnSendOrder;
        private MaterialSkin.Controls.MaterialLabel lblTotalPrice;
        private MaterialSkin.Controls.MaterialLabel lblTotalItem;
        private MaterialSkin.Controls.MaterialLabel lblCustomersName;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private System.Windows.Forms.ListBox lstbOrders;
    }
}

