using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            
            employee.Name = txtName.Text;
            employee.LastName = txtLastName.Text;

            //2.form classının nesnesini oluşturarak onu buradan açabiliriz
            FormEmpDetails form2 = new FormEmpDetails();
            //form2 nin elementlerine form2. şeklinde şuanki formdan ulaşabiliriz(private değil public olmaları lazım)

            object id = txtID.Text;
            int id_val = 0;
            bool control = int.TryParse(txtID.Text, out id_val);

            if (control)
            {
                employee.EmployeeID = Convert.ToInt32(txtID.Text);
                form2.label1.Text = "id: " + employee.EmployeeID;
            }

            form2.label2.Text = "name:" + employee.Name;
            form2.label3.Text = "lastname: " + employee.LastName;
            form2.Show(); //ikinci formun görünebilmesi için gereklidir
            //show yaparsak her iki forma da müdahale edebilir tıklayabiliriz
            //showdialog() yaparsak açılan yani bu formu kapatmadan altındakine tıklanmaz kullanılamaz

        }
    }
}
