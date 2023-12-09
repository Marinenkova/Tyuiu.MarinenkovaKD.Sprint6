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
using Tyuiu.MarinenkovaKD.Sprint6.Task6.V22.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_MKD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MKD.ShowDialog();
            openFilePath = openFileDialogTask_MKD.FileName;
            textBoxInPut_MKD.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_MKD.Text = groupBoxInPut_MKD.Text + "" + openFileDialogTask_MKD.FileName;
            buttonDone_MKD.Enabled = true;
        }

        private void buttonDone_MKD_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOutPut_MKD.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_MKD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
