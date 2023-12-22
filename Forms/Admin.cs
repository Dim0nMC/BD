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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            Adminname.Text = DataBank.adminname;
            NpgsqlConnection idconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            idconn.Open();
            NpgsqlCommand idcomm = new NpgsqlCommand();
            idcomm.Connection = idconn;
            idcomm.CommandType = CommandType.Text;
            idcomm.CommandText = $"select id from Изготовители where имя = '{DataBank.adminname}'";
            NpgsqlDataReader idreader = idcomm.ExecuteReader();
            idreader.Read();
            DataBank.adminid = idreader.GetInt32(0);
            idreader.Close();
            idcomm.Dispose();
            idconn.Close();

        }

        private void reloadBt_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"select номер, Изделия.имя as изделие, Заказчики.имя as заказчик, id_набора as набор, количество,цена,статус from Заказы_на_изготовление,Изделия,Заказчики " +
                $"where Заказы_на_изготовление.id_изделия = Изделия.id and Заказы_на_изготовление.id_заказчика = Заказчики.id and Заказы_на_изготовление.id_изготовителя = {DataBank.adminid}; ";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable userTable = new DataTable();
                userTable.Load(reader);
                dataGridView1.DataSource = userTable;
            }

            reader.Close();
            comm.Dispose();
            conn.Close();



            NpgsqlConnection topconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            topconn.Open();
            NpgsqlCommand topcomm = new NpgsqlCommand();
            topcomm.Connection = topconn;
            topcomm.CommandType = CommandType.Text;
            topcomm.CommandText = $"select Изделия.имя as изделие, Заказы_на_изготовление.количество from Заказы_на_изготовление,Изделия " +
                $"where Заказы_на_изготовление.id_изделия = Изделия.id and id_изготовителя = {DataBank.adminid}";
            NpgsqlDataReader topreader = topcomm.ExecuteReader();
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            while (topreader.Read())
            {
                string model = topreader.GetString(0);
                int count = topreader.GetInt32(1);
                if (wordCount.ContainsKey(model))
                {
                    wordCount[model]+=count;
                }
                else
                {
                    wordCount[model] = count;
                }

            }
            string mostCommonWord = wordCount.OrderByDescending(pair => pair.Value).First().Key;
            top1Label.Text = mostCommonWord;
            countLabel.Text =Convert.ToString( wordCount.OrderByDescending(pair => pair.Value).First().Value);
            topreader.Close();
            topcomm.Dispose();
            topconn.Close();



            NpgsqlConnection valconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            valconn.Open();
            NpgsqlCommand valcomm = new NpgsqlCommand();
            valcomm.Connection = valconn;
            valcomm.CommandType = CommandType.Text;
            valcomm.CommandText = $"select Изделия.имя as изделие, Заказы_на_изготовление.цена from Заказы_на_изготовление,Изделия " +
                $"where Заказы_на_изготовление.id_изделия = Изделия.id and id_изготовителя = {DataBank.adminid}";
            NpgsqlDataReader valreader = valcomm.ExecuteReader();
            Dictionary<string, int> valCount = new Dictionary<string, int>();
            while (valreader.Read())
            {
                string model = valreader.GetString(0);
                int count = valreader.GetInt32(1);
                if (valCount.ContainsKey(model))
                {
                    valCount[model] += count;
                }
                else
                {
                    valCount[model] = count;
                }

            }
            string mostValWord = valCount.OrderByDescending(pair => pair.Value).First().Key;
            top2Label.Text = mostCommonWord;
            valLabel.Text = Convert.ToString(valCount.OrderByDescending(pair => pair.Value).First().Value);
            valreader.Close();
            valcomm.Dispose();
            valconn.Close();

        }

        private void ordersChangeBt_Click(object sender, EventArgs e)
        {
            OrderChange orderChange = new OrderChange();
            orderChange.Show();
        }
    }
}
