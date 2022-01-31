using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //datetimepicker : format özelliğinden ne tarzda görünmesini istiyorsan seçebilirsim
            //mindate: hangi tarihten başlayacağını seçebilirsin.Kullanıcı daha öncesini seçemez.

            /*DateTimePicker also gives us a value of type 'DateTime' !!!!!!!!!!!!!!!!
             So we have to hold hold this in a datetime variable in order to use it.*/




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;
            //MessageBox.Show(birthday.ToString());
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString()); //sadece tarih bilgisi verir kısaca.
        }
    }
}
