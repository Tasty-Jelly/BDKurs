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
    public partial class ServiceInsert : Form
    {
        public ServiceInsert()
        {
            InitializeComponent();
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
            comm.CommandText = "insert into service(service_id, service_name, service_type, service_description) values (default,'" + service_name_info.Text + "', '" + comboBoxServiceType.Text + "', '" + service_description_info.Text + "')";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();

        }
    }
}
