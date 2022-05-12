﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superShopManagementSystem.forms
{
    public partial class salesmanHomePage : Form
    {
        salesmanHomePage_productEntry sl1 = new salesmanHomePage_productEntry();
        salesmanHomPage_customer sl2 = new salesmanHomPage_customer();
        public salesmanHomePage()
        {
            InitializeComponent();
            loadform(sl2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadform(sl2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(sl1);
        }
    }
}
