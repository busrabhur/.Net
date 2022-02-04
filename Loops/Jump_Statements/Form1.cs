using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump_Statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBreak_Click(object sender, EventArgs e)
        {
            String s = "";
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    break;
                s = s + i + " ";
            }

            MessageBox.Show(s);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            String s = "";
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    continue;
                s = s + i + " ";
            }

            MessageBox.Show(s);
        }
        private void btn_GoTo_Click(object sender, EventArgs e)
        {

        }
    }
}
