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
                MessageBox.Show("Ошибка имени пользователя");
            }
            else 
            { 
                DataBank.username = clientLoginBox.Text;
                Client client = new Client();
                client.Show();
                this.Close();
            }
            
        }
    }
}
