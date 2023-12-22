using BD.Forms;
using Npgsql;
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
                MessageBox.Show("Ошибка имени админа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select имя from Изготовители";
            NpgsqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                if (adminLoginBox.Text == name)
                {
                    DataBank.adminname = adminLoginBox.Text;
                    reader.Close();
                    comm.Dispose();
                    conn.Close();

                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                    return;

                    
                }

            }
            reader.Close();
            comm.Dispose();
            conn.Close();
            MessageBox.Show("Вас нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }
    }
}
