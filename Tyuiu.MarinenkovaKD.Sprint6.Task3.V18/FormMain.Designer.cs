
namespace Tyuiu.MarinenkovaKD.Sprint6.Task3.V18
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
            this.groupBoxCondition_MKD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MKD = new System.Windows.Forms.TextBox();
            this.textBox1line = new System.Windows.Forms.TextBox();
            this.textBox2line = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MKD = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_MKD = new System.Windows.Forms.DataGridView();
            this.buttonDone_MKD = new System.Windows.Forms.Button();
            this.buttonHelp_MKD = new System.Windows.Forms.Button();
            this.groupBoxCondition_MKD.SuspendLayout();
            this.groupBoxOutput_MKD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MKD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_MKD
            // 
            this.groupBoxCondition_MKD.Controls.Add(this.textBox5);
            this.groupBoxCondition_MKD.Controls.Add(this.textBox4);
            this.groupBoxCondition_MKD.Controls.Add(this.textBox3);
            this.groupBoxCondition_MKD.Controls.Add(this.textBox2line);
            this.groupBoxCondition_MKD.Controls.Add(this.textBox1line);
            this.groupBoxCondition_MKD.Controls.Add(this.textBoxTask_MKD);
            this.groupBoxCondition_MKD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_MKD.Name = "groupBoxCondition_MKD";
            this.groupBoxCondition_MKD.Size = new System.Drawing.Size(200, 179);
            this.groupBoxCondition_MKD.TabIndex = 0;
            this.groupBoxCondition_MKD.TabStop = false;
            this.groupBoxCondition_MKD.Text = "Условие";
            // 
            // textBoxTask_MKD
            // 
            this.textBoxTask_MKD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MKD.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_MKD.Multiline = true;
            this.textBoxTask_MKD.Name = "textBoxTask_MKD";
            this.textBoxTask_MKD.ReadOnly = true;
            this.textBoxTask_MKD.Size = new System.Drawing.Size(187, 159);
            this.textBoxTask_MKD.TabIndex = 0;
            this.textBoxTask_MKD.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в четвертой строке на 0.";
            // 
            // textBox1line
            // 
            this.textBox1line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1line.Location = new System.Drawing.Point(6, 64);
            this.textBox1line.Name = "textBox1line";
            this.textBox1line.ReadOnly = true;
            this.textBox1line.Size = new System.Drawing.Size(100, 13);
            this.textBox1line.TabIndex = 1;
            this.textBox1line.Text = "-19 -19   1  18   7";
            // 
            // textBox2line
            // 
            this.textBox2line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2line.Location = new System.Drawing.Point(6, 83);
            this.textBox2line.Name = "textBox2line";
            this.textBox2line.ReadOnly = true;
            this.textBox2line.Size = new System.Drawing.Size(100, 13);
            this.textBox2line.TabIndex = 1;
            this.textBox2line.Text = "  5   3  -4  -6  -12";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "-15   6   2   2 -14";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(6, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = " -9 -10  15  -5  -6";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(7, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "-13 -15  -9   7   1";
            // 
            // groupBoxOutput_MKD
            // 
            this.groupBoxOutput_MKD.Controls.Add(this.dataGridViewResult_MKD);
            this.groupBoxOutput_MKD.Location = new System.Drawing.Point(219, 13);
            this.groupBoxOutput_MKD.Name = "groupBoxOutput_MKD";
            this.groupBoxOutput_MKD.Size = new System.Drawing.Size(173, 178);
            this.groupBoxOutput_MKD.TabIndex = 1;
            this.groupBoxOutput_MKD.TabStop = false;
            this.groupBoxOutput_MKD.Text = "Вывод данных";
            // 
            // dataGridViewResult_MKD
            // 
            this.dataGridViewResult_MKD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_MKD.ColumnHeadersVisible = false;
            this.dataGridViewResult_MKD.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewResult_MKD.Name = "dataGridViewResult_MKD";
            this.dataGridViewResult_MKD.RowHeadersVisible = false;
            this.dataGridViewResult_MKD.Size = new System.Drawing.Size(159, 146);
            this.dataGridViewResult_MKD.TabIndex = 0;
            // 
            // buttonDone_MKD
            // 
            this.buttonDone_MKD.Location = new System.Drawing.Point(276, 197);
            this.buttonDone_MKD.Name = "buttonDone_MKD";
            this.buttonDone_MKD.Size = new System.Drawing.Size(116, 23);
            this.buttonDone_MKD.TabIndex = 2;
            this.buttonDone_MKD.Text = "Выполнить";
            this.buttonDone_MKD.UseVisualStyleBackColor = true;
            this.buttonDone_MKD.Click += new System.EventHandler(this.buttonDone_MKD_Click);
            // 
            // buttonHelp_MKD
            // 
            this.buttonHelp_MKD.Location = new System.Drawing.Point(238, 197);
            this.buttonHelp_MKD.Name = "buttonHelp_MKD";
            this.buttonHelp_MKD.Size = new System.Drawing.Size(32, 23);
            this.buttonHelp_MKD.TabIndex = 3;
            this.buttonHelp_MKD.Text = "?";
            this.buttonHelp_MKD.UseVisualStyleBackColor = true;
            this.buttonHelp_MKD.Click += new System.EventHandler(this.buttonHelp_MKD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 233);
            this.Controls.Add(this.buttonHelp_MKD);
            this.Controls.Add(this.buttonDone_MKD);
            this.Controls.Add(this.groupBoxOutput_MKD);
            this.Controls.Add(this.groupBoxCondition_MKD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Мариненкова К. Д. ИСТНб23-1";
            this.groupBoxCondition_MKD.ResumeLayout(false);
            this.groupBoxCondition_MKD.PerformLayout();
            this.groupBoxOutput_MKD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MKD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_MKD;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2line;
        private System.Windows.Forms.TextBox textBox1line;
        private System.Windows.Forms.TextBox textBoxTask_MKD;
        private System.Windows.Forms.GroupBox groupBoxOutput_MKD;
        private System.Windows.Forms.DataGridView dataGridViewResult_MKD;
        private System.Windows.Forms.Button buttonDone_MKD;
        private System.Windows.Forms.Button buttonHelp_MKD;
    }
}

