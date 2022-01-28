using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einkaufswagen
{
    public partial class OrderForm : Form
    {
        int counter;

        public List<OrderItem> productlist = new List<OrderItem>();
        CartForm cartForm;
        
        public OrderForm()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string ProductName = Convert.ToString(textBoxProductName.Text);
            int Amount = Convert.ToInt32(numUpDownAmount.Value);

            OrderItem i = new OrderItem(ProductName, Amount);
            productlist.Add(i);

            counter++;
            label3.Text = counter.ToString();
        }

        public List<OrderItem> GetProductList()
        {
            return productlist;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cartForm = new CartForm(this);
            cartForm.ShowDialog();
        }
    }
}



