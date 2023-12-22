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

namespace BD.Forms
{
    public partial class OrderChange : Form
    {
        public OrderChange()
        {
            InitializeComponent();
        }

        private void confirmBt_Click(object sender, EventArgs e)
        {
            DataBank.orderid = Convert.ToInt32(idTb.Text);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"update Заказы_на_изготовление set статус = '{statusBox.Text}' where номер = {DataBank.orderid}";
            NpgsqlDataReader reader = comm.ExecuteReader();
            reader.Close();
            comm.Dispose();
            conn.Close();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DataBank.orderid = Convert.ToInt32(idTb.Text);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"delete from Заказы_на_изготовление where номер = {DataBank.orderid}";
            NpgsqlDataReader reader = comm.ExecuteReader();
            reader.Close();
            comm.Dispose();
            conn.Close();
            this.Close();
        }
    }
}
