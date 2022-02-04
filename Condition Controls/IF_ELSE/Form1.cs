using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_ELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            String name = "Charles";
            bool control = true;

            if (a == 20)
            {
                label1.Text = "if block1 was executed";
            }
            if (!control)
            {
                textBox1.Text = "if block2 was executed"; //sadece bu çalışmaz.
            }
            if (a <= b)
            {
                MessageBox.Show("if block3 was executed"); 
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 20, b = 30;
            String name = "Charles";
            bool control = true;

            if (a == 30)
            {
                label1.Text = "if block1 was executed";
            }
            else if(control)
            {
                textBox1.Text = "if block2 was executed"; 
            }
            else if (a>=b)
            {
                textBox1.Text = "if block3 was executed";
            }
            else
            {
                MessageBox.Show("if block4 was executed");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
