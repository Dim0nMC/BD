namespace BD
{
    partial class ClientLogin
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
            this.clientLoginBox = new System.Windows.Forms.TextBox();
            this.clientLoginBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientRegBt = new System.Windows.Forms.Button();
            this.clientNameRegBox = new System.Windows.Forms.TextBox();
            this.clientAdressRegBox = new System.Windows.Forms.TextBox();
            this.clientPhoneRegBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clientLoginBox
            // 
            this.clientLoginBox.Location = new System.Drawing.Point(12, 67);
            this.clientLoginBox.Name = "clientLoginBox";
            this.clientLoginBox.Size = new System.Drawing.Size(183, 22);
            this.clientLoginBox.TabIndex = 0;
            this.clientLoginBox.Text = "Введите своё имя";
            this.clientLoginBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientLoginBox_MouseClick);
            // 
            // clientLoginBt
            // 
            this.clientLoginBt.Location = new System.Drawing.Point(12, 95);
            this.clientLoginBt.Name = "clientLoginBt";
            this.clientLoginBt.Size = new System.Drawing.Size(75, 23);
            this.clientLoginBt.TabIndex = 1;
            this.clientLoginBt.Text = "Войти";
            this.clientLoginBt.UseVisualStyleBackColor = true;
            this.clientLoginBt.Click += new System.EventHandler(this.clientLoginBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // clientRegBt
            // 
            this.clientRegBt.Location = new System.Drawing.Point(12, 229);
            this.clientRegBt.Name = "clientRegBt";
            this.clientRegBt.Size = new System.Drawing.Size(183, 23);
            this.clientRegBt.TabIndex = 3;
            this.clientRegBt.Text = "Зарегестрироваться";
            this.clientRegBt.UseVisualStyleBackColor = true;
            this.clientRegBt.Click += new System.EventHandler(this.clientRegBt_Click);
            // 
            // clientNameRegBox
            // 
            this.clientNameRegBox.Location = new System.Drawing.Point(12, 144);
            this.clientNameRegBox.Name = "clientNameRegBox";
            this.clientNameRegBox.Size = new System.Drawing.Size(183, 22);
            this.clientNameRegBox.TabIndex = 4;
            this.clientNameRegBox.Text = "Введите своё имя";
            this.clientNameRegBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientNameRegBox_MouseClick);
            // 
            // clientAdressRegBox
            // 
            this.clientAdressRegBox.Location = new System.Drawing.Point(12, 172);
            this.clientAdressRegBox.Name = "clientAdressRegBox";
            this.clientAdressRegBox.Size = new System.Drawing.Size(183, 22);
            this.clientAdressRegBox.TabIndex = 5;
            this.clientAdressRegBox.Text = "Ваш адрес";
            this.clientAdressRegBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientAdressRegBox_MouseClick);
            // 
            // clientPhoneRegBox
            // 
            this.clientPhoneRegBox.Location = new System.Drawing.Point(12, 201);
            this.clientPhoneRegBox.Name = "clientPhoneRegBox";
            this.clientPhoneRegBox.Size = new System.Drawing.Size(183, 22);
            this.clientPhoneRegBox.TabIndex = 6;
            this.clientPhoneRegBox.Text = "Номер телефона";
            this.clientPhoneRegBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientPhoneRegBox_MouseClick);
            // 
            // ClientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 281);
            this.Controls.Add(this.clientPhoneRegBox);
            this.Controls.Add(this.clientAdressRegBox);
            this.Controls.Add(this.clientNameRegBox);
            this.Controls.Add(this.clientRegBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientLoginBt);
            this.Controls.Add(this.clientLoginBox);
            this.Name = "ClientLogin";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientLoginBox;
        private System.Windows.Forms.Button clientLoginBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clientRegBt;
        private System.Windows.Forms.TextBox clientNameRegBox;
        private System.Windows.Forms.TextBox clientAdressRegBox;
        private System.Windows.Forms.TextBox clientPhoneRegBox;
    }
}