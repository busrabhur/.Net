using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.setValues();//parentının metodu
            teacher.SetValues2();//kendi metodu
            teacher.FindSalary();//kendi metodu

            String text = "";
            text += teacher.Name+Environment.NewLine;
            text += teacher.Surname+ Environment.NewLine;
            text += teacher.ID + Environment.NewLine;
            text += teacher.age + Environment.NewLine;
            text += teacher.branch + Environment.NewLine;
            text += teacher.Gender + Environment.NewLine;
            text += teacher.Salary + Environment.NewLine;
            text += teacher.Position + Environment.NewLine;

            textBox1.Text= text;

           
        }
    }
}
