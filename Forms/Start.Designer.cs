namespace BD
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientbt = new System.Windows.Forms.Button();
            this.adminbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientbt
            // 
            this.clientbt.Location = new System.Drawing.Point(200, 188);
            this.clientbt.Name = "clientbt";
            this.clientbt.Size = new System.Drawing.Size(263, 153);
            this.clientbt.TabIndex = 0;
            this.clientbt.Text = "Приложение клиента";
            this.clientbt.UseVisualStyleBackColor = true;
            this.clientbt.Click += new System.EventHandler(this.clientbt_Click);
            // 
            // adminbt
            // 
            this.adminbt.Location = new System.Drawing.Point(523, 188);
            this.adminbt.Name = "adminbt";
            this.adminbt.Size = new System.Drawing.Size(259, 153);
            this.adminbt.TabIndex = 1;
            this.adminbt.Text = "Приложение админа";
            this.adminbt.UseVisualStyleBackColor = true;
            this.adminbt.Click += new System.EventHandler(this.adminbt_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.adminbt);
            this.Controls.Add(this.clientbt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientbt;
        private System.Windows.Forms.Button adminbt;
    }
}

