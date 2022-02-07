using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.Text = random.Next().ToString();
            label5.Text = random.Next().ToString();
        }

        private void btnRandomByte_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            byte[] arr = new byte[3];
            rnd.NextBytes(arr);//içine verilen arrayi rastgele sayılarla doldurur.
            label2.Text = arr[0].ToString();
            label3.Text = arr[1].ToString();
            label4.Text = arr[2].ToString();

            
        }
    }
}
