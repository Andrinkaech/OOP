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
    public partial class Form2 : Form
    {
        OrderItem Oi;
        Form1 form;
        public Form2(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }




        private void Form2_Load(object sender, EventArgs e)
        {
     
            foreach (OrderItem produkt in form.GetProductList())
            {

                listBox1.Items.Add(produkt.getAmount() + " " + produkt.getProductName());
            }
        }

        
    }
}

