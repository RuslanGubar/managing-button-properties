﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_лаба_3_зад
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        button3.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        button3.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "текст выведен в метку!";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
