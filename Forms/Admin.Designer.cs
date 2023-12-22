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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 448);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список заказов";
            // 
            // reloadBt
            // 
            this.reloadBt.Location = new System.Drawing.Point(817, 9);
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
            this.dataGridView1.Location = new System.Drawing.Point(7, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 404);
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
            this.Label.Location = new System.Drawing.Point(522, 33);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(184, 16);
            this.Label.TabIndex = 6;
            this.Label.Text = "Самая прибыльная модель:";
            // 
            // top2Label
            // 
            this.top2Label.AutoSize = true;
            this.top2Label.Location = new System.Drawing.Point(712, 33);
            this.top2Label.Name = "top2Label";
            this.top2Label.Size = new System.Drawing.Size(37, 16);
            this.top2Label.TabIndex = 7;
            this.top2Label.Text = "none";
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.Location = new System.Drawing.Point(755, 33);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(14, 16);
            this.valLabel.TabIndex = 8;
            this.valLabel.Text = "0";
            // 
            // ordersChangeBt
            // 
            this.ordersChangeBt.Location = new System.Drawing.Point(989, 56);
            this.ordersChangeBt.Name = "ordersChangeBt";
            this.ordersChangeBt.Size = new System.Drawing.Size(156, 49);
            this.ordersChangeBt.TabIndex = 9;
            this.ordersChangeBt.Text = "Изменить заказы";
            this.ordersChangeBt.UseVisualStyleBackColor = true;
            this.ordersChangeBt.Click += new System.EventHandler(this.ordersChangeBt_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 516);
            this.Controls.Add(this.ordersChangeBt);
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
    }
}