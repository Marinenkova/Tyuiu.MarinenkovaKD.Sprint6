using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MarinenkovaKD.Sprint6.Task0.V30.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task0.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutPut_МКД.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_МКД.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_МКД_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_МКД_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-23-1 Мариненкова Кристина Дмитриевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
