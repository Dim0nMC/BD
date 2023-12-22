namespace BD.Forms
{
    partial class OrderChange
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
            this.idTb = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(136, 9);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(281, 22);
            this.idTb.TabIndex = 0;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Подтверждено",
            "Выполняется",
            "Отправляется",
            "Ожидает на пункте выдачи",
            "Завершено",
            "Отклонено"});
            this.statusBox.Location = new System.Drawing.Point(175, 41);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(144, 24);
            this.statusBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер заказа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Изменить статус на:";
            // 
            // confirmBt
            // 
            this.confirmBt.Location = new System.Drawing.Point(325, 41);
            this.confirmBt.Name = "confirmBt";
            this.confirmBt.Size = new System.Drawing.Size(92, 23);
            this.confirmBt.TabIndex = 4;
            this.confirmBt.Text = "Принять";
            this.confirmBt.UseVisualStyleBackColor = true;
            this.confirmBt.Click += new System.EventHandler(this.confirmBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(16, 104);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(135, 23);
            this.deleteBt.TabIndex = 5;
            this.deleteBt.Text = "Удалить заказ";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // OrderChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 139);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.confirmBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.idTb);
            this.Name = "OrderChange";
            this.Text = "OrderChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmBt;
        private System.Windows.Forms.Button deleteBt;
    }
}