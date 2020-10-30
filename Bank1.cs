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
    public partial class Bank1 : Form
    {
        public Bank1()
        {
            InitializeComponent();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            adrestextBox.BackColor = Color.White;
            string adres = adrestextBox.Text;
            if(adres.Length==0)
            {
                adrestextBox.BackColor = Color.Pink;
                return;
            }
            if (adres[0] != 'A' && adres[0] != 'С')
            {
                adrestextBox.BackColor = Color.Pink;
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
            if(checkBox1.Checked==false)textBox4.Text = "450";
            else textBox4.Text = "600";
        }
    }
}
