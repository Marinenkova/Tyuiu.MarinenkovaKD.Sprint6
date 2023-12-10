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
using Tyuiu.MarinenkovaKD.Sprint6.Task7.V15.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MKD.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_MKD.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_MKD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MKD.ShowDialog();
            openFilePath = openFileDialogTask_MKD.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_MKD.ColumnCount = columns;
            dataGridViewInPut_MKD.RowCount = rows;
            dataGridViewOutPut_MKD.ColumnCount = columns;
            dataGridViewOutPut_MKD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_MKD.Columns[i].Width = 50;
                dataGridViewOutPut_MKD.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_MKD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_MKD.Enabled = true;
        }

        private void buttonDone_MKD_Click(object sender, EventArgs e)
        {
            int[,] arrayValues1 = new int[rows, columns];
            arrayValues1 = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_MKD.Rows[r].Cells[c].Value = arrayValues1[r, c];
                }
            }
            buttonSave_MKD.Enabled = true;
        }

        private void buttonSave_MKD_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MKD.FileName = "OutPutFileTask7v15.csv";
            saveFileDialogMatrix_MKD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MKD.ShowDialog();

            string path = saveFileDialogMatrix_MKD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_MKD.RowCount;
            int columns = dataGridViewOutPut_MKD.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_MKD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_MKD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_MKD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_MKD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKD.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_MKD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKD.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MKD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKD.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MKD_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_MKD.ToolTipTitle = "Справка";
        }
    }
}
