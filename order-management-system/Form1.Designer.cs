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
            this.menu = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.queue = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
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
            this.home.ImageKey = "home.png";
            this.home.Location = new System.Drawing.Point(4, 39);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1186, 590);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "queue.png");
            this.imageList1.Images.SetKeyName(1, "menu.png");
            this.imageList1.Images.SetKeyName(2, "home.png");
            this.imageList1.Images.SetKeyName(3, "history.png");
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leigheat Restaurant";
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage menu;
        private System.Windows.Forms.TabPage queue;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.ImageList imageList1;
    }
}

