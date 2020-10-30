﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Bank1();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Bank2();
            f.ShowDialog();
        }
    }
}
