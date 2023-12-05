namespace BD
{
    partial class Client
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
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderListGP = new System.Windows.Forms.GroupBox();
            this.doOrderGP = new System.Windows.Forms.GroupBox();
            this.modelListBox = new System.Windows.Forms.ListBox();
            this.developerListBox = new System.Windows.Forms.ListBox();
            this.kitListBox = new System.Windows.Forms.ListBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reloadBt = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.orderListGP.SuspendLayout();
            this.doOrderGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(114, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(197, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "Ошибка имени пользователя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пользователь:";
            // 
            // orderListGP
            // 
            this.orderListGP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderListGP.Controls.Add(this.orderList);
            this.orderListGP.Controls.Add(this.reloadBt);
            this.orderListGP.Location = new System.Drawing.Point(6, 58);
            this.orderListGP.Name = "orderListGP";
            this.orderListGP.Size = new System.Drawing.Size(852, 459);
            this.orderListGP.TabIndex = 2;
            this.orderListGP.TabStop = false;
            this.orderListGP.Text = "Список Заказов";
            // 
            // doOrderGP
            // 
            this.doOrderGP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doOrderGP.Controls.Add(this.button1);
            this.doOrderGP.Controls.Add(this.label6);
            this.doOrderGP.Controls.Add(this.label5);
            this.doOrderGP.Controls.Add(this.label4);
            this.doOrderGP.Controls.Add(this.label3);
            this.doOrderGP.Controls.Add(this.label2);
            this.doOrderGP.Controls.Add(this.priceBox);
            this.doOrderGP.Controls.Add(this.quantityBox);
            this.doOrderGP.Controls.Add(this.kitListBox);
            this.doOrderGP.Controls.Add(this.developerListBox);
            this.doOrderGP.Controls.Add(this.modelListBox);
            this.doOrderGP.Location = new System.Drawing.Point(864, 58);
            this.doOrderGP.Name = "doOrderGP";
            this.doOrderGP.Size = new System.Drawing.Size(464, 459);
            this.doOrderGP.TabIndex = 3;
            this.doOrderGP.TabStop = false;
            this.doOrderGP.Text = "Новый заказ";
            // 
            // modelListBox
            // 
            this.modelListBox.FormattingEnabled = true;
            this.modelListBox.ItemHeight = 16;
            this.modelListBox.Location = new System.Drawing.Point(217, 44);
            this.modelListBox.Name = "modelListBox";
            this.modelListBox.Size = new System.Drawing.Size(159, 36);
            this.modelListBox.TabIndex = 0;
            // 
            // developerListBox
            // 
            this.developerListBox.FormattingEnabled = true;
            this.developerListBox.ItemHeight = 16;
            this.developerListBox.Location = new System.Drawing.Point(217, 113);
            this.developerListBox.Name = "developerListBox";
            this.developerListBox.Size = new System.Drawing.Size(159, 36);
            this.developerListBox.TabIndex = 1;
            // 
            // kitListBox
            // 
            this.kitListBox.FormattingEnabled = true;
            this.kitListBox.ItemHeight = 16;
            this.kitListBox.Location = new System.Drawing.Point(217, 183);
            this.kitListBox.Name = "kitListBox";
            this.kitListBox.Size = new System.Drawing.Size(159, 36);
            this.kitListBox.TabIndex = 2;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(217, 256);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 22);
            this.quantityBox.TabIndex = 3;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(217, 305);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите модель медели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите изготовителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите набор материалов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во экземпляров";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Итоговая стоимость";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // reloadBt
            // 
            this.reloadBt.Location = new System.Drawing.Point(760, 15);
            this.reloadBt.Name = "reloadBt";
            this.reloadBt.Size = new System.Drawing.Size(86, 23);
            this.reloadBt.TabIndex = 0;
            this.reloadBt.Text = "Обновить";
            this.reloadBt.UseVisualStyleBackColor = true;
            // 
            // orderList
            // 
            this.orderList.HideSelection = false;
            this.orderList.Location = new System.Drawing.Point(6, 44);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(840, 409);
            this.orderList.TabIndex = 1;
            this.orderList.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Баланс:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(68, 25);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(14, 16);
            this.balanceLabel.TabIndex = 5;
            this.balanceLabel.Text = "0";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 529);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.doOrderGP);
            this.Controls.Add(this.orderListGP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.orderListGP.ResumeLayout(false);
            this.doOrderGP.ResumeLayout(false);
            this.doOrderGP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox orderListGP;
        private System.Windows.Forms.GroupBox doOrderGP;
        private System.Windows.Forms.ListBox developerListBox;
        private System.Windows.Forms.ListBox modelListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.ListBox kitListBox;
        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.Button reloadBt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label balanceLabel;
    }
}