using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace order_management_system
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tabcontMenu.SelectedTab = tabMenu;
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            tabcontMenu.SelectedTab = tabQueue;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            tabcontMenu.SelectedTab = tabHistory;
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            if (btnTheme.Text == "LIGHT MODE")
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                btnTheme.Text = "DARK MODE";
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                btnTheme.Text = "LIGHT MODE";
            }        
        }
    }
}