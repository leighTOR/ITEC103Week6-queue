using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MaterialSkin;
using MaterialSkin.Controls;

namespace order_management_system
{
    public partial class Form1 : MaterialForm
    {
        Queue queue = new Queue();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (chkbBurger.Checked)
            {
                lstbOrders.Items.Add("Big Burger                     P50.00");
            }
            if (chkbChicken.Checked)
            {
                lstbOrders.Items.Add("Cool Chicken                P80.00");
            }
            if (chkbPizza.Checked)
            {
                lstbOrders.Items.Add("Pretty Pizza                  P100.00");
            }
            if (chkbFries.Checked)
            {
                lstbOrders.Items.Add("Fancy Fries                   P90.00");
            }
            if (chkbCoffee.Checked)
            {
                lstbOrders.Items.Add("Calming Coffee           P60.00");
            }
            if (chkbCoke.Checked)
            {
                lstbOrders.Items.Add("Cold Coke                      P30.00");
            }

            lblCustomersName.Text = $"Customer's Name: {tbCustomersName.Text}";
            lblTotalItem.Text = $"Total Item: {lstbOrders.Items.Count}";

            //int price = 0;
            //switch (lstbOrders.Items.ToString())
            //{
            //    case "Big Burger                     P50.00":
            //        price = 50;
            //        break;
            //    case "Cool Chicken                P80.00":
            //        price = 80;
            //        break;
            //    case "Pretty Pizza                  P100.00":
            //        price = 100;
            //        break;
            //    case "Fancy Fries                   P90.00":
            //        price = 90;
            //        break;
            //    case "Calming Coffee           P60.00":
            //        price = 60;
            //        break;
            //    case "Cold Coke                      P30.00":
            //        price = 30;
            //        break;
            //}

            int price = 0;
            if (lstbOrders.Items.ToString() == "Big Burger                     P50.00")
            {
                price = 50;
            }
            if (lstbOrders.Items.ToString() == "Cool Chicken                P80.00")
            {
                price = 80;
            }
            if (lstbOrders.Items.ToString() == "Pretty Pizza                  P100.00")
            {
                price = 100;
            }
            if (lstbOrders.Items.ToString() == "Fancy Fries                   P90.00")
            {
                price = 90;
            }
            if (lstbOrders.Items.ToString() == "Calming Coffee           P60.00")
            {
                price = 60;
            }
            if (lstbOrders.Items.ToString() == "Cold Coke                      P30.00")
            {
                price = 30;
            }

            int totalPrice = 0;
            totalPrice += price;
            lblTotalPrice.Text = $"Total Price: {totalPrice}";
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstbOrders.Items.Remove(lstbOrders.SelectedItem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCustomersName.ResetText();
            lstbOrders.Items.Clear();
            lblCustomersName.Text = "Customer's Name: ";
            lblTotalItem.Text = "Total Item: ";
            lblTotalPrice.Text = "Total Price: ";
            chkbBurger.Checked = false;
            chkbChicken.Checked = false;
            chkbPizza.Checked = false;
            chkbFries.Checked = false;
            chkbCoffee.Checked = false;
            chkbCoke.Checked = false;
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            var order = DateTime.Now + "\t\t" + tbCustomersName.Text + "\t\t\t\t\t" + lstbOrders.Items.Count + "\t\t";
            lstbQueue.Items.Add(order);
            queue.Enqueue(order);
        }

        private void btnRemoveTopOrder_Click(object sender, EventArgs e)
        {
            try
            {
                lstbHistory.Items.Add(queue.Dequeue());
                lstbQueue.Items.RemoveAt(0);
            }
            catch
            {
                MessageBox.Show("Queue empty");
            }
        }

        private void btnShowFirstOrder_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"First order: {queue.Peek()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCountAllOrders_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Queue count: {queue.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearAllOrders_Click(object sender, EventArgs e)
        {
            foreach (var item in lstbQueue.Items)
            {
                lstbHistory.Items.Add(item);
            }
            lstbQueue.Items.Clear();
            queue.Clear();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstbHistory.Items.Clear();
        }
    }
}