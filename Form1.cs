using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8LB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            int[,] a = new int[15, 15];
            int i, j;

            Random rand = new Random();
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    a[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();

            int SA = 0;
            int sum = 0;
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                {
                    if (a[i, 0] == 1)
                        SA = (sum += a[i, j]) / 15;
                    else textBox1.Text = "Строки нет";

                    
                }
        }
    }
}
