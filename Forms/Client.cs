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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Username.Text = DataBank.username;

            NpgsqlConnection idconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            idconn.Open();
            NpgsqlCommand idcomm = new NpgsqlCommand();
            idcomm.Connection = idconn;
            idcomm.CommandType = CommandType.Text;
            idcomm.CommandText = $"select id from Заказчики where имя = '{DataBank.username}'";
            NpgsqlDataReader idreader = idcomm.ExecuteReader();
            idreader.Read();
            DataBank.userid = idreader.GetInt32(0);
            idreader.Close();
            idcomm.Dispose();
            idconn.Close();

            NpgsqlConnection modelconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            modelconn.Open();
            NpgsqlCommand modelcomm = new NpgsqlCommand();
            modelcomm.Connection = modelconn;
            modelcomm.CommandType = CommandType.Text;
            modelcomm.CommandText = "select имя from Изделия  ";
            NpgsqlDataReader modelreader = modelcomm.ExecuteReader();
            while (modelreader.Read())
            {
                string model = modelreader.GetString(0);
                modelComboBox.Items.Add(model);
            }
            modelreader.Close();
            modelcomm.Dispose();
            modelconn.Close();

            NpgsqlConnection developerconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            developerconn.Open();
            NpgsqlCommand developercomm = new NpgsqlCommand();
            developercomm.Connection = developerconn;
            developercomm.CommandType = CommandType.Text;
            developercomm.CommandText = "select имя from Изготовители";
            NpgsqlDataReader developerreader = developercomm.ExecuteReader();
            while (developerreader.Read())
            {
                string developer = developerreader.GetString(0);
                developerComboBox.Items.Add(developer);
            }
            developerreader.Close();
            developercomm.Dispose();
            developerconn.Close();

            NpgsqlConnection kitconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            kitconn.Open();
            NpgsqlCommand kitcomm = new NpgsqlCommand();
            kitcomm.Connection = kitconn;
            kitcomm.CommandType = CommandType.Text;
            kitcomm.CommandText = "select материалы_к_наборам.id_набора, Материалы.Наименование  " +
                                    "from материалы_к_наборам,Материалы " +
                                    "where материалы_к_наборам.id_материала = Материалы.id";
            NpgsqlDataReader kitreader = kitcomm.ExecuteReader();
            int prekit = 1;
            string desc = "1) ";
            while (kitreader.Read())
            {
                int kit = kitreader.GetInt32(0);
                string kitnames = kitreader.GetString(1);
                if(prekit == kit)
                {
                    desc += kitnames + " ";
                }
                else
                {

                    kitComboBox.Items.Add(desc);
                    desc = kit + ") " + kitnames + " ";
                    prekit = kit;
                }
                
            }
            kitComboBox.Items.Add(desc);
            kitreader.Close();
            kitcomm.Dispose();
            kitconn.Close();

            NpgsqlConnection balanceconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            balanceconn.Open();
            NpgsqlCommand balancecomm = new NpgsqlCommand();
            balancecomm.Connection = balanceconn; ;
            balancecomm.CommandType = CommandType.Text;
            balancecomm.CommandText = $"select баланс from Заказчики where id = {DataBank.userid}";
            NpgsqlDataReader balancereader = balancecomm.ExecuteReader();
            balancereader.Read();
            DataBank.balance = balancereader.GetInt32(0);
            balanceLabel.Text = Convert.ToString(DataBank.balance);
            balancereader.Close();
            balancecomm.Dispose();
            balanceconn.Close();
        }

        
        private void confirmBt_Click(object sender, EventArgs e)
        {
            string summ = DataBank.modelid.ToString() + DataBank.userid.ToString() + DataBank.developerid.ToString()+ DataBank.kitid.ToString()+ quantityBox.Text;
            int hash = summ.GetHashCode();
            Random random = new Random();
            hash = hash%random.Next(hash);

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn; ;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"insert into Заказы_на_изготовление(номер, id_изделия,id_заказчика,id_изготовителя,id_набора,количество,цена) " +
                $"values({hash},'{DataBank.modelid}','{DataBank.userid}','{DataBank.developerid}','{DataBank.kitid}',{Convert.ToInt32(quantityBox.Text)},{Convert.ToInt32(priceBox.Text)})";

            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();

            DataBank.balance -= Convert.ToInt32(priceBox.Text);
            NpgsqlConnection balanceconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            balanceconn.Open();
            NpgsqlCommand balancecomm = new NpgsqlCommand();
            balancecomm.Connection = balanceconn; ;
            balancecomm.CommandType = CommandType.Text;
            balancecomm.CommandText = $"update Заказчики set баланс = {DataBank.balance} where id = {DataBank.userid}";
            balancecomm.ExecuteNonQuery();
            balanceLabel.Text = Convert.ToString(DataBank.balance);
            balancecomm.Dispose();
            balanceconn.Close();


            Client client = new Client();
            client.Show();
            this.Close();

        }
        private void quantityBox_TextChanged(object sender, EventArgs e)
        {

            int kit =(int)Char.GetNumericValue(( Convert.ToString(kitComboBox.Text[0])[0]));

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"select цена_набора from наборы_материалов where наборы_материалов.id = {kit}";
            NpgsqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            int pr = reader.GetInt32(0);
            reader.Close();
            comm.Dispose();
            conn.Close();

            if (quantityBox.Text == "")
                quantityBox.Text = "0";
            int price = pr * Convert.ToInt32(quantityBox.Text);
            priceBox.Text = price.ToString();

            DataBank.kitid=kit;
        }

        private void kitComboBox_TextChanged(object sender, EventArgs e)
        {
            quantityBox.ReadOnly = false;
        }
        private void modelComboBox_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"select id from Изделия where имя = '{modelComboBox.Text}'";
            NpgsqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            DataBank.modelid=reader.GetInt32(0);
            reader.Close();
            comm.Dispose();
            conn.Close();
        }
        private void developerComboBox_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"select id from Изготовители where имя = '{developerComboBox.Text}'";
            NpgsqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            DataBank.developerid = reader.GetInt32(0);
            reader.Close();
            comm.Dispose();
            conn.Close();
        }

        private void buyBt_Click(object sender, EventArgs e)
        {
            balanceLabel.Text = "0";
            DataBank.balance = 0;
            NpgsqlConnection balanceconn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            balanceconn.Open();
            NpgsqlCommand balancecomm = new NpgsqlCommand();
            balancecomm.Connection = balanceconn; ;
            balancecomm.CommandType = CommandType.Text;
            balancecomm.CommandText = $"update Заказчики set баланс = {0} where id = {DataBank.userid}";
            balancecomm.ExecuteNonQuery();
            balanceLabel.Text = Convert.ToString(DataBank.balance);
            balancecomm.Dispose();
            balanceconn.Close();
        }

        private void reloadBt_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=" + MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"select номер, Изделия.имя as изделие, Изготовители.имя as изготовитель, id_набора as набор, количество,цена,статус from Заказы_на_изготовление,Изделия,Изготовители " +
                $"where Заказы_на_изготовление.id_изделия = Изделия.id and Заказы_на_изготовление.id_изготовителя = Изготовители.id";
            NpgsqlDataReader reader = comm.ExecuteReader();
            if(reader.HasRows)
            {
                DataTable userTable = new DataTable();
                userTable.Load(reader);
                dataGridView1.DataSource= userTable;
            }
            
            reader.Close();
            comm.Dispose();
            conn.Close();
        }
    }
}
