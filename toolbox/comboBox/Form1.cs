using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //The combobox can hold multiple values at the same time.
            //the combobox is used to give user mulitple selection options
            /*when you click the arrow, a window will be opened (edit items) and then ypu can add items to combobox.
             * just write your items (alt alta yaz).
             */

            //sorted özelliğini true yaparsak itemler alfabetik olarak sıralı gelir.


            //istersek kodla da itemler ekleyebilirz
            comboBox1.Items.Add("january");
            comboBox1.SelectedIndex = 3; //hangisinin seçili geleceği

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object obj=comboBox1.SelectedItem;//object türünde döndürür
            string item=obj.ToString();

            MessageBox.Show("seçtiğiniz item:" + item);

        }
    }
}
