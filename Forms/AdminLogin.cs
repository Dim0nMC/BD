using BD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void adminLoginBox_MouseClick(object sender, MouseEventArgs e)
        {
            adminLoginBox.Text = "";
        }

        private void adminLoginBt_Click(object sender, EventArgs e)
        {
            if(adminLoginBox.Text== "Введите своё имя"|| adminLoginBox.Text == "")
            {
                MessageBox.Show("Ошибка имени админа");
            }
            else 
            { 
                DataBank.adminname = adminLoginBox.Text;
                Admin admin = new Admin();
                admin.Show();   
                this.Close();
            }
            
        }
    }
}
