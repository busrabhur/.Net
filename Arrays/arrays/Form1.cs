using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            String[] days = new String[7];
            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";

            //let's show this array in the grid view.
            //öncelikle gridview e form kısmından 1 adet column ekledik.
            //şimdi de o column un satırlarına bu tek boyutlu diziyi tek tek yazalım

            for (int i = 0; i < days.Length; i++)
            {
                String rowText=days[i];
                dataGridView1.Rows.Add(rowText);
            }

        }

        private void btnMultiArray_Click(object sender, EventArgs e)
        {
            String[,] rows = new String[,]
            {
                {"1","Monday" },
                {"2","Tuesday"},
                {"3","Wednesday"},
                {"4","Thursday" },
                {"5","Friday" },
                {"6","Saturday"},
                {"7","Sunday"}
            };

            String[] row;

            for (int i = 0;i < rows.GetLength(0); i++)
            {
                row=new String[rows.GetLength(1)];
                for (int j = 0;j < rows.GetLength(1); j++) //satırdaki eleman sayısı kadar
                {
                    row[j]=rows[i,j]; // iç döngü bitince 1 satırın içeriği oluşur.
                }
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
