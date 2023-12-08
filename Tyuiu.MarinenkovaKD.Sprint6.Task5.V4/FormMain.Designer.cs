
namespace Tyuiu.MarinenkovaKD.Sprint6.Task5.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_MKD = new System.Windows.Forms.Panel();
            this.buttonHelp_MKD = new System.Windows.Forms.Button();
            this.buttonSave_MKD = new System.Windows.Forms.Button();
            this.buttonDone_MKD = new System.Windows.Forms.Button();
            this.groupBoxTask_MKD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MKD = new System.Windows.Forms.TextBox();
            this.panelLeft_MKD = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_MKD = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_MKD = new System.Windows.Forms.DataGridView();
            this.panelFill_MKD = new System.Windows.Forms.Panel();
            this.chartDiag_MKD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOutPut_MKD = new System.Windows.Forms.Splitter();
            this.panelTop_MKD.SuspendLayout();
            this.groupBoxTask_MKD.SuspendLayout();
            this.panelLeft_MKD.SuspendLayout();
            this.groupBoxOutPut_MKD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_MKD)).BeginInit();
            this.panelFill_MKD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MKD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_MKD
            // 
            this.panelTop_MKD.Controls.Add(this.buttonHelp_MKD);
            this.panelTop_MKD.Controls.Add(this.buttonSave_MKD);
            this.panelTop_MKD.Controls.Add(this.buttonDone_MKD);
            this.panelTop_MKD.Controls.Add(this.groupBoxTask_MKD);
            this.panelTop_MKD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MKD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MKD.Name = "panelTop_MKD";
            this.panelTop_MKD.Size = new System.Drawing.Size(710, 100);
            this.panelTop_MKD.TabIndex = 0;
            // 
            // buttonHelp_MKD
            // 
            this.buttonHelp_MKD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MKD.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHelp_MKD.Location = new System.Drawing.Point(617, 22);
            this.buttonHelp_MKD.Name = "buttonHelp_MKD";
            this.buttonHelp_MKD.Size = new System.Drawing.Size(75, 60);
            this.buttonHelp_MKD.TabIndex = 1;
            this.buttonHelp_MKD.Text = "Справка";
            this.buttonHelp_MKD.UseVisualStyleBackColor = false;
            this.buttonHelp_MKD.Click += new System.EventHandler(this.buttonHelp_MKD_Click);
            // 
            // buttonSave_MKD
            // 
            this.buttonSave_MKD.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave_MKD.Location = new System.Drawing.Point(536, 22);
            this.buttonSave_MKD.Name = "buttonSave_MKD";
            this.buttonSave_MKD.Size = new System.Drawing.Size(75, 60);
            this.buttonSave_MKD.TabIndex = 1;
            this.buttonSave_MKD.Text = "Открыть";
            this.buttonSave_MKD.UseVisualStyleBackColor = false;
            this.buttonSave_MKD.Click += new System.EventHandler(this.buttonSave_MKD_Click);
            // 
            // buttonDone_MKD
            // 
            this.buttonDone_MKD.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_MKD.Location = new System.Drawing.Point(449, 22);
            this.buttonDone_MKD.Name = "buttonDone_MKD";
            this.buttonDone_MKD.Size = new System.Drawing.Size(81, 60);
            this.buttonDone_MKD.TabIndex = 1;
            this.buttonDone_MKD.Text = "Выполнить";
            this.buttonDone_MKD.UseVisualStyleBackColor = false;
            this.buttonDone_MKD.Click += new System.EventHandler(this.buttonDone_MKD_Click);
            // 
            // groupBoxTask_MKD
            // 
            this.groupBoxTask_MKD.Controls.Add(this.textBoxTask_MKD);
            this.groupBoxTask_MKD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MKD.Name = "groupBoxTask_MKD";
            this.groupBoxTask_MKD.Size = new System.Drawing.Size(431, 76);
            this.groupBoxTask_MKD.TabIndex = 0;
            this.groupBoxTask_MKD.TabStop = false;
            this.groupBoxTask_MKD.Text = "Условие";
            // 
            // textBoxTask_MKD
            // 
            this.textBoxTask_MKD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MKD.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_MKD.Multiline = true;
            this.textBoxTask_MKD.Name = "textBoxTask_MKD";
            this.textBoxTask_MKD.ReadOnly = true;
            this.textBoxTask_MKD.Size = new System.Drawing.Size(419, 51);
            this.textBoxTask_MKD.TabIndex = 0;
            this.textBoxTask_MKD.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести в" +
    "се целые числа.";
            // 
            // panelLeft_MKD
            // 
            this.panelLeft_MKD.Controls.Add(this.groupBoxOutPut_MKD);
            this.panelLeft_MKD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MKD.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_MKD.Name = "panelLeft_MKD";
            this.panelLeft_MKD.Size = new System.Drawing.Size(200, 350);
            this.panelLeft_MKD.TabIndex = 1;
            // 
            // groupBoxOutPut_MKD
            // 
            this.groupBoxOutPut_MKD.Controls.Add(this.dataGridViewNums_MKD);
            this.groupBoxOutPut_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_MKD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_MKD.Name = "groupBoxOutPut_MKD";
            this.groupBoxOutPut_MKD.Size = new System.Drawing.Size(200, 350);
            this.groupBoxOutPut_MKD.TabIndex = 0;
            this.groupBoxOutPut_MKD.TabStop = false;
            this.groupBoxOutPut_MKD.Text = "groupBox2";
            // 
            // dataGridViewNums_MKD
            // 
            this.dataGridViewNums_MKD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_MKD.ColumnHeadersVisible = false;
            this.dataGridViewNums_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_MKD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_MKD.Name = "dataGridViewNums_MKD";
            this.dataGridViewNums_MKD.ReadOnly = true;
            this.dataGridViewNums_MKD.RowHeadersVisible = false;
            this.dataGridViewNums_MKD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_MKD.Size = new System.Drawing.Size(194, 331);
            this.dataGridViewNums_MKD.TabIndex = 0;
            // 
            // panelFill_MKD
            // 
            this.panelFill_MKD.Controls.Add(this.chartDiag_MKD);
            this.panelFill_MKD.Controls.Add(this.splitterOutPut_MKD);
            this.panelFill_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_MKD.Location = new System.Drawing.Point(200, 100);
            this.panelFill_MKD.Name = "panelFill_MKD";
            this.panelFill_MKD.Size = new System.Drawing.Size(510, 350);
            this.panelFill_MKD.TabIndex = 2;
            // 
            // chartDiag_MKD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_MKD.ChartAreas.Add(chartArea1);
            this.chartDiag_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_MKD.Legends.Add(legend1);
            this.chartDiag_MKD.Location = new System.Drawing.Point(3, 0);
            this.chartDiag_MKD.Name = "chartDiag_MKD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_MKD.Series.Add(series1);
            this.chartDiag_MKD.Size = new System.Drawing.Size(507, 350);
            this.chartDiag_MKD.TabIndex = 1;
            this.chartDiag_MKD.Text = "chart1";
            // 
            // splitterOutPut_MKD
            // 
            this.splitterOutPut_MKD.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_MKD.Name = "splitterOutPut_MKD";
            this.splitterOutPut_MKD.Size = new System.Drawing.Size(3, 350);
            this.splitterOutPut_MKD.TabIndex = 0;
            this.splitterOutPut_MKD.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.panelFill_MKD);
            this.Controls.Add(this.panelLeft_MKD);
            this.Controls.Add(this.panelTop_MKD);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Мариненкова К.Д. ИСТНб-23-1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_MKD.ResumeLayout(false);
            this.groupBoxTask_MKD.ResumeLayout(false);
            this.groupBoxTask_MKD.PerformLayout();
            this.panelLeft_MKD.ResumeLayout(false);
            this.groupBoxOutPut_MKD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_MKD)).EndInit();
            this.panelFill_MKD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MKD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop_MKD;
        private System.Windows.Forms.Button buttonHelp_MKD;
        private System.Windows.Forms.Button buttonSave_MKD;
        private System.Windows.Forms.Button buttonDone_MKD;
        private System.Windows.Forms.GroupBox groupBoxTask_MKD;
        private System.Windows.Forms.TextBox textBoxTask_MKD;
        private System.Windows.Forms.Panel panelLeft_MKD;
        private System.Windows.Forms.GroupBox groupBoxOutPut_MKD;
        private System.Windows.Forms.DataGridView dataGridViewNums_MKD;
        private System.Windows.Forms.Panel panelFill_MKD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_MKD;
        private System.Windows.Forms.Splitter splitterOutPut_MKD;
    }
}

