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
    public partial class CartForm : Form
    {
        OrderForm form;

        public CartForm(OrderForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
     
            foreach (OrderItem produkt in form.GetProductList())
            {

                listBox1.Items.Add(produkt.getAmount() + " " + produkt.getProductName());
            }
        }

        
    }
}

