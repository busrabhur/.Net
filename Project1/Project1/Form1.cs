using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // uygulamayı kapatır.
        }

        int firstNum = 0, lastNum = 0;
        int divisibleTerm = 1;

        private void Form1_Load(object sender, EventArgs e) //forma çift tıklayınca oluşuyor.
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("10");
        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
        }

        String divisibleNums = "";

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            divisibleNums = "";
            txtDivisibleNumbers.Clear();
        }

        private void txtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ilgili text box içine sadece rakam,sayı yazılabilmesini keypress eventi ile sağlayalım
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ilgili text box içine sadece rakam,sayı yazılabilmesini keypress eventi ile sağlayalım
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;

            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbRed.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;

            }
        }

        private void btn_Count_Click(object sender, EventArgs e)
        {
            //ilk ve son sayı boş bırakılırsa program çökmesin diye kontrol etmeliyiz.
            if(txtStartFrom.Text.Trim()=="" || txtTo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the necessarry fields.");
            }
            else if (cmbDivisibleTerm.SelectedIndex == -1) //yani comboboxtan hiç sayı seçilmemişsse
            {
                MessageBox.Show("Please select divisible term.");
            }
            else
            {
                firstNum = Convert.ToInt32(txtStartFrom.Text);
                lastNum = Convert.ToInt32(txtTo.Text);
                MessageBox.Show("Divisible " + divisibleTerm + " from " + firstNum + " to " + lastNum);

                for (int i = firstNum; i < lastNum; i++)
                {
                    if (i % divisibleTerm == 0)
                        divisibleNums += i.ToString() + " ";
                }
                txtDivisibleNumbers.Text = divisibleNums;
            }
            
        }

    }
}
