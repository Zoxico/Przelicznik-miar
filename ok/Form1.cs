using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                double bufor = Convert.ToDouble(textBox1.Text);
                bufor = 0.39 * bufor;
                label7.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox2.Text);
                bufor = 1.09 * bufor;
                label8.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox3.Text);
                bufor = 3.28 * bufor;
                label9.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox4.Text);
                bufor = 0.62 * bufor;
                label10.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox5.Text);
                bufor = 0.035 * bufor;
                label11.Text = bufor.ToString();

            }
            else
            {
                double bufor = Convert.ToDouble(textBox1.Text);
                bufor = 2.54 * bufor;
                label7.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox2.Text);
                bufor = 0.91 * bufor;
                label8.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox3.Text);
                bufor = 0.30 * bufor;
                label9.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox4.Text);
                bufor = 1.61 * bufor;
                label10.Text = bufor.ToString();

                bufor = Convert.ToDouble(textBox5.Text);
                bufor = 28.35 * bufor;
                label11.Text = bufor.ToString();
            }
            
        }
    }
}
