using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi3 = 0;
        int sayi2 = 0;
        int sayi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            

            if (sayi >= 59) 
            {
                sayi2 = sayi2 + 1;
                sayi = 0;
            }
            if (sayi2 >= 59)
            {
                sayi3 = sayi3 + 1;
                sayi2 = 0;
                sayi =0;
            }
            
             sayi++;

            if (sayi3 > 9)
            {
                label4.Text =sayi3.ToString();
            }
            else
            {
                label4.Text = "0" + sayi3.ToString();
            }
            
            label2.Text = sayi2.ToString();
            label1.Text = sayi.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi3 = 0;
            sayi2 = 0;
            sayi = 0;
            label1.Text = sayi.ToString();
            label2.Text = sayi2.ToString();
            label4.Text = "0" + sayi3.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
