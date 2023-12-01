
using System;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task1.V24
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
            this.groupBoxCondition_МКД = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_МКД = new System.Windows.Forms.PictureBox();
            this.lableCondition_МКД = new System.Windows.Forms.Label();
            this.groupBoxInput_МКД = new System.Windows.Forms.GroupBox();
            this.labelEnd_МКД = new System.Windows.Forms.Label();
            this.labelStart_МКД = new System.Windows.Forms.Label();
            this.textBoxEnd_МКД = new System.Windows.Forms.TextBox();
            this.textBoxStart_МКД = new System.Windows.Forms.TextBox();
            this.buttonRef_МКД = new System.Windows.Forms.Button();
            this.buttonResult_МКД = new System.Windows.Forms.Button();
            this.groupBoxOutPut_МКД = new System.Windows.Forms.GroupBox();
            this.textBoxResult_МКД = new System.Windows.Forms.TextBox();
            this.labelResult_МКД = new System.Windows.Forms.Label();
            this.groupBoxCondition_МКД.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_МКД)).BeginInit();
            this.groupBoxInput_МКД.SuspendLayout();
            this.groupBoxOutPut_МКД.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_МКД
            // 
            this.groupBoxCondition_МКД.Controls.Add(this.pictureBoxFormula_МКД);
            this.groupBoxCondition_МКД.Controls.Add(this.lableCondition_МКД);
            this.groupBoxCondition_МКД.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_МКД.Name = "groupBoxCondition_МКД";
            this.groupBoxCondition_МКД.Size = new System.Drawing.Size(367, 199);
            this.groupBoxCondition_МКД.TabIndex = 0;
            this.groupBoxCondition_МКД.TabStop = false;
            this.groupBoxCondition_МКД.Text = "Условие";
            // 
            // pictureBoxFormula_МКД
            // 
            this.pictureBoxFormula_МКД.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_МКД.Image")));
            this.pictureBoxFormula_МКД.Location = new System.Drawing.Point(10, 36);
            this.pictureBoxFormula_МКД.Name = "pictureBoxFormula_МКД";
            this.pictureBoxFormula_МКД.Size = new System.Drawing.Size(249, 34);
            this.pictureBoxFormula_МКД.TabIndex = 1;
            this.pictureBoxFormula_МКД.TabStop = false;
            // 
            // lableCondition_МКД
            // 
            this.lableCondition_МКД.AutoSize = true;
            this.lableCondition_МКД.Location = new System.Drawing.Point(7, 20);
            this.lableCondition_МКД.Name = "lableCondition_МКД";
            this.lableCondition_МКД.Size = new System.Drawing.Size(350, 13);
            this.lableCondition_МКД.TabIndex = 0;
            this.lableCondition_МКД.Text = "Написать программу, которая выводит таблицу значений функции:";
            // 
            // groupBoxInput_МКД
            // 
            this.groupBoxInput_МКД.Controls.Add(this.labelEnd_МКД);
            this.groupBoxInput_МКД.Controls.Add(this.labelStart_МКД);
            this.groupBoxInput_МКД.Controls.Add(this.textBoxEnd_МКД);
            this.groupBoxInput_МКД.Controls.Add(this.textBoxStart_МКД);
            this.groupBoxInput_МКД.Location = new System.Drawing.Point(12, 217);
            this.groupBoxInput_МКД.Name = "groupBoxInput_МКД";
            this.groupBoxInput_МКД.Size = new System.Drawing.Size(165, 58);
            this.groupBoxInput_МКД.TabIndex = 1;
            this.groupBoxInput_МКД.TabStop = false;
            this.groupBoxInput_МКД.Text = "Ввод данных";
            // 
            // labelEnd_МКД
            // 
            this.labelEnd_МКД.AutoSize = true;
            this.labelEnd_МКД.Location = new System.Drawing.Point(94, 16);
            this.labelEnd_МКД.Name = "labelEnd_МКД";
            this.labelEnd_МКД.Size = new System.Drawing.Size(41, 13);
            this.labelEnd_МКД.TabIndex = 3;
            this.labelEnd_МКД.Text = "Конец:";
            // 
            // labelStart_МКД
            // 
            this.labelStart_МКД.AutoSize = true;
            this.labelStart_МКД.Location = new System.Drawing.Point(7, 16);
            this.labelStart_МКД.Name = "labelStart_МКД";
            this.labelStart_МКД.Size = new System.Drawing.Size(39, 13);
            this.labelStart_МКД.TabIndex = 2;
            this.labelStart_МКД.Text = "Старт:";
            this.labelStart_МКД.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEnd_МКД
            // 
            this.textBoxEnd_МКД.Location = new System.Drawing.Point(97, 32);
            this.textBoxEnd_МКД.Name = "textBoxEnd_МКД";
            this.textBoxEnd_МКД.Size = new System.Drawing.Size(59, 20);
            this.textBoxEnd_МКД.TabIndex = 1;
            this.textBoxEnd_МКД.Text = "5";
            // 
            // textBoxStart_МКД
            // 
            this.textBoxStart_МКД.Location = new System.Drawing.Point(10, 32);
            this.textBoxStart_МКД.Name = "textBoxStart_МКД";
            this.textBoxStart_МКД.Size = new System.Drawing.Size(57, 20);
            this.textBoxStart_МКД.TabIndex = 0;
            this.textBoxStart_МКД.Text = "-5";
            // 
            // buttonRef_МКД
            // 
            this.buttonRef_МКД.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRef_МКД.Location = new System.Drawing.Point(183, 227);
            this.buttonRef_МКД.Name = "buttonRef_МКД";
            this.buttonRef_МКД.Size = new System.Drawing.Size(63, 42);
            this.buttonRef_МКД.TabIndex = 2;
            this.buttonRef_МКД.Text = "Справка";
            this.buttonRef_МКД.UseVisualStyleBackColor = false;
            this.buttonRef_МКД.Click += new System.EventHandler(this.buttonRef_МКД_Click);
            // 
            // buttonResult_МКД
            // 
            this.buttonResult_МКД.BackColor = System.Drawing.Color.Green;
            this.buttonResult_МКД.Location = new System.Drawing.Point(252, 227);
            this.buttonResult_МКД.Name = "buttonResult_МКД";
            this.buttonResult_МКД.Size = new System.Drawing.Size(127, 42);
            this.buttonResult_МКД.TabIndex = 3;
            this.buttonResult_МКД.Text = "Выполнить";
            this.buttonResult_МКД.UseVisualStyleBackColor = false;
            this.buttonResult_МКД.Click += new System.EventHandler(this.buttonResult_МКД_Click);
            // 
            // groupBoxOutPut_МКД
            // 
            this.groupBoxOutPut_МКД.Controls.Add(this.textBoxResult_МКД);
            this.groupBoxOutPut_МКД.Controls.Add(this.labelResult_МКД);
            this.groupBoxOutPut_МКД.Location = new System.Drawing.Point(386, 13);
            this.groupBoxOutPut_МКД.Name = "groupBoxOutPut_МКД";
            this.groupBoxOutPut_МКД.Size = new System.Drawing.Size(197, 262);
            this.groupBoxOutPut_МКД.TabIndex = 4;
            this.groupBoxOutPut_МКД.TabStop = false;
            this.groupBoxOutPut_МКД.Text = "Вывод данных";
            // 
            // textBoxResult_МКД
            // 
            this.textBoxResult_МКД.Location = new System.Drawing.Point(10, 35);
            this.textBoxResult_МКД.Multiline = true;
            this.textBoxResult_МКД.Name = "textBoxResult_МКД";
            this.textBoxResult_МКД.ReadOnly = true;
            this.textBoxResult_МКД.Size = new System.Drawing.Size(181, 221);
            this.textBoxResult_МКД.TabIndex = 1;
            // 
            // labelResult_МКД
            // 
            this.labelResult_МКД.AutoSize = true;
            this.labelResult_МКД.Location = new System.Drawing.Point(7, 18);
            this.labelResult_МКД.Name = "labelResult_МКД";
            this.labelResult_МКД.Size = new System.Drawing.Size(62, 13);
            this.labelResult_МКД.TabIndex = 0;
            this.labelResult_МКД.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 298);
            this.Controls.Add(this.groupBoxOutPut_МКД);
            this.Controls.Add(this.buttonResult_МКД);
            this.Controls.Add(this.buttonRef_МКД);
            this.Controls.Add(this.groupBoxInput_МКД);
            this.Controls.Add(this.groupBoxCondition_МКД);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 24 | Мариненкова К. Д. ИСТНб-23-1";
            this.groupBoxCondition_МКД.ResumeLayout(false);
            this.groupBoxCondition_МКД.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_МКД)).EndInit();
            this.groupBoxInput_МКД.ResumeLayout(false);
            this.groupBoxInput_МКД.PerformLayout();
            this.groupBoxOutPut_МКД.ResumeLayout(false);
            this.groupBoxOutPut_МКД.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_МКД;
        private System.Windows.Forms.PictureBox pictureBoxFormula_МКД;
        private System.Windows.Forms.Label lableCondition_МКД;
        private System.Windows.Forms.GroupBox groupBoxInput_МКД;
        private System.Windows.Forms.Label labelEnd_МКД;
        private System.Windows.Forms.Label labelStart_МКД;
        private System.Windows.Forms.TextBox textBoxEnd_МКД;
        private System.Windows.Forms.TextBox textBoxStart_МКД;
        private System.Windows.Forms.Button buttonRef_МКД;
        private System.Windows.Forms.Button buttonResult_МКД;
        private System.Windows.Forms.GroupBox groupBoxOutPut_МКД;
        private System.Windows.Forms.TextBox textBoxResult_МКД;
        private System.Windows.Forms.Label labelResult_МКД;
    }
}

