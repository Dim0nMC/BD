namespace BD.Forms
{
    partial class Admin
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
            this.Adminname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reloadBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.top1Label = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.top2Label = new System.Windows.Forms.Label();
            this.valLabel = new System.Windows.Forms.Label();
            this.ordersChangeBt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.doOrderGP = new System.Windows.Forms.GroupBox();
            this.developerComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.confirmBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.addModelBt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addModelTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.doOrderGP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Администратор:";
            // 
            // Adminname
            // 
            this.Adminname.AutoSize = true;
            this.Adminname.Location = new System.Drawing.Point(120, 0);
            this.Adminname.Name = "Adminname";
            this.Adminname.Size = new System.Drawing.Size(214, 16);
            this.Adminname.TabIndex = 1;
            this.Adminname.Text = "Ошибка имени администратора";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.reloadBt);
            this.groupBox1.Controls.Add(this.ordersChangeBt);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 340);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список заказов на изготовление";
            // 
            // reloadBt
            // 
            this.reloadBt.Location = new System.Drawing.Point(16, 21);
            this.reloadBt.Name = "reloadBt";
            this.reloadBt.Size = new System.Drawing.Size(85, 23);
            this.reloadBt.TabIndex = 0;
            this.reloadBt.Text = "Обновить";
            this.reloadBt.UseVisualStyleBackColor = true;
            this.reloadBt.Click += new System.EventHandler(this.reloadBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Самый популярный заказ:";
            // 
            // top1Label
            // 
            this.top1Label.AutoSize = true;
            this.top1Label.Location = new System.Drawing.Point(204, 34);
            this.top1Label.Name = "top1Label";
            this.top1Label.Size = new System.Drawing.Size(37, 16);
            this.top1Label.TabIndex = 4;
            this.top1Label.Text = "none";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(248, 34);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(14, 16);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "0";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(418, 34);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(184, 16);
            this.Label.TabIndex = 6;
            this.Label.Text = "Самая прибыльная модель:";
            // 
            // top2Label
            // 
            this.top2Label.AutoSize = true;
            this.top2Label.Location = new System.Drawing.Point(608, 34);
            this.top2Label.Name = "top2Label";
            this.top2Label.Size = new System.Drawing.Size(37, 16);
            this.top2Label.TabIndex = 7;
            this.top2Label.Text = "none";
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.Location = new System.Drawing.Point(651, 34);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(14, 16);
            this.valLabel.TabIndex = 8;
            this.valLabel.Text = "0";
            // 
            // ordersChangeBt
            // 
            this.ordersChangeBt.Location = new System.Drawing.Point(724, 6);
            this.ordersChangeBt.Name = "ordersChangeBt";
            this.ordersChangeBt.Size = new System.Drawing.Size(156, 38);
            this.ordersChangeBt.TabIndex = 9;
            this.ordersChangeBt.Text = "Изменить заказы";
            this.ordersChangeBt.UseVisualStyleBackColor = true;
            this.ordersChangeBt.Click += new System.EventHandler(this.ordersChangeBt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 340);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список заказов на поставку";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(873, 284);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doOrderGP
            // 
            this.doOrderGP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doOrderGP.Controls.Add(this.developerComboBox);
            this.doOrderGP.Controls.Add(this.materialComboBox);
            this.doOrderGP.Controls.Add(this.confirmBt);
            this.doOrderGP.Controls.Add(this.label6);
            this.doOrderGP.Controls.Add(this.label5);
            this.doOrderGP.Controls.Add(this.label3);
            this.doOrderGP.Controls.Add(this.label7);
            this.doOrderGP.Controls.Add(this.priceBox);
            this.doOrderGP.Controls.Add(this.quantityBox);
            this.doOrderGP.Location = new System.Drawing.Point(904, 434);
            this.doOrderGP.Name = "doOrderGP";
            this.doOrderGP.Size = new System.Drawing.Size(464, 340);
            this.doOrderGP.TabIndex = 11;
            this.doOrderGP.TabStop = false;
            this.doOrderGP.Text = "Новый заказ";
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
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(217, 44);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(241, 24);
            this.materialComboBox.TabIndex = 11;
            this.materialComboBox.TextChanged += new System.EventHandler(this.materialComboBox_TextChanged);
            // 
            // confirmBt
            // 
            this.confirmBt.Location = new System.Drawing.Point(9, 280);
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
            this.label6.Location = new System.Drawing.Point(7, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Итоговая стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите поставщика";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Выберите материал";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(215, 215);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(100, 22);
            this.priceBox.TabIndex = 4;
            this.priceBox.Text = "0";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(217, 166);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.ReadOnly = true;
            this.quantityBox.Size = new System.Drawing.Size(100, 22);
            this.quantityBox.TabIndex = 3;
            this.quantityBox.TextChanged += new System.EventHandler(this.quantityBox_TextChanged);
            // 
            // addModelBt
            // 
            this.addModelBt.Location = new System.Drawing.Point(355, 20);
            this.addModelBt.Name = "addModelBt";
            this.addModelBt.Size = new System.Drawing.Size(103, 23);
            this.addModelBt.TabIndex = 12;
            this.addModelBt.Text = "Добавить";
            this.addModelBt.UseVisualStyleBackColor = true;
            this.addModelBt.Click += new System.EventHandler(this.addModelBt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.addModelTb);
            this.groupBox3.Controls.Add(this.addModelBt);
            this.groupBox3.Location = new System.Drawing.Point(904, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 340);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // addModelTb
            // 
            this.addModelTb.Location = new System.Drawing.Point(215, 21);
            this.addModelTb.Name = "addModelTb";
            this.addModelTb.Size = new System.Drawing.Size(134, 22);
            this.addModelTb.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Добавить новую модель";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 786);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.doOrderGP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.valLabel);
            this.Controls.Add(this.top2Label);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.top1Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Adminname);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.doOrderGP.ResumeLayout(false);
            this.doOrderGP.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Adminname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reloadBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label top1Label;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label top2Label;
        private System.Windows.Forms.Label valLabel;
        private System.Windows.Forms.Button ordersChangeBt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox doOrderGP;
        private System.Windows.Forms.ComboBox developerComboBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Button confirmBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Button addModelBt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox addModelTb;
        private System.Windows.Forms.Label label8;
    }
}