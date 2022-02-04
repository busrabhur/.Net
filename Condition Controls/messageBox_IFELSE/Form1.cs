using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageBox_IFELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wanna abort it?", "if control",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "Yes was choosen.";

            }
            else if(result == DialogResult.No)
            {
                textBox1.Text = "No was choosen";
            }
            else
            {
                textBox1.Text = "Cancel was choosen";
            }
        }
    }
}
