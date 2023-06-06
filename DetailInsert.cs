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
    public partial class DetailInsert : Form
    {
        public DetailInsert()
        {
            InitializeComponent();
        }
        private void DetailInsert_Load(object sender, EventArgs e)
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
            comm.CommandText = "call detail_exist('"+comboBoxDetailName.Text+"', '" + comboBoxDetailNames.Text + "', " + detail_price_info.Text + ", " + detail_amount_info.Text +")";
                //"insert into detail(detail_id, detail_name, detail_price, detail_amount, detail_description) values (default,'" + comboBoxDetailName.Text + "', " + detail_price_info.Text + ", " + detail_amount_info.Text + ", '" + detail_description_info.Text + "')";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();

        }

        public List<string> GetDetailNamesFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT detail_description FROM detail";

            List<string> detailNames = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string detailName = reader.GetString(0);
                            detailNames.Add(detailName);
                        }
                    }
                }
            }

            return detailNames;
        }
        private void comboBoxDetailNames_Click(object sender, EventArgs e)
        {
            List<string> detailNames = GetDetailNamesFromDatabase();

            // Очистка списка перед добавлением новых значений
            comboBoxDetailNames.Items.Clear();

            // Добавление значений в ListBox
            foreach (string detailName in detailNames)
            {
                comboBoxDetailNames.Items.Add(detailName);
            }
            //FillListBoxWorkerNames();
        }
    }
}
