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
            this.userRegBt = new System.Windows.Forms.Button();
            this.userNameRegBox = new System.Windows.Forms.TextBox();
            this.userAdressRegBox = new System.Windows.Forms.TextBox();
            this.userPhoneRegBox = new System.Windows.Forms.TextBox();
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
            // userRegBt
            // 
            this.userRegBt.Location = new System.Drawing.Point(12, 229);
            this.userRegBt.Name = "userRegBt";
            this.userRegBt.Size = new System.Drawing.Size(183, 23);
            this.userRegBt.TabIndex = 3;
            this.userRegBt.Text = "Зарегестрироваться";
            this.userRegBt.UseVisualStyleBackColor = true;
            this.userRegBt.Click += new System.EventHandler(this.userRegBt_Click);
            // 
            // userNameRegBox
            // 
            this.userNameRegBox.Location = new System.Drawing.Point(12, 144);
            this.userNameRegBox.Name = "userNameRegBox";
            this.userNameRegBox.Size = new System.Drawing.Size(183, 22);
            this.userNameRegBox.TabIndex = 4;
            this.userNameRegBox.Text = "Введите своё имя";
            this.userNameRegBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userNameRegBox_MouseClick);
            // 
            // userAdressRegBox
            // 
            this.userAdressRegBox.Location = new System.Drawing.Point(12, 172);
            this.userAdressRegBox.Name = "userAdressRegBox";
            this.userAdressRegBox.Size = new System.Drawing.Size(183, 22);
            this.userAdressRegBox.TabIndex = 5;
            this.userAdressRegBox.Text = "Ваш адрес";
            this.userAdressRegBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userAdressRegBox_MouseClick);
            // 
            // userPhoneRegBox
            // 
            this.userPhoneRegBox.Location = new System.Drawing.Point(12, 201);
            this.userPhoneRegBox.Name = "userPhoneRegBox";
            this.userPhoneRegBox.Size = new System.Drawing.Size(183, 22);
            this.userPhoneRegBox.TabIndex = 6;
            this.userPhoneRegBox.Text = "Номер телефона";
            this.userPhoneRegBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userPhoneRegBox_MouseClick);
            // 
            // ClientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 281);
            this.Controls.Add(this.userPhoneRegBox);
            this.Controls.Add(this.userAdressRegBox);
            this.Controls.Add(this.userNameRegBox);
            this.Controls.Add(this.userRegBt);
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
        private System.Windows.Forms.Button userRegBt;
        private System.Windows.Forms.TextBox userNameRegBox;
        private System.Windows.Forms.TextBox userAdressRegBox;
        private System.Windows.Forms.TextBox userPhoneRegBox;
    }
}