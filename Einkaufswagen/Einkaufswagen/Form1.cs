﻿using System;
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
    public partial class Form1 : Form

    {
        public List<OrderItem> productlist = new List<OrderItem>();
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProductName = Convert.ToString(textBox1.Text);
            int Amount = Convert.ToInt32(numericUpDown1.Value);

            OrderItem i = new OrderItem(ProductName, Amount);
            productlist.Add(i);
            
        }

        public List<OrderItem> GetProductList()
        {
            return productlist;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



