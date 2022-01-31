using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*textbox is basically used to get input from users
            it can also be used to display some values to user*/

            //eğer password için kullanacaksan.passwordchar attributune saklamada kullanacağın karakteri gir.
            //readonly'i true yaparsan sadece okunabilir hale gelir



        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textA = textBox1.Text;
            label1.Text = textA;
        }
    }
}
