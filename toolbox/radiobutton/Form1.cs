using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //radio button : birçok seçeneğin içinden bitane seçebiliriz.
            //radio buttons are usullay placed in a group on a container control such as a groupbox
            //only one of them will be selected
            //hangi radio buttonun auto check özelliği true ise program çalıştığı anda o seçili gelir.
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            MessageBox.Show("checked changed");
        }

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("checked changed");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("checked changed");
        }
    }
}
