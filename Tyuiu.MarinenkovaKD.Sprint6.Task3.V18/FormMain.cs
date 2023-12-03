using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MarinenkovaKD.Sprint6.Task3.V18.Lib;


namespace Tyuiu.MarinenkovaKD.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -19, -19, 1, 18, 7 },
                { 5, 3, -4, -6, -12 },
                { -15, 6, 2, 2, -14 },
                { -9, -10, 15, -5, -6 },
                { -13, -15, -9, 7, 1 }, };

        private void buttonDone_MKD_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;
            dataGridViewResult_MKD.ColumnCount = columns;
            dataGridViewResult_MKD.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_MKD.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_MKD.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_MKD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-23-1 Мариненкова Кристина Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
