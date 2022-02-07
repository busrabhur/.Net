using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numlist = new List<int>();
        List<string> textlist = new List<string>();
        List<Employee> employeeList=new List<Employee>();

        List<Days> daylist=new List<Days>();

        public List<Employee> FillList()
        {
            employeeList.Clear();
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.Name = "Charles";
            e1.Surname = "Dickens";

            Employee e2 = new Employee();
            e2.Id = 2;
            e2.Name = "George";
            e2.Surname = "Orwell";

            Employee e3= new Employee();
            e3.Id = 3;
            e3.Name = "Jane";
            e3.Surname = "Austin";

            employeeList.Add(e1);
            employeeList.Add(e2);
            employeeList.Add(e3);

            return employeeList;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Days d1=new Days();
            d1.id = 1;
            d1.textValue = "Monday";
            daylist.Add(d1);

            Days d2=new Days();
            d2.id = 2;
            d2.textValue = "Tuesday";
            daylist.Add(d2);

            daylist.Add(new Days() { id=3,textValue="Wednesday"}); //bu şekilde ekleme esnasında da nesne oluşturabiliriz.

            //combobox
            cmbDays.DataSource = daylist; //combobox ın içeriğini alacağı kaynak
            cmbDays.DisplayMember = "textValue"; //we will see names.
            cmbDays.ValueMember = "id";//but when we get selected item,we will take the "id" parameter.
            //form üzerinden comboboxa çift tıkla ve bir seçim yapılınca oluşacak eventi yazalım


            //datagridview üzerinde günleri gösterelim
            dataGridDaylist.DataSource = daylist;//veriyi alacağı listeyi belirledik.//Liste için bu yeterli oldu.



        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            
            FillList();
            foreach (Employee emp in employeeList)
            {
                txtNumber.Text+= emp.Id.ToString() + emp.Name + emp.Surname+"\n";
            }

        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.SelectedValue.ToString());
        }
    }
}
