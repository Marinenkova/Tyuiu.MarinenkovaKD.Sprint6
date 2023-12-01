using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MarinenkovaKD.Sprint6.Task1.V24.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_МКД_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_МКД.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_МКД.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_МКД.Text = "";
                textBoxResult_МКД.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult_МКД.AppendText("|    X    |   f(x)  |" + Environment.NewLine);
                textBoxResult_МКД.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1, 5:f2}  |", startStep, valueArray[i]);
                    textBoxResult_МКД.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_МКД.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRef_МКД_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-23-1 Мариненкова Кристина Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
