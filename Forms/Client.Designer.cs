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
            this.reloadBt = new System.Windows.Forms.Button();
            this.doOrderGP = new System.Windows.Forms.GroupBox();
            this.kitComboBox = new System.Windows.Forms.ComboBox();
            this.developerComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.confirmBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.buyBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderListGP.SuspendLayout();
            this.doOrderGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.orderListGP.Controls.Add(this.dataGridView1);
            this.orderListGP.Controls.Add(this.reloadBt);
            this.orderListGP.Location = new System.Drawing.Point(6, 73);
            this.orderListGP.Name = "orderListGP";
            this.orderListGP.Size = new System.Drawing.Size(852, 456);
            this.orderListGP.TabIndex = 2;
            this.orderListGP.TabStop = false;
            this.orderListGP.Text = "Список Заказов";
            // 
            // reloadBt
            // 
            this.reloadBt.Location = new System.Drawing.Point(760, 6);
            this.reloadBt.Name = "reloadBt";
            this.reloadBt.Size = new System.Drawing.Size(86, 23);
            this.reloadBt.TabIndex = 0;
            this.reloadBt.Text = "Обновить";
            this.reloadBt.UseVisualStyleBackColor = true;
            this.reloadBt.Click += new System.EventHandler(this.reloadBt_Click);
            // 
            // doOrderGP
            // 
            this.doOrderGP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doOrderGP.Controls.Add(this.kitComboBox);
            this.doOrderGP.Controls.Add(this.developerComboBox);
            this.doOrderGP.Controls.Add(this.modelComboBox);
            this.doOrderGP.Controls.Add(this.confirmBt);
            this.doOrderGP.Controls.Add(this.label6);
            this.doOrderGP.Controls.Add(this.label5);
            this.doOrderGP.Controls.Add(this.label4);
            this.doOrderGP.Controls.Add(this.label3);
            this.doOrderGP.Controls.Add(this.label2);
            this.doOrderGP.Controls.Add(this.priceBox);
            this.doOrderGP.Controls.Add(this.quantityBox);
            this.doOrderGP.Location = new System.Drawing.Point(864, 73);
            this.doOrderGP.Name = "doOrderGP";
            this.doOrderGP.Size = new System.Drawing.Size(464, 456);
            this.doOrderGP.TabIndex = 3;
            this.doOrderGP.TabStop = false;
            this.doOrderGP.Text = "Новый заказ";
            // 
            // kitComboBox
            // 
            this.kitComboBox.FormattingEnabled = true;
            this.kitComboBox.Location = new System.Drawing.Point(217, 183);
            this.kitComboBox.Name = "kitComboBox";
            this.kitComboBox.Size = new System.Drawing.Size(241, 24);
            this.kitComboBox.TabIndex = 13;
            this.kitComboBox.TextChanged += new System.EventHandler(this.kitComboBox_TextChanged);
            // 
            // developerComboBox
            // 
            this.developerComboBox.FormattingEnabled = true;
            this.developerComboBox.Location = new System.Drawing.Point(217, 113);
            this.developerComboBox.Name = "developerComboBox";
            this.developerComboBox.Size = new System.Drawing.Size(241, 24);
            this.developerComboBox.TabIndex = 12;
            this.developerComboBox.TextChanged += new System.EventHandler(this.developerComboBox_TextChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(217, 44);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(241, 24);
            this.modelComboBox.TabIndex = 11;
            this.modelComboBox.TextChanged += new System.EventHandler(this.modelComboBox_TextChanged);
            // 
            // confirmBt
            // 
            this.confirmBt.Location = new System.Drawing.Point(13, 364);
            this.confirmBt.Name = "confirmBt";
            this.confirmBt.Size = new System.Drawing.Size(134, 44);
            this.confirmBt.TabIndex = 10;
            this.confirmBt.Text = "Оформить";
            this.confirmBt.UseVisualStyleBackColor = true;
            this.confirmBt.Click += new System.EventHandler(this.confirmBt_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во экземпляров";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите изготовителя";
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
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(217, 305);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 4;
            this.priceBox.Text = "0";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(217, 256);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.ReadOnly = true;
            this.quantityBox.Size = new System.Drawing.Size(100, 22);
            this.quantityBox.TabIndex = 3;
            this.quantityBox.TextChanged += new System.EventHandler(this.quantityBox_TextChanged);
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
            // buyBt
            // 
            this.buyBt.Location = new System.Drawing.Point(6, 44);
            this.buyBt.Name = "buyBt";
            this.buyBt.Size = new System.Drawing.Size(103, 23);
            this.buyBt.TabIndex = 6;
            this.buyBt.Text = "Оплатить";
            this.buyBt.UseVisualStyleBackColor = true;
            this.buyBt.Click += new System.EventHandler(this.buyBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 415);
            this.dataGridView1.TabIndex = 2;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 541);
            this.Controls.Add(this.buyBt);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox orderListGP;
        private System.Windows.Forms.GroupBox doOrderGP;
        private System.Windows.Forms.Button confirmBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Button reloadBt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.ComboBox kitComboBox;
        private System.Windows.Forms.ComboBox developerComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button buyBt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}