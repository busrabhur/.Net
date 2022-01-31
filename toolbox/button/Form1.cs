using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text="click";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butona tıklandığında ne olacağını click eventi içinde tanımlarız
            MessageBox.Show("Hello,I am C#");
            //butonun ismi tıklandı diye güncellensin ve backgroudn'ı kırmızı olsun.
            button1.Text = "clicked!";
            button1.BackColor = System.Drawing.Color.Red;

        }
    }
}
