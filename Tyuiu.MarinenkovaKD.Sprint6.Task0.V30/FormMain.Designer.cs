
using System;

namespace Tyuiu.MarinenkovaKD.Sprint6.Task0.V30
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
            this.pictureBoxCondition = new System.Windows.Forms.PictureBox();
            this.labelCondition_МКД = new System.Windows.Forms.Label();
            this.groupBoxInputData_МКД = new System.Windows.Forms.GroupBox();
            this.labelVarX_МКД = new System.Windows.Forms.Label();
            this.textBoxVarX_МКД = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_МКД = new System.Windows.Forms.GroupBox();
            this.labelOutPutData_МКД = new System.Windows.Forms.Label();
            this.textBoxOutPut_МКД = new System.Windows.Forms.TextBox();
            this.buttonDone_МКД = new System.Windows.Forms.Button();
            this.buttonHelp_МКД = new System.Windows.Forms.Button();
            this.groupBoxCondition_МКД.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).BeginInit();
            this.groupBoxInputData_МКД.SuspendLayout();
            this.groupBoxOutPutData_МКД.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_МКД
            // 
            this.groupBoxCondition_МКД.Controls.Add(this.pictureBoxCondition);
            this.groupBoxCondition_МКД.Controls.Add(this.labelCondition_МКД);
            this.groupBoxCondition_МКД.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_МКД.Name = "groupBoxCondition_МКД";
            this.groupBoxCondition_МКД.Size = new System.Drawing.Size(441, 71);
            this.groupBoxCondition_МКД.TabIndex = 0;
            this.groupBoxCondition_МКД.TabStop = false;
            this.groupBoxCondition_МКД.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            this.pictureBoxCondition.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition.Image")));
            this.pictureBoxCondition.Location = new System.Drawing.Point(204, 16);
            this.pictureBoxCondition.Name = "pictureBoxCondition";
            this.pictureBoxCondition.Size = new System.Drawing.Size(204, 49);
            this.pictureBoxCondition.TabIndex = 2;
            this.pictureBoxCondition.TabStop = false;
            // 
            // labelCondition_МКД
            // 
            this.labelCondition_МКД.AutoSize = true;
            this.labelCondition_МКД.Location = new System.Drawing.Point(7, 35);
            this.labelCondition_МКД.Name = "labelCondition_МКД";
            this.labelCondition_МКД.Size = new System.Drawing.Size(192, 13);
            this.labelCondition_МКД.TabIndex = 1;
            this.labelCondition_МКД.Text = "Вычислить выражение по формуле: ";
            // 
            // groupBoxInputData_МКД
            // 
            this.groupBoxInputData_МКД.Controls.Add(this.labelVarX_МКД);
            this.groupBoxInputData_МКД.Controls.Add(this.textBoxVarX_МКД);
            this.groupBoxInputData_МКД.Location = new System.Drawing.Point(12, 89);
            this.groupBoxInputData_МКД.Name = "groupBoxInputData_МКД";
            this.groupBoxInputData_МКД.Size = new System.Drawing.Size(119, 68);
            this.groupBoxInputData_МКД.TabIndex = 1;
            this.groupBoxInputData_МКД.TabStop = false;
            this.groupBoxInputData_МКД.Text = "Ввод";
            // 
            // labelVarX_МКД
            // 
            this.labelVarX_МКД.AutoSize = true;
            this.labelVarX_МКД.Location = new System.Drawing.Point(6, 20);
            this.labelVarX_МКД.Name = "labelVarX_МКД";
            this.labelVarX_МКД.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_МКД.TabIndex = 1;
            this.labelVarX_МКД.Text = "Переменная X:";
            // 
            // textBoxVarX_МКД
            // 
            this.textBoxVarX_МКД.Location = new System.Drawing.Point(6, 42);
            this.textBoxVarX_МКД.Name = "textBoxVarX_МКД";
            this.textBoxVarX_МКД.Size = new System.Drawing.Size(84, 20);
            this.textBoxVarX_МКД.TabIndex = 0;
            this.textBoxVarX_МКД.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_МКД_KeyPress);
            // 
            // groupBoxOutPutData_МКД
            // 
            this.groupBoxOutPutData_МКД.Controls.Add(this.labelOutPutData_МКД);
            this.groupBoxOutPutData_МКД.Controls.Add(this.textBoxOutPut_МКД);
            this.groupBoxOutPutData_МКД.Location = new System.Drawing.Point(137, 89);
            this.groupBoxOutPutData_МКД.Name = "groupBoxOutPutData_МКД";
            this.groupBoxOutPutData_МКД.Size = new System.Drawing.Size(130, 68);
            this.groupBoxOutPutData_МКД.TabIndex = 2;
            this.groupBoxOutPutData_МКД.TabStop = false;
            this.groupBoxOutPutData_МКД.Text = "Вывод";
            this.groupBoxOutPutData_МКД.Enter += new System.EventHandler(this.groupBoxOutPutData_Enter);
            // 
            // labelOutPutData_МКД
            // 
            this.labelOutPutData_МКД.AutoSize = true;
            this.labelOutPutData_МКД.Location = new System.Drawing.Point(7, 20);
            this.labelOutPutData_МКД.Name = "labelOutPutData_МКД";
            this.labelOutPutData_МКД.Size = new System.Drawing.Size(59, 13);
            this.labelOutPutData_МКД.TabIndex = 1;
            this.labelOutPutData_МКД.Text = "Результат";
            // 
            // textBoxOutPut_МКД
            // 
            this.textBoxOutPut_МКД.Location = new System.Drawing.Point(6, 42);
            this.textBoxOutPut_МКД.Name = "textBoxOutPut_МКД";
            this.textBoxOutPut_МКД.ReadOnly = true;
            this.textBoxOutPut_МКД.Size = new System.Drawing.Size(100, 20);
            this.textBoxOutPut_МКД.TabIndex = 0;
            this.textBoxOutPut_МКД.TextChanged += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonDone_МКД
            // 
            this.buttonDone_МКД.Location = new System.Drawing.Point(333, 95);
            this.buttonDone_МКД.Name = "buttonDone_МКД";
            this.buttonDone_МКД.Size = new System.Drawing.Size(120, 62);
            this.buttonDone_МКД.TabIndex = 3;
            this.buttonDone_МКД.Text = "Выполнить";
            this.buttonDone_МКД.UseVisualStyleBackColor = true;
            this.buttonDone_МКД.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp_МКД
            // 
            this.buttonHelp_МКД.Location = new System.Drawing.Point(289, 109);
            this.buttonHelp_МКД.Name = "buttonHelp_МКД";
            this.buttonHelp_МКД.Size = new System.Drawing.Size(38, 36);
            this.buttonHelp_МКД.TabIndex = 4;
            this.buttonHelp_МКД.Text = "?";
            this.buttonHelp_МКД.UseVisualStyleBackColor = true;
            this.buttonHelp_МКД.Click += new System.EventHandler(this.buttonHelp_МКД_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 171);
            this.Controls.Add(this.buttonHelp_МКД);
            this.Controls.Add(this.buttonDone_МКД);
            this.Controls.Add(this.groupBoxOutPutData_МКД);
            this.Controls.Add(this.groupBoxInputData_МКД);
            this.Controls.Add(this.groupBoxCondition_МКД);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 30 | Мариненкова К. Д.  ИСТНб-23-1";
            this.groupBoxCondition_МКД.ResumeLayout(false);
            this.groupBoxCondition_МКД.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).EndInit();
            this.groupBoxInputData_МКД.ResumeLayout(false);
            this.groupBoxInputData_МКД.PerformLayout();
            this.groupBoxOutPutData_МКД.ResumeLayout(false);
            this.groupBoxOutPutData_МКД.PerformLayout();
            this.ResumeLayout(false);

        }

        private void groupBoxOutPutData_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_МКД;
        private System.Windows.Forms.Label labelCondition_МКД;
        private System.Windows.Forms.GroupBox groupBoxInputData_МКД;
        private System.Windows.Forms.Label labelVarX_МКД;
        private System.Windows.Forms.TextBox textBoxVarX_МКД;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_МКД;
        private System.Windows.Forms.Label labelOutPutData_МКД;
        private System.Windows.Forms.TextBox textBoxOutPut_МКД;
        private System.Windows.Forms.Button buttonDone_МКД;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.Button buttonHelp_МКД;
    }
}

