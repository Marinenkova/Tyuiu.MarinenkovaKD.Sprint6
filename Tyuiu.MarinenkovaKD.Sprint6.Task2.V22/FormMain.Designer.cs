
namespace Tyuiu.MarinenkovaKD.Sprint6.Task2.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_МКД = new System.Windows.Forms.GroupBox();
            this.labelCondition_МКД = new System.Windows.Forms.Label();
            this.pictureBoxCondition_МКД = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_МКД = new System.Windows.Forms.GroupBox();
            this.labelStart_МКД = new System.Windows.Forms.Label();
            this.labelStop_МКД = new System.Windows.Forms.Label();
            this.textBoxStart_МКД = new System.Windows.Forms.TextBox();
            this.textBoxStop_МКД = new System.Windows.Forms.TextBox();
            this.buttonRef_МКД = new System.Windows.Forms.Button();
            this.buttonResult_МКД = new System.Windows.Forms.Button();
            this.groupBoxOutput_МКД = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_МКД = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_МКД = new System.Windows.Forms.Label();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_МКД.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_МКД)).BeginInit();
            this.groupBoxInput_МКД.SuspendLayout();
            this.groupBoxOutput_МКД.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_МКД)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_МКД
            // 
            this.groupBoxCondition_МКД.Controls.Add(this.pictureBoxCondition_МКД);
            this.groupBoxCondition_МКД.Controls.Add(this.labelCondition_МКД);
            this.groupBoxCondition_МКД.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_МКД.Name = "groupBoxCondition_МКД";
            this.groupBoxCondition_МКД.Size = new System.Drawing.Size(365, 133);
            this.groupBoxCondition_МКД.TabIndex = 0;
            this.groupBoxCondition_МКД.TabStop = false;
            this.groupBoxCondition_МКД.Text = "Условие";
            // 
            // labelCondition_МКД
            // 
            this.labelCondition_МКД.AutoSize = true;
            this.labelCondition_МКД.Location = new System.Drawing.Point(6, 16);
            this.labelCondition_МКД.Name = "labelCondition_МКД";
            this.labelCondition_МКД.Size = new System.Drawing.Size(350, 13);
            this.labelCondition_МКД.TabIndex = 0;
            this.labelCondition_МКД.Text = "Написать программу, которая выводит таблицу значений функции:";
            // 
            // pictureBoxCondition_МКД
            // 
            this.pictureBoxCondition_МКД.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_МКД.Image")));
            this.pictureBoxCondition_МКД.Location = new System.Drawing.Point(9, 32);
            this.pictureBoxCondition_МКД.Name = "pictureBoxCondition_МКД";
            this.pictureBoxCondition_МКД.Size = new System.Drawing.Size(283, 50);
            this.pictureBoxCondition_МКД.TabIndex = 1;
            this.pictureBoxCondition_МКД.TabStop = false;
            // 
            // groupBoxInput_МКД
            // 
            this.groupBoxInput_МКД.Controls.Add(this.textBoxStop_МКД);
            this.groupBoxInput_МКД.Controls.Add(this.textBoxStart_МКД);
            this.groupBoxInput_МКД.Controls.Add(this.labelStop_МКД);
            this.groupBoxInput_МКД.Controls.Add(this.labelStart_МКД);
            this.groupBoxInput_МКД.Location = new System.Drawing.Point(12, 152);
            this.groupBoxInput_МКД.Name = "groupBoxInput_МКД";
            this.groupBoxInput_МКД.Size = new System.Drawing.Size(144, 59);
            this.groupBoxInput_МКД.TabIndex = 1;
            this.groupBoxInput_МКД.TabStop = false;
            this.groupBoxInput_МКД.Text = "Ввод данных";
            // 
            // labelStart_МКД
            // 
            this.labelStart_МКД.AutoSize = true;
            this.labelStart_МКД.Location = new System.Drawing.Point(9, 20);
            this.labelStart_МКД.Name = "labelStart_МКД";
            this.labelStart_МКД.Size = new System.Drawing.Size(36, 13);
            this.labelStart_МКД.TabIndex = 0;
            this.labelStart_МКД.Text = "Старт";
            // 
            // labelStop_МКД
            // 
            this.labelStop_МКД.AutoSize = true;
            this.labelStop_МКД.Location = new System.Drawing.Point(77, 20);
            this.labelStop_МКД.Name = "labelStop_МКД";
            this.labelStop_МКД.Size = new System.Drawing.Size(38, 13);
            this.labelStop_МКД.TabIndex = 1;
            this.labelStop_МКД.Text = "Конец";
            // 
            // textBoxStart_МКД
            // 
            this.textBoxStart_МКД.Location = new System.Drawing.Point(9, 33);
            this.textBoxStart_МКД.Name = "textBoxStart_МКД";
            this.textBoxStart_МКД.Size = new System.Drawing.Size(55, 20);
            this.textBoxStart_МКД.TabIndex = 2;
            this.textBoxStart_МКД.Text = "-5";
            // 
            // textBoxStop_МКД
            // 
            this.textBoxStop_МКД.Location = new System.Drawing.Point(80, 33);
            this.textBoxStop_МКД.Name = "textBoxStop_МКД";
            this.textBoxStop_МКД.Size = new System.Drawing.Size(55, 20);
            this.textBoxStop_МКД.TabIndex = 3;
            this.textBoxStop_МКД.Text = "5";
            // 
            // buttonRef_МКД
            // 
            this.buttonRef_МКД.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRef_МКД.Location = new System.Drawing.Point(162, 157);
            this.buttonRef_МКД.Name = "buttonRef_МКД";
            this.buttonRef_МКД.Size = new System.Drawing.Size(64, 54);
            this.buttonRef_МКД.TabIndex = 2;
            this.buttonRef_МКД.Text = "Справка";
            this.buttonRef_МКД.UseVisualStyleBackColor = false;
            this.buttonRef_МКД.Click += new System.EventHandler(this.buttonRef_МКД_Click_1);
            // 
            // buttonResult_МКД
            // 
            this.buttonResult_МКД.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonResult_МКД.Location = new System.Drawing.Point(232, 157);
            this.buttonResult_МКД.Name = "buttonResult_МКД";
            this.buttonResult_МКД.Size = new System.Drawing.Size(144, 54);
            this.buttonResult_МКД.TabIndex = 3;
            this.buttonResult_МКД.Text = "Выполнить";
            this.buttonResult_МКД.UseVisualStyleBackColor = false;
            this.buttonResult_МКД.Click += new System.EventHandler(this.buttonResult_МКД_Click);
            this.buttonResult_МКД.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_МКД_MouseDown);
            this.buttonResult_МКД.MouseEnter += new System.EventHandler(this.buttonResult_МКД_MouseEnter);
            this.buttonResult_МКД.MouseLeave += new System.EventHandler(this.buttonResult_МКД_MouseLeave_1);
            // 
            // groupBoxOutput_МКД
            // 
            this.groupBoxOutput_МКД.Controls.Add(this.chartFunction);
            this.groupBoxOutput_МКД.Controls.Add(this.labelResult_МКД);
            this.groupBoxOutput_МКД.Controls.Add(this.dataGridViewResult_МКД);
            this.groupBoxOutput_МКД.Location = new System.Drawing.Point(383, 12);
            this.groupBoxOutput_МКД.Name = "groupBoxOutput_МКД";
            this.groupBoxOutput_МКД.Size = new System.Drawing.Size(475, 199);
            this.groupBoxOutput_МКД.TabIndex = 4;
            this.groupBoxOutput_МКД.TabStop = false;
            this.groupBoxOutput_МКД.Text = "Вывод данных";
            // 
            // dataGridViewResult_МКД
            // 
            this.dataGridViewResult_МКД.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_МКД.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewResult_МКД.Location = new System.Drawing.Point(7, 32);
            this.dataGridViewResult_МКД.Name = "dataGridViewResult_МКД";
            this.dataGridViewResult_МКД.RowHeadersVisible = false;
            this.dataGridViewResult_МКД.Size = new System.Drawing.Size(104, 161);
            this.dataGridViewResult_МКД.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(x)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // labelResult_МКД
            // 
            this.labelResult_МКД.AutoSize = true;
            this.labelResult_МКД.Location = new System.Drawing.Point(7, 15);
            this.labelResult_МКД.Name = "labelResult_МКД";
            this.labelResult_МКД.Size = new System.Drawing.Size(62, 13);
            this.labelResult_МКД.TabIndex = 1;
            this.labelResult_МКД.Text = "Результат:";
            // 
            // chartFunction
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction.Legends.Add(legend5);
            this.chartFunction.Location = new System.Drawing.Point(117, 32);
            this.chartFunction.Name = "chartFunction";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction.Series.Add(series5);
            this.chartFunction.Size = new System.Drawing.Size(352, 161);
            this.chartFunction.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 222);
            this.Controls.Add(this.groupBoxOutput_МКД);
            this.Controls.Add(this.buttonResult_МКД);
            this.Controls.Add(this.buttonRef_МКД);
            this.Controls.Add(this.groupBoxInput_МКД);
            this.Controls.Add(this.groupBoxCondition_МКД);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 22 | Мариненкова К. Д. ИСТНб-23-1";
            this.groupBoxCondition_МКД.ResumeLayout(false);
            this.groupBoxCondition_МКД.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_МКД)).EndInit();
            this.groupBoxInput_МКД.ResumeLayout(false);
            this.groupBoxInput_МКД.PerformLayout();
            this.groupBoxOutput_МКД.ResumeLayout(false);
            this.groupBoxOutput_МКД.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_МКД)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_МКД;
        private System.Windows.Forms.PictureBox pictureBoxCondition_МКД;
        private System.Windows.Forms.Label labelCondition_МКД;
        private System.Windows.Forms.GroupBox groupBoxInput_МКД;
        private System.Windows.Forms.TextBox textBoxStop_МКД;
        private System.Windows.Forms.TextBox textBoxStart_МКД;
        private System.Windows.Forms.Label labelStop_МКД;
        private System.Windows.Forms.Label labelStart_МКД;
        private System.Windows.Forms.Button buttonRef_МКД;
        private System.Windows.Forms.Button buttonResult_МКД;
        private System.Windows.Forms.GroupBox groupBoxOutput_МКД;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Label labelResult_МКД;
        private System.Windows.Forms.DataGridView dataGridViewResult_МКД;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

