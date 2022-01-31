using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataTransferBetweenForms
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            string name = textName.Text; //textboxlardan aldıklarımız
            string surname=textSurname.Text;
            string fullname=name+surname;//now ww will send this the other form

            //diğer formu butona tıklayınca açmak görünür kılmak istiyoruz.

            frmShowData frmShowData = new frmShowData();
            frmShowData.Show();//2 formu aynı anda kullanamayalım istersen : show yerine showDialog() kullan
            
            frmShowData.lblNameSurname.Text = fullname; //2.formun labelına ulaşabilmek için ilgili labelı public yaptık form2 'de




        }
    }
}
