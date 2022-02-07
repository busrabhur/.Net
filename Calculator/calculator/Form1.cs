using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFirstNum_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double firstNumber=0, secondNumber=0;
        bool control = false;

        void Set1Parameter(String text)
        {
            if (text.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }
        }

      

        void Set2Parameter(String text,String text2)
        {
            if(text.Trim() !="" && text2.Trim() != "")
            {
                control = true;
                firstNumber=Convert.ToDouble(text);
                secondNumber=Convert.ToDouble(text2);

            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            txtResult.Text=Math.Min(Convert.ToDecimal(txtFirstNumber.Text),Convert.ToDecimal(txtSecondNumber.Text)).ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            txtResult.Text = Math.Max(Convert.ToDecimal(txtFirstNumber.Text), Convert.ToDecimal(txtSecondNumber.Text)).ToString();
        }

        private void btnAbs_Click(object sender, EventArgs e)

        {
            Set1Parameter(txtFirstNumber.Text);
            txtResult.Text = Math.Abs(firstNumber).ToString();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Set1Parameter(txtFirstNumber.Text);
            txtResult.Text=Math.Sign(firstNumber).ToString();
        }

        private void btnPow_Click(object sender, EventArgs e)

        {
            Set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            txtResult.Text = Math.Pow(firstNumber,secondNumber).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // C button clear all text
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }
    }
}
