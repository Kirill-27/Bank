using System;
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
    public partial class Bank2 : Form
    {
        public Bank2()
        {
            InitializeComponent();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            string chek = comboBox1.Text;
            if(string.IsNullOrEmpty(chek))
            {
                comboBox1.BackColor = Color.Pink;
                return;
            }
            chek = comboBox2.Text;
            if (string.IsNullOrEmpty(chek))
            {
                comboBox2.BackColor = Color.Pink;
                return;
            }
            chek = comboBox3.Text;
            if (string.IsNullOrEmpty(chek))
            {
                comboBox3.BackColor = Color.Pink;
                return;
            }
            label3.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            Pay.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            textBox1.Text = "150";
            textBox2.Text = "200";
            textBox3.Text = "250";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) textBox4.Text = "450";
            else textBox4.Text = "600";
        }
    }
}
