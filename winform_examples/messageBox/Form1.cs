using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string messagetex = "Do you wanna close the window";
            string massageTitle = "a massagebox";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messagetex, massageTitle, buttons);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                //do nothing
            }
                
            


        }
    }
}
