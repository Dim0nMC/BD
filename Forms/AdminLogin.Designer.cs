﻿namespace BD
{
    partial class AdminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminLoginBox = new System.Windows.Forms.TextBox();
            this.adminLoginBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // adminLoginBox
            // 
            this.adminLoginBox.Location = new System.Drawing.Point(13, 71);
            this.adminLoginBox.Name = "adminLoginBox";
            this.adminLoginBox.Size = new System.Drawing.Size(190, 22);
            this.adminLoginBox.TabIndex = 1;
            this.adminLoginBox.Text = "Введите своё имя";
            this.adminLoginBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adminLoginBox_MouseClick);
            // 
            // adminLoginBt
            // 
            this.adminLoginBt.Location = new System.Drawing.Point(127, 100);
            this.adminLoginBt.Name = "adminLoginBt";
            this.adminLoginBt.Size = new System.Drawing.Size(75, 23);
            this.adminLoginBt.TabIndex = 2;
            this.adminLoginBt.Text = "Войти";
            this.adminLoginBt.UseVisualStyleBackColor = true;
            this.adminLoginBt.Click += new System.EventHandler(this.adminLoginBt_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 137);
            this.Controls.Add(this.adminLoginBt);
            this.Controls.Add(this.adminLoginBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminLoginBox;
        private System.Windows.Forms.Button adminLoginBt;
    }
}