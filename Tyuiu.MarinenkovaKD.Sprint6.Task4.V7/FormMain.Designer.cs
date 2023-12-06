
using System;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task4.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_MKD = new System.Windows.Forms.Panel();
            this.buttonHelp_MKD = new System.Windows.Forms.Button();
            this.buttonSave_MKD = new System.Windows.Forms.Button();
            this.buttonDone_MKD = new System.Windows.Forms.Button();
            this.groupBoxIntPut_MKD = new System.Windows.Forms.GroupBox();
            this.labelStop_MKD = new System.Windows.Forms.Label();
            this.labelStart_MKD = new System.Windows.Forms.Label();
            this.textBoxStop_MKD = new System.Windows.Forms.TextBox();
            this.textBoxStart_MKD = new System.Windows.Forms.TextBox();
            this.groupBoxTask_MKD = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_MKD = new System.Windows.Forms.PictureBox();
            this.textBoxTask_MKD = new System.Windows.Forms.TextBox();
            this.panelFill_MKD = new System.Windows.Forms.Panel();
            this.chartFunction_MKD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft_MKD = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_MKD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MKD = new System.Windows.Forms.TextBox();
            this.panelTop_MKD.SuspendLayout();
            this.groupBoxIntPut_MKD.SuspendLayout();
            this.groupBoxTask_MKD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_MKD)).BeginInit();
            this.panelFill_MKD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MKD)).BeginInit();
            this.panelLeft_MKD.SuspendLayout();
            this.groupBoxOutPut_MKD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_MKD
            // 
            this.panelTop_MKD.Controls.Add(this.buttonHelp_MKD);
            this.panelTop_MKD.Controls.Add(this.buttonSave_MKD);
            this.panelTop_MKD.Controls.Add(this.buttonDone_MKD);
            this.panelTop_MKD.Controls.Add(this.groupBoxIntPut_MKD);
            this.panelTop_MKD.Controls.Add(this.groupBoxTask_MKD);
            this.panelTop_MKD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MKD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MKD.Name = "panelTop_MKD";
            this.panelTop_MKD.Size = new System.Drawing.Size(607, 114);
            this.panelTop_MKD.TabIndex = 3;
            // 
            // buttonHelp_MKD
            // 
            this.buttonHelp_MKD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MKD.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonHelp_MKD.Location = new System.Drawing.Point(547, 12);
            this.buttonHelp_MKD.Name = "buttonHelp_MKD";
            this.buttonHelp_MKD.Size = new System.Drawing.Size(48, 45);
            this.buttonHelp_MKD.TabIndex = 4;
            this.buttonHelp_MKD.Text = "?";
            this.buttonHelp_MKD.UseVisualStyleBackColor = false;
            this.buttonHelp_MKD.Click += new System.EventHandler(this.buttonHelp_MKD_Click);
            // 
            // buttonSave_MKD
            // 
            this.buttonSave_MKD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave_MKD.Location = new System.Drawing.Point(416, 77);
            this.buttonSave_MKD.Name = "buttonSave_MKD";
            this.buttonSave_MKD.Size = new System.Drawing.Size(124, 30);
            this.buttonSave_MKD.TabIndex = 3;
            this.buttonSave_MKD.Text = "Сохранить";
            this.buttonSave_MKD.UseVisualStyleBackColor = false;
            this.buttonSave_MKD.Click += new System.EventHandler(this.buttonSave_MKD_Click);
            // 
            // buttonDone_MKD
            // 
            this.buttonDone_MKD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDone_MKD.Location = new System.Drawing.Point(416, 12);
            this.buttonDone_MKD.Name = "buttonDone_MKD";
            this.buttonDone_MKD.Size = new System.Drawing.Size(125, 59);
            this.buttonDone_MKD.TabIndex = 2;
            this.buttonDone_MKD.Text = "Выполнить";
            this.buttonDone_MKD.UseVisualStyleBackColor = false;
            this.buttonDone_MKD.Click += new System.EventHandler(this.buttonDone_MKD_Click);
            // 
            // groupBoxIntPut_MKD
            // 
            this.groupBoxIntPut_MKD.Controls.Add(this.labelStop_MKD);
            this.groupBoxIntPut_MKD.Controls.Add(this.labelStart_MKD);
            this.groupBoxIntPut_MKD.Controls.Add(this.textBoxStop_MKD);
            this.groupBoxIntPut_MKD.Controls.Add(this.textBoxStart_MKD);
            this.groupBoxIntPut_MKD.Location = new System.Drawing.Point(323, 8);
            this.groupBoxIntPut_MKD.Name = "groupBoxIntPut_MKD";
            this.groupBoxIntPut_MKD.Size = new System.Drawing.Size(87, 100);
            this.groupBoxIntPut_MKD.TabIndex = 1;
            this.groupBoxIntPut_MKD.TabStop = false;
            this.groupBoxIntPut_MKD.Text = "Ввод данных";
            // 
            // labelStop_MKD
            // 
            this.labelStop_MKD.AutoSize = true;
            this.labelStop_MKD.Location = new System.Drawing.Point(7, 59);
            this.labelStop_MKD.Name = "labelStop_MKD";
            this.labelStop_MKD.Size = new System.Drawing.Size(31, 13);
            this.labelStop_MKD.TabIndex = 3;
            this.labelStop_MKD.Text = "Стоп";
            // 
            // labelStart_MKD
            // 
            this.labelStart_MKD.AutoSize = true;
            this.labelStart_MKD.Location = new System.Drawing.Point(7, 20);
            this.labelStart_MKD.Name = "labelStart_MKD";
            this.labelStart_MKD.Size = new System.Drawing.Size(36, 13);
            this.labelStart_MKD.TabIndex = 2;
            this.labelStart_MKD.Text = "Старт";
            // 
            // textBoxStop_MKD
            // 
            this.textBoxStop_MKD.Location = new System.Drawing.Point(7, 74);
            this.textBoxStop_MKD.Name = "textBoxStop_MKD";
            this.textBoxStop_MKD.Size = new System.Drawing.Size(74, 20);
            this.textBoxStop_MKD.TabIndex = 1;
            this.textBoxStop_MKD.Text = "5";
            // 
            // textBoxStart_MKD
            // 
            this.textBoxStart_MKD.Location = new System.Drawing.Point(7, 36);
            this.textBoxStart_MKD.Name = "textBoxStart_MKD";
            this.textBoxStart_MKD.Size = new System.Drawing.Size(74, 20);
            this.textBoxStart_MKD.TabIndex = 0;
            this.textBoxStart_MKD.Text = "-5";
            // 
            // groupBoxTask_MKD
            // 
            this.groupBoxTask_MKD.Controls.Add(this.pictureBoxTask_MKD);
            this.groupBoxTask_MKD.Controls.Add(this.textBoxTask_MKD);
            this.groupBoxTask_MKD.Location = new System.Drawing.Point(8, 8);
            this.groupBoxTask_MKD.Name = "groupBoxTask_MKD";
            this.groupBoxTask_MKD.Size = new System.Drawing.Size(308, 100);
            this.groupBoxTask_MKD.TabIndex = 0;
            this.groupBoxTask_MKD.TabStop = false;
            this.groupBoxTask_MKD.Text = "Условие:";
            // 
            // pictureBoxTask_MKD
            // 
            this.pictureBoxTask_MKD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_MKD.Image")));
            this.pictureBoxTask_MKD.Location = new System.Drawing.Point(7, 59);
            this.pictureBoxTask_MKD.Name = "pictureBoxTask_MKD";
            this.pictureBoxTask_MKD.Size = new System.Drawing.Size(214, 35);
            this.pictureBoxTask_MKD.TabIndex = 1;
            this.pictureBoxTask_MKD.TabStop = false;
            // 
            // textBoxTask_MKD
            // 
            this.textBoxTask_MKD.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_MKD.Multiline = true;
            this.textBoxTask_MKD.Name = "textBoxTask_MKD";
            this.textBoxTask_MKD.ReadOnly = true;
            this.textBoxTask_MKD.Size = new System.Drawing.Size(295, 33);
            this.textBoxTask_MKD.TabIndex = 0;
            this.textBoxTask_MKD.Text = "Написать программу, которая выводит таблицу значений функции:";
            // 
            // panelFill_MKD
            // 
            this.panelFill_MKD.Controls.Add(this.chartFunction_MKD);
            this.panelFill_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_MKD.Location = new System.Drawing.Point(220, 114);
            this.panelFill_MKD.Name = "panelFill_MKD";
            this.panelFill_MKD.Size = new System.Drawing.Size(387, 424);
            this.panelFill_MKD.TabIndex = 5;
            // 
            // chartFunction_MKD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_MKD.ChartAreas.Add(chartArea1);
            this.chartFunction_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_MKD.Legends.Add(legend1);
            this.chartFunction_MKD.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_MKD.Name = "chartFunction_MKD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MKD.Series.Add(series1);
            this.chartFunction_MKD.Size = new System.Drawing.Size(387, 424);
            this.chartFunction_MKD.TabIndex = 0;
            this.chartFunction_MKD.Text = "chart1";
            this.chartFunction_MKD.Click += new System.EventHandler(this.chartFunction_MKD_Click);
            // 
            // panelLeft_MKD
            // 
            this.panelLeft_MKD.Controls.Add(this.groupBoxOutPut_MKD);
            this.panelLeft_MKD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MKD.Location = new System.Drawing.Point(0, 114);
            this.panelLeft_MKD.Name = "panelLeft_MKD";
            this.panelLeft_MKD.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_MKD.Size = new System.Drawing.Size(220, 424);
            this.panelLeft_MKD.TabIndex = 4;
            // 
            // groupBoxOutPut_MKD
            // 
            this.groupBoxOutPut_MKD.Controls.Add(this.textBoxResult_MKD);
            this.groupBoxOutPut_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_MKD.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPut_MKD.Name = "groupBoxOutPut_MKD";
            this.groupBoxOutPut_MKD.Size = new System.Drawing.Size(210, 414);
            this.groupBoxOutPut_MKD.TabIndex = 0;
            this.groupBoxOutPut_MKD.TabStop = false;
            this.groupBoxOutPut_MKD.Text = "Вывод:";
            // 
            // textBoxResult_MKD
            // 
            this.textBoxResult_MKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_MKD.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_MKD.Multiline = true;
            this.textBoxResult_MKD.Name = "textBoxResult_MKD";
            this.textBoxResult_MKD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MKD.Size = new System.Drawing.Size(204, 395);
            this.textBoxResult_MKD.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 538);
            this.Controls.Add(this.panelFill_MKD);
            this.Controls.Add(this.panelLeft_MKD);
            this.Controls.Add(this.panelTop_MKD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 7 | Мариненкова К. Д.";
            this.panelTop_MKD.ResumeLayout(false);
            this.groupBoxIntPut_MKD.ResumeLayout(false);
            this.groupBoxIntPut_MKD.PerformLayout();
            this.groupBoxTask_MKD.ResumeLayout(false);
            this.groupBoxTask_MKD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_MKD)).EndInit();
            this.panelFill_MKD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MKD)).EndInit();
            this.panelLeft_MKD.ResumeLayout(false);
            this.groupBoxOutPut_MKD.ResumeLayout(false);
            this.groupBoxOutPut_MKD.PerformLayout();
            this.ResumeLayout(false);

        }

        private void chartFunction_MKD_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panelTop_MKD;
        private System.Windows.Forms.Panel panelFill_MKD;
        private System.Windows.Forms.Panel panelLeft_MKD;
        private System.Windows.Forms.GroupBox groupBoxOutPut_MKD;
        private System.Windows.Forms.TextBox textBoxResult_MKD;
        private System.Windows.Forms.Button buttonHelp_MKD;
        private System.Windows.Forms.Button buttonSave_MKD;
        private System.Windows.Forms.Button buttonDone_MKD;
        private System.Windows.Forms.GroupBox groupBoxIntPut_MKD;
        private System.Windows.Forms.GroupBox groupBoxTask_MKD;
        private System.Windows.Forms.Label labelStop_MKD;
        private System.Windows.Forms.Label labelStart_MKD;
        private System.Windows.Forms.TextBox textBoxStop_MKD;
        private System.Windows.Forms.TextBox textBoxStart_MKD;
        private System.Windows.Forms.PictureBox pictureBoxTask_MKD;
        private System.Windows.Forms.TextBox textBoxTask_MKD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MKD;
    }
}

