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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;password=dimonos2003");
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
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
