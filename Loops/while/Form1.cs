using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int inLoopWorkAmount = 0, inLoopControlValue = 0;
            int outLoopWorkAmount = 0, outLoopControlValue = 10;

            while (outLoopControlValue <20)
            {

                inLoopControlValue = 0;
                while (inLoopControlValue<8)
                {
                    inLoopControlValue++;
                    inLoopWorkAmount++;
                    textBox1.Text += outLoopControlValue.ToString() + " " + inLoopControlValue.ToString() + Environment.NewLine;
                }
                outLoopWorkAmount++;
                outLoopControlValue++;
            }
            MessageBox.Show("outloop works " +outLoopWorkAmount +" inloop works "+inLoopWorkAmount);
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int loopWorkAmount = 0, loopControlValue = 10;

            do
            {
                loopWorkAmount++;
                loopControlValue++;
                textBox1.Text += loopWorkAmount.ToString() + Environment.NewLine;
               
            } while (loopControlValue < 20);

            MessageBox.Show(loopWorkAmount.ToString());
        }
    }
}
