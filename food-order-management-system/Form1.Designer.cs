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
            this.ptbThemeToggle = new System.Windows.Forms.PictureBox();
            this.lblDeveloper = new MaterialSkin.Controls.MaterialLabel();
            this.ptbBurgerHome = new System.Windows.Forms.PictureBox();
            this.btnHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnQueue = new MaterialSkin.Controls.MaterialButton();
            this.btnMenu = new MaterialSkin.Controls.MaterialButton();
            this.lblHeader = new MaterialSkin.Controls.MaterialLabel();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.lstbOrders = new System.Windows.Forms.ListBox();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.pnlOrderInfo = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalItem = new MaterialSkin.Controls.MaterialLabel();
            this.lblCustomersName = new MaterialSkin.Controls.MaterialLabel();
            this.btnSendOrder = new MaterialSkin.Controls.MaterialButton();
            this.tbCustomersName = new MaterialSkin.Controls.MaterialTextBox();
            this.flpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBurger = new System.Windows.Forms.Panel();
            this.lblBurgerPrice = new MaterialSkin.Controls.MaterialLabel();
            this.ptbBurger = new System.Windows.Forms.PictureBox();
            this.chkbBurger = new MaterialSkin.Controls.MaterialCheckbox();
            this.pnlChicken = new System.Windows.Forms.Panel();
            this.lblChickenPrice = new MaterialSkin.Controls.MaterialLabel();
            this.ptbChicken = new System.Windows.Forms.PictureBox();
            this.chkbChicken = new MaterialSkin.Controls.MaterialCheckbox();
            this.pnlPizza = new System.Windows.Forms.Panel();
            this.lblPizzaPrice = new MaterialSkin.Controls.MaterialLabel();
            this.ptbPizza = new System.Windows.Forms.PictureBox();
            this.chkbPizza = new MaterialSkin.Controls.MaterialCheckbox();
            this.pnlFries = new System.Windows.Forms.Panel();
            this.lblFriesPrice = new MaterialSkin.Controls.MaterialLabel();
            this.ptbFries = new System.Windows.Forms.PictureBox();
            this.chkbFries = new MaterialSkin.Controls.MaterialCheckbox();
            this.pnlCoffee = new System.Windows.Forms.Panel();
            this.lblCoffee = new MaterialSkin.Controls.MaterialLabel();
            this.ptbCoffee = new System.Windows.Forms.PictureBox();
            this.chkbCoffee = new MaterialSkin.Controls.MaterialCheckbox();
            this.pnlCoke = new System.Windows.Forms.Panel();
            this.lblCokePrice = new MaterialSkin.Controls.MaterialLabel();
            this.ptbCoke = new System.Windows.Forms.PictureBox();
            this.chkbCoke = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.btnClearAllOrders = new MaterialSkin.Controls.MaterialButton();
            this.btnCountAllOrders = new MaterialSkin.Controls.MaterialButton();
            this.btnShowFirstOrder = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveTopOrder = new MaterialSkin.Controls.MaterialButton();
            this.lblQueueTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblQueueTotalItem = new MaterialSkin.Controls.MaterialLabel();
            this.lblQueueName = new MaterialSkin.Controls.MaterialLabel();
            this.lblQueueDate = new MaterialSkin.Controls.MaterialLabel();
            this.lstbQueue = new System.Windows.Forms.ListBox();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnClearHistory = new MaterialSkin.Controls.MaterialButton();
            this.lstbHistory = new System.Windows.Forms.ListBox();
            this.imglstTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabcontMenu.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThemeToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.pnlOrderInfo.SuspendLayout();
            this.flpnlMenu.SuspendLayout();
            this.pnlBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurger)).BeginInit();
            this.pnlChicken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChicken)).BeginInit();
            this.pnlPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPizza)).BeginInit();
            this.pnlFries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFries)).BeginInit();
            this.pnlCoffee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoffee)).BeginInit();
            this.pnlCoke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoke)).BeginInit();
            this.tabQueue.SuspendLayout();
            this.tabHistory.SuspendLayout();
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
            this.tabHome.Controls.Add(this.ptbThemeToggle);
            this.tabHome.Controls.Add(this.lblDeveloper);
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
            // ptbThemeToggle
            // 
            this.ptbThemeToggle.Image = global::order_management_system.Properties.Resources.lighttoggle;
            this.ptbThemeToggle.Location = new System.Drawing.Point(50, 21);
            this.ptbThemeToggle.Name = "ptbThemeToggle";
            this.ptbThemeToggle.Size = new System.Drawing.Size(100, 50);
            this.ptbThemeToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThemeToggle.TabIndex = 4;
            this.ptbThemeToggle.TabStop = false;
            this.ptbThemeToggle.Click += new System.EventHandler(this.ptbThemeToggle_Click);
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
            this.tabMenu.Controls.Add(this.pnlOrderInfo);
            this.tabMenu.Controls.Add(this.tbCustomersName);
            this.tabMenu.Controls.Add(this.flpnlMenu);
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
            // pnlOrderInfo
            // 
            this.pnlOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderInfo.Controls.Add(this.lblTotalPrice);
            this.pnlOrderInfo.Controls.Add(this.lblTotalItem);
            this.pnlOrderInfo.Controls.Add(this.lblCustomersName);
            this.pnlOrderInfo.Controls.Add(this.btnSendOrder);
            this.pnlOrderInfo.Location = new System.Drawing.Point(707, 439);
            this.pnlOrderInfo.Name = "pnlOrderInfo";
            this.pnlOrderInfo.Size = new System.Drawing.Size(394, 145);
            this.pnlOrderInfo.TabIndex = 3;
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
            // flpnlMenu
            // 
            this.flpnlMenu.AutoScroll = true;
            this.flpnlMenu.Controls.Add(this.pnlBurger);
            this.flpnlMenu.Controls.Add(this.pnlChicken);
            this.flpnlMenu.Controls.Add(this.pnlPizza);
            this.flpnlMenu.Controls.Add(this.pnlFries);
            this.flpnlMenu.Controls.Add(this.pnlCoffee);
            this.flpnlMenu.Controls.Add(this.pnlCoke);
            this.flpnlMenu.Location = new System.Drawing.Point(3, 3);
            this.flpnlMenu.Name = "flpnlMenu";
            this.flpnlMenu.Size = new System.Drawing.Size(671, 584);
            this.flpnlMenu.TabIndex = 0;
            // 
            // pnlBurger
            // 
            this.pnlBurger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBurger.Controls.Add(this.lblBurgerPrice);
            this.pnlBurger.Controls.Add(this.ptbBurger);
            this.pnlBurger.Controls.Add(this.chkbBurger);
            this.pnlBurger.Location = new System.Drawing.Point(3, 3);
            this.pnlBurger.Name = "pnlBurger";
            this.pnlBurger.Size = new System.Drawing.Size(320, 201);
            this.pnlBurger.TabIndex = 1;
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
            // ptbBurger
            // 
            this.ptbBurger.Image = global::order_management_system.Properties.Resources.burger;
            this.ptbBurger.Location = new System.Drawing.Point(0, 0);
            this.ptbBurger.Name = "ptbBurger";
            this.ptbBurger.Size = new System.Drawing.Size(320, 156);
            this.ptbBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBurger.TabIndex = 1;
            this.ptbBurger.TabStop = false;
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
            // pnlChicken
            // 
            this.pnlChicken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChicken.Controls.Add(this.lblChickenPrice);
            this.pnlChicken.Controls.Add(this.ptbChicken);
            this.pnlChicken.Controls.Add(this.chkbChicken);
            this.pnlChicken.Location = new System.Drawing.Point(329, 3);
            this.pnlChicken.Name = "pnlChicken";
            this.pnlChicken.Size = new System.Drawing.Size(320, 201);
            this.pnlChicken.TabIndex = 1;
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
            // ptbChicken
            // 
            this.ptbChicken.Image = global::order_management_system.Properties.Resources.chicken;
            this.ptbChicken.Location = new System.Drawing.Point(0, 0);
            this.ptbChicken.Name = "ptbChicken";
            this.ptbChicken.Size = new System.Drawing.Size(320, 156);
            this.ptbChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbChicken.TabIndex = 1;
            this.ptbChicken.TabStop = false;
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
            // pnlPizza
            // 
            this.pnlPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPizza.Controls.Add(this.lblPizzaPrice);
            this.pnlPizza.Controls.Add(this.ptbPizza);
            this.pnlPizza.Controls.Add(this.chkbPizza);
            this.pnlPizza.Location = new System.Drawing.Point(3, 210);
            this.pnlPizza.Name = "pnlPizza";
            this.pnlPizza.Size = new System.Drawing.Size(320, 201);
            this.pnlPizza.TabIndex = 1;
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
            // ptbPizza
            // 
            this.ptbPizza.Image = global::order_management_system.Properties.Resources.pizza;
            this.ptbPizza.Location = new System.Drawing.Point(0, 0);
            this.ptbPizza.Name = "ptbPizza";
            this.ptbPizza.Size = new System.Drawing.Size(320, 156);
            this.ptbPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPizza.TabIndex = 1;
            this.ptbPizza.TabStop = false;
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
            // pnlFries
            // 
            this.pnlFries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFries.Controls.Add(this.lblFriesPrice);
            this.pnlFries.Controls.Add(this.ptbFries);
            this.pnlFries.Controls.Add(this.chkbFries);
            this.pnlFries.Location = new System.Drawing.Point(329, 210);
            this.pnlFries.Name = "pnlFries";
            this.pnlFries.Size = new System.Drawing.Size(320, 201);
            this.pnlFries.TabIndex = 1;
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
            // ptbFries
            // 
            this.ptbFries.Image = global::order_management_system.Properties.Resources.fries;
            this.ptbFries.Location = new System.Drawing.Point(0, 0);
            this.ptbFries.Name = "ptbFries";
            this.ptbFries.Size = new System.Drawing.Size(320, 156);
            this.ptbFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFries.TabIndex = 1;
            this.ptbFries.TabStop = false;
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
            // pnlCoffee
            // 
            this.pnlCoffee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCoffee.Controls.Add(this.lblCoffee);
            this.pnlCoffee.Controls.Add(this.ptbCoffee);
            this.pnlCoffee.Controls.Add(this.chkbCoffee);
            this.pnlCoffee.Location = new System.Drawing.Point(3, 417);
            this.pnlCoffee.Name = "pnlCoffee";
            this.pnlCoffee.Size = new System.Drawing.Size(320, 201);
            this.pnlCoffee.TabIndex = 1;
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
            // ptbCoffee
            // 
            this.ptbCoffee.Image = global::order_management_system.Properties.Resources.coffee;
            this.ptbCoffee.Location = new System.Drawing.Point(0, 0);
            this.ptbCoffee.Name = "ptbCoffee";
            this.ptbCoffee.Size = new System.Drawing.Size(320, 156);
            this.ptbCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCoffee.TabIndex = 1;
            this.ptbCoffee.TabStop = false;
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
            // pnlCoke
            // 
            this.pnlCoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCoke.Controls.Add(this.lblCokePrice);
            this.pnlCoke.Controls.Add(this.ptbCoke);
            this.pnlCoke.Controls.Add(this.chkbCoke);
            this.pnlCoke.Location = new System.Drawing.Point(329, 417);
            this.pnlCoke.Name = "pnlCoke";
            this.pnlCoke.Size = new System.Drawing.Size(320, 201);
            this.pnlCoke.TabIndex = 1;
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
            // ptbCoke
            // 
            this.ptbCoke.Image = global::order_management_system.Properties.Resources.coke;
            this.ptbCoke.Location = new System.Drawing.Point(0, 0);
            this.ptbCoke.Name = "ptbCoke";
            this.ptbCoke.Size = new System.Drawing.Size(320, 156);
            this.ptbCoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCoke.TabIndex = 1;
            this.ptbCoke.TabStop = false;
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
            this.tabQueue.Controls.Add(this.btnClearAllOrders);
            this.tabQueue.Controls.Add(this.btnCountAllOrders);
            this.tabQueue.Controls.Add(this.btnShowFirstOrder);
            this.tabQueue.Controls.Add(this.btnRemoveTopOrder);
            this.tabQueue.Controls.Add(this.lblQueueTotalPrice);
            this.tabQueue.Controls.Add(this.lblQueueTotalItem);
            this.tabQueue.Controls.Add(this.lblQueueName);
            this.tabQueue.Controls.Add(this.lblQueueDate);
            this.tabQueue.Controls.Add(this.lstbQueue);
            this.tabQueue.ImageKey = "queue.png";
            this.tabQueue.Location = new System.Drawing.Point(4, 39);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Size = new System.Drawing.Size(1186, 590);
            this.tabQueue.TabIndex = 2;
            this.tabQueue.Text = "Queue";
            // 
            // btnClearAllOrders
            // 
            this.btnClearAllOrders.AutoSize = false;
            this.btnClearAllOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearAllOrders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearAllOrders.Depth = 0;
            this.btnClearAllOrders.HighEmphasis = true;
            this.btnClearAllOrders.Icon = null;
            this.btnClearAllOrders.Location = new System.Drawing.Point(873, 203);
            this.btnClearAllOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearAllOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearAllOrders.Name = "btnClearAllOrders";
            this.btnClearAllOrders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearAllOrders.Size = new System.Drawing.Size(222, 36);
            this.btnClearAllOrders.TabIndex = 4;
            this.btnClearAllOrders.Text = "Clear All Orders";
            this.btnClearAllOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearAllOrders.UseAccentColor = false;
            this.btnClearAllOrders.UseVisualStyleBackColor = true;
            this.btnClearAllOrders.Click += new System.EventHandler(this.btnClearAllOrders_Click);
            // 
            // btnCountAllOrders
            // 
            this.btnCountAllOrders.AutoSize = false;
            this.btnCountAllOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCountAllOrders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCountAllOrders.Depth = 0;
            this.btnCountAllOrders.HighEmphasis = true;
            this.btnCountAllOrders.Icon = null;
            this.btnCountAllOrders.Location = new System.Drawing.Point(873, 155);
            this.btnCountAllOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCountAllOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCountAllOrders.Name = "btnCountAllOrders";
            this.btnCountAllOrders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCountAllOrders.Size = new System.Drawing.Size(222, 36);
            this.btnCountAllOrders.TabIndex = 4;
            this.btnCountAllOrders.Text = "Count All orders";
            this.btnCountAllOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCountAllOrders.UseAccentColor = false;
            this.btnCountAllOrders.UseVisualStyleBackColor = true;
            this.btnCountAllOrders.Click += new System.EventHandler(this.btnCountAllOrders_Click);
            // 
            // btnShowFirstOrder
            // 
            this.btnShowFirstOrder.AutoSize = false;
            this.btnShowFirstOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowFirstOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowFirstOrder.Depth = 0;
            this.btnShowFirstOrder.HighEmphasis = true;
            this.btnShowFirstOrder.Icon = null;
            this.btnShowFirstOrder.Location = new System.Drawing.Point(873, 107);
            this.btnShowFirstOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowFirstOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowFirstOrder.Name = "btnShowFirstOrder";
            this.btnShowFirstOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowFirstOrder.Size = new System.Drawing.Size(222, 36);
            this.btnShowFirstOrder.TabIndex = 4;
            this.btnShowFirstOrder.Text = "Show First Order";
            this.btnShowFirstOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowFirstOrder.UseAccentColor = false;
            this.btnShowFirstOrder.UseVisualStyleBackColor = true;
            this.btnShowFirstOrder.Click += new System.EventHandler(this.btnShowFirstOrder_Click);
            // 
            // btnRemoveTopOrder
            // 
            this.btnRemoveTopOrder.AutoSize = false;
            this.btnRemoveTopOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveTopOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveTopOrder.Depth = 0;
            this.btnRemoveTopOrder.HighEmphasis = true;
            this.btnRemoveTopOrder.Icon = null;
            this.btnRemoveTopOrder.Location = new System.Drawing.Point(873, 59);
            this.btnRemoveTopOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveTopOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveTopOrder.Name = "btnRemoveTopOrder";
            this.btnRemoveTopOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveTopOrder.Size = new System.Drawing.Size(222, 36);
            this.btnRemoveTopOrder.TabIndex = 4;
            this.btnRemoveTopOrder.Text = "Remove top order";
            this.btnRemoveTopOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveTopOrder.UseAccentColor = false;
            this.btnRemoveTopOrder.UseVisualStyleBackColor = true;
            this.btnRemoveTopOrder.Click += new System.EventHandler(this.btnRemoveTopOrder_Click);
            // 
            // lblQueueTotalPrice
            // 
            this.lblQueueTotalPrice.AutoSize = true;
            this.lblQueueTotalPrice.Depth = 0;
            this.lblQueueTotalPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQueueTotalPrice.Location = new System.Drawing.Point(697, 28);
            this.lblQueueTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQueueTotalPrice.Name = "lblQueueTotalPrice";
            this.lblQueueTotalPrice.Size = new System.Drawing.Size(77, 19);
            this.lblQueueTotalPrice.TabIndex = 3;
            this.lblQueueTotalPrice.Text = "Total Price";
            // 
            // lblQueueTotalItem
            // 
            this.lblQueueTotalItem.AutoSize = true;
            this.lblQueueTotalItem.Depth = 0;
            this.lblQueueTotalItem.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQueueTotalItem.Location = new System.Drawing.Point(571, 28);
            this.lblQueueTotalItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQueueTotalItem.Name = "lblQueueTotalItem";
            this.lblQueueTotalItem.Size = new System.Drawing.Size(73, 19);
            this.lblQueueTotalItem.TabIndex = 3;
            this.lblQueueTotalItem.Text = "Total Item";
            // 
            // lblQueueName
            // 
            this.lblQueueName.AutoSize = true;
            this.lblQueueName.Depth = 0;
            this.lblQueueName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQueueName.Location = new System.Drawing.Point(296, 28);
            this.lblQueueName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQueueName.Name = "lblQueueName";
            this.lblQueueName.Size = new System.Drawing.Size(43, 19);
            this.lblQueueName.TabIndex = 3;
            this.lblQueueName.Text = "Name";
            // 
            // lblQueueDate
            // 
            this.lblQueueDate.AutoSize = true;
            this.lblQueueDate.Depth = 0;
            this.lblQueueDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQueueDate.Location = new System.Drawing.Point(38, 28);
            this.lblQueueDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQueueDate.Name = "lblQueueDate";
            this.lblQueueDate.Size = new System.Drawing.Size(34, 19);
            this.lblQueueDate.TabIndex = 3;
            this.lblQueueDate.Text = "Date";
            // 
            // lstbQueue
            // 
            this.lstbQueue.FormattingEnabled = true;
            this.lstbQueue.Location = new System.Drawing.Point(41, 59);
            this.lstbQueue.Name = "lstbQueue";
            this.lstbQueue.Size = new System.Drawing.Size(782, 485);
            this.lstbQueue.TabIndex = 0;
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.White;
            this.tabHistory.Controls.Add(this.btnClearHistory);
            this.tabHistory.Controls.Add(this.lstbHistory);
            this.tabHistory.ImageKey = "history.png";
            this.tabHistory.Location = new System.Drawing.Point(4, 39);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(1186, 590);
            this.tabHistory.TabIndex = 3;
            this.tabHistory.Text = "History";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearHistory.Depth = 0;
            this.btnClearHistory.HighEmphasis = true;
            this.btnClearHistory.Icon = null;
            this.btnClearHistory.Location = new System.Drawing.Point(26, 511);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearHistory.Size = new System.Drawing.Size(131, 36);
            this.btnClearHistory.TabIndex = 2;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearHistory.UseAccentColor = false;
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // lstbHistory
            // 
            this.lstbHistory.FormattingEnabled = true;
            this.lstbHistory.Location = new System.Drawing.Point(26, 21);
            this.lstbHistory.Name = "lstbHistory";
            this.lstbHistory.Size = new System.Drawing.Size(1022, 472);
            this.lstbHistory.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbThemeToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurgerHome)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.pnlOrderInfo.ResumeLayout(false);
            this.pnlOrderInfo.PerformLayout();
            this.flpnlMenu.ResumeLayout(false);
            this.pnlBurger.ResumeLayout(false);
            this.pnlBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBurger)).EndInit();
            this.pnlChicken.ResumeLayout(false);
            this.pnlChicken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChicken)).EndInit();
            this.pnlPizza.ResumeLayout(false);
            this.pnlPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPizza)).EndInit();
            this.pnlFries.ResumeLayout(false);
            this.pnlFries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFries)).EndInit();
            this.pnlCoffee.ResumeLayout(false);
            this.pnlCoffee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoffee)).EndInit();
            this.pnlCoke.ResumeLayout(false);
            this.pnlCoke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoke)).EndInit();
            this.tabQueue.ResumeLayout(false);
            this.tabQueue.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
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
        private System.Windows.Forms.Panel pnlBurger;
        private MaterialSkin.Controls.MaterialLabel lblBurgerPrice;
        private System.Windows.Forms.PictureBox ptbBurger;
        private MaterialSkin.Controls.MaterialCheckbox chkbBurger;
        private System.Windows.Forms.FlowLayoutPanel flpnlMenu;
        private System.Windows.Forms.Panel pnlChicken;
        private MaterialSkin.Controls.MaterialLabel lblChickenPrice;
        private MaterialSkin.Controls.MaterialCheckbox chkbChicken;
        private System.Windows.Forms.PictureBox ptbChicken;
        private System.Windows.Forms.Panel pnlPizza;
        private MaterialSkin.Controls.MaterialLabel lblPizzaPrice;
        private System.Windows.Forms.PictureBox ptbPizza;
        private MaterialSkin.Controls.MaterialCheckbox chkbPizza;
        private System.Windows.Forms.Panel pnlFries;
        private MaterialSkin.Controls.MaterialLabel lblFriesPrice;
        private System.Windows.Forms.PictureBox ptbFries;
        private MaterialSkin.Controls.MaterialCheckbox chkbFries;
        private System.Windows.Forms.Panel pnlCoffee;
        private MaterialSkin.Controls.MaterialLabel lblCoffee;
        private System.Windows.Forms.PictureBox ptbCoffee;
        private MaterialSkin.Controls.MaterialCheckbox chkbCoffee;
        private System.Windows.Forms.Panel pnlCoke;
        private MaterialSkin.Controls.MaterialLabel lblCokePrice;
        private System.Windows.Forms.PictureBox ptbCoke;
        private MaterialSkin.Controls.MaterialCheckbox chkbCoke;
        private MaterialSkin.Controls.MaterialTextBox tbCustomersName;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private System.Windows.Forms.Panel pnlOrderInfo;
        private MaterialSkin.Controls.MaterialButton btnSendOrder;
        private MaterialSkin.Controls.MaterialLabel lblTotalPrice;
        private MaterialSkin.Controls.MaterialLabel lblTotalItem;
        private MaterialSkin.Controls.MaterialLabel lblCustomersName;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private System.Windows.Forms.ListBox lstbOrders;
        private MaterialSkin.Controls.MaterialLabel lblQueueTotalPrice;
        private MaterialSkin.Controls.MaterialLabel lblQueueTotalItem;
        private MaterialSkin.Controls.MaterialLabel lblQueueName;
        private MaterialSkin.Controls.MaterialLabel lblQueueDate;
        private System.Windows.Forms.ListBox lstbQueue;
        private MaterialSkin.Controls.MaterialButton btnCountAllOrders;
        private MaterialSkin.Controls.MaterialButton btnShowFirstOrder;
        private MaterialSkin.Controls.MaterialButton btnRemoveTopOrder;
        private MaterialSkin.Controls.MaterialButton btnClearAllOrders;
        private System.Windows.Forms.ListBox lstbHistory;
        private MaterialSkin.Controls.MaterialButton btnClearHistory;
        private System.Windows.Forms.PictureBox ptbThemeToggle;
    }
}

