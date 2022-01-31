using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //checkalign: kutucuğun hangi hizada olacağıbı belirler
            //checked özelliğini true yaparsan program çalıştığında seçili halde gelir.
            bool control = checkBox1.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //checkbox1 seçilirse olacak şey
        {
            MessageBox.Show("Tebrikler, çok yerinde bir karar verdiniz :D ");
            //

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
