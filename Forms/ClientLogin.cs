using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Npgsql;

namespace BD
{
    public partial class ClientLogin : Form
    {
        public ClientLogin()
        {
            InitializeComponent();
        }
        
        private void clientLoginBox_MouseClick(object sender, MouseEventArgs e)
        {
            clientLoginBox.Text = "";
        }

        private void clientLoginBt_Click(object sender, EventArgs e)
        {



            if (clientLoginBox.Text == "Введите своё имя" || clientLoginBox.Text == "")
            {
                MessageBox.Show("Ошибка имени пользователя", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select имя from Заказчики";
            NpgsqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string name  = reader.GetString(0);
                if(clientLoginBox.Text == name)
                {
                    DataBank.username = clientLoginBox.Text;
                    reader.Close();
                    comm.Dispose();
                    conn.Close();

                    Client client = new Client();
                    client.Show();
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

        
        private void clientNameRegBox_MouseClick(object sender, MouseEventArgs e)
        {
            clientNameRegBox.Text = "";
        }

        private void clientAdressRegBox_MouseClick(object sender, MouseEventArgs e)
        {
            clientAdressRegBox.Text = "";
        }

        private void clientPhoneRegBox_MouseClick(object sender, MouseEventArgs e)
        {
            clientPhoneRegBox.Text = "";
        }

        private void clientRegBt_Click(object sender, EventArgs e)
        {
            if(clientNameRegBox.Text=="")
            {
                MessageBox.Show("Ошибка имени пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clientAdressRegBox.Text == "")
            {
                MessageBox.Show("Ошибка адреса пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clientPhoneRegBox.Text == "")
            {
                MessageBox.Show("Ошибка телефона пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBank.username = clientNameRegBox.Text;
            DataBank.useradress = clientAdressRegBox.Text;
            DataBank.userphone = clientPhoneRegBox.Text;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn; ;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"insert into Заказчики(имя,адрес_доставки,номер_телефона) values('{DataBank.username}','{DataBank.useradress}','{DataBank.userphone}')";

            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();

            Client client = new Client();
            client.Show();
            this.Close();
            
        }
    }
}
