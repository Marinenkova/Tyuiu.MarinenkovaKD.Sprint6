
namespace Tyuiu.MarinenkovaKD.Sprint6.Task6.V22
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxInfo_MKD = new System.Windows.Forms.TextBox();
            this.buttonOK_MKD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo_MKD
            // 
            this.textBoxInfo_MKD.Location = new System.Drawing.Point(12, 12);
            this.textBoxInfo_MKD.Multiline = true;
            this.textBoxInfo_MKD.Name = "textBoxInfo_MKD";
            this.textBoxInfo_MKD.ReadOnly = true;
            this.textBoxInfo_MKD.Size = new System.Drawing.Size(385, 97);
            this.textBoxInfo_MKD.TabIndex = 0;
            this.textBoxInfo_MKD.Text = resources.GetString("textBoxInfo_MKD.Text");
            // 
            // buttonOK_MKD
            // 
            this.buttonOK_MKD.Location = new System.Drawing.Point(322, 115);
            this.buttonOK_MKD.Name = "buttonOK_MKD";
            this.buttonOK_MKD.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_MKD.TabIndex = 1;
            this.buttonOK_MKD.Text = "ОК";
            this.buttonOK_MKD.UseVisualStyleBackColor = true;
            this.buttonOK_MKD.Click += new System.EventHandler(this.buttonOK_MKD_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 149);
            this.Controls.Add(this.buttonOK_MKD);
            this.Controls.Add(this.textBoxInfo_MKD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_MKD;
        private System.Windows.Forms.Button buttonOK_MKD;
    }
}