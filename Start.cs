using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BD
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password="+MYProperties.password);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn; ;
            comm.CommandType=CommandType.Text;
            comm.CommandText = "select * from Поставщики";
            NpgsqlDataReader reader = comm.ExecuteReader(); 
            if(reader != null )
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                
            }
            comm.Dispose();
            conn.Close();
        }
        
       
        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void clientbt_Click(object sender, EventArgs e)
        {
            ClientLogin clientlogin = new ClientLogin();
            clientlogin.Show();
        }

        private void adminbt_Click(object sender, EventArgs e)
        {

            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();
        }
    }
}
