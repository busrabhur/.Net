using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetValues_Click(object sender, EventArgs e)
        {
            Employee employee1 = new Employee();
            employee1.EmployeeID = Convert.ToInt32(txtId.Text); //id yi int olarak tanımladığımız için
            employee1.Name = txtName.Text;
            employee1.Age = Convert.ToInt32(txtAge.Text); //yaşı int olarak tanımladığımız için
            MessageBox.Show("All data received");
        }
    }
}
