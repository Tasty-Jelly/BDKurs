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

namespace IDZ_BD
{
    public partial class client_insert_form : Form
    {
        public client_insert_form()
        {
            InitializeComponent();
        }

        private void client_insert_form_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterParent;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void accept_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); // определяешь кеш в памяти
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;");
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "call client_exist('"+ comboBoxClientNames.Text + "', '" + client_phone_info.Text + "')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);

            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();
                       
        }

        public List<string> GetClientNamesFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT client_name FROM client";

            List<string> clientNames = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string clientName = reader.GetString(0);
                            clientNames.Add(clientName);
                        }
                    }
                }
            }

            return clientNames;
        }

        private void comboBoxClientNames_Click(object sender, EventArgs e)
        {
            List<string> clientNames = GetClientNamesFromDatabase();
            comboBoxClientNames.Items.Clear();
            foreach (string clientName in clientNames)
            {
                comboBoxClientNames.Items.Add(clientName);
            }
        }
    }
}
