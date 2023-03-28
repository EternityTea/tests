using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Method1(double x)
        {
            double y = Math.Pow(x, 2) + Math.Sin(x);
            return y;
        }
        public double Method2(double x)
        {
            double y = Math.Cos(x);
            return y;
        }
        public double Method3(double x)
        {
            double y = Math.Pow(x, 2) - 3 * x;
            return y;
        }
        public double DoubleRes(double y)
        {
            return y *= 2;       
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string x1 = textBox1.Text;
                double y = 0;
                double x = Convert.ToDouble(x1);
                if (x <= 0)
                {
                    y = Method1(x);
                    radio1.Checked = true;
                }
                if (0 < x & x < 1)
                {
                    y = Method2(x);
                    radio2.Checked = true;
                }
                if (x >= 1)
                {
                    y = Method3(x);
                    radio3.Checked = true;

                }
                if (doubleRes.Checked) { y *= 2; }
                labelRes.Text = "Result: " + y;
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorect input");
                textBox1.Focus();
                return;
            }
        }

        private void Radio_Changed(object sender, EventArgs e)
        {
            try
            {
                string x1 = textBox1.Text;
                double y = 0;
                double x = Convert.ToDouble(x1);
                if (radio1.Checked)
                {
                    y = Method1(x);
                }

                if (radio2.Checked)
                {
                    y = Method2(x);

                }
                if (radio3.Checked)
                {
                    y = Method3(x);

                }
                if (doubleRes.Checked)y=DoubleRes(y); 
                labelRes.Text = "Result: " + y;

            }

            catch (FormatException)
            {
                MessageBox.Show("Incorect input");
                textBox1.Focus();
                return;
            }
        }


    }
};

