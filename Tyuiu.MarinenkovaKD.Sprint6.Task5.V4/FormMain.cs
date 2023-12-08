using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MarinenkovaKD.Sprint6.Task5.V4.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Я твой-ты моя\source\repos\Tyuiu.MarinenkovaKD.Sprint6\Tyuiu.MarinenkovaKD.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";

        private void buttonDone_MKD_Click(object sender, EventArgs e)
        {
            dataGridViewNums_MKD.ColumnCount = 2;
            dataGridViewNums_MKD.Columns[0].Width = 30;
            dataGridViewNums_MKD.Columns[1].Width = 50;

            this.chartDiag_MKD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_MKD.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_MKD.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewNums_MKD.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartDiag_MKD.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonSave_MKD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MKD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-23-1 Мариненкова Кристина Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}    

