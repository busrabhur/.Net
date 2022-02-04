using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messagetext = "";

            switch (textBox1.Text)
            {
                case "2":
                    messagetext = "text is 2";
                    break;
                case "4":
                    messagetext = "text is 4";
                    break;
                case "6":
                    messagetext = "text is 6";
                    break;
                default:
                    messagetext = "text is 8";
                    break;
            }

            MessageBox.Show(messagetext);

        }
    }
}
