using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void HideRadioButtons()
        {
            groupBox1.Visible = false;
        }

        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        public void FillTextBox2(string text)
        {
            textBox2.Text = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HideRadioButtons();
            ClearAllText();
            SetNumber(22);
        }

        public void SetNumber(int age)
        {
            label1.Text = "You are " + age + " years old";
        }

        public int Sum(int x,int y)
        {
            return x + y;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillTextBox2(textBox1.Text);
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int sum = Sum(Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            MessageBox.Show(sum.ToString());
        }
    }
}
