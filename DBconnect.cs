using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Npgsql;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace IDZ_BD
{
    internal class DBconnect
    {
        NpgsqlConnection connect = new NpgsqlConnection("localhost; 5432; postgres; 123456; LR3.1");
        

        public bool selectClient(int client_id, int client_phone, string client_name)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.clientORDER BY client_id ASC", connect);
            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                return true;
            }
            else
                connect.Close();
            return false;
        }

        public bool insertClient(int client_id, int client_phone, string client_name)
        {
            NpgsqlCommand command = new NpgsqlCommand("insert into client values (@id, @phone, @name)", connect);
            command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = client_id;
            command.Parameters.Add("@phone", NpgsqlTypes.NpgsqlDbType.Integer).Value = client_phone;
            command.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Char).Value = client_name;

            connect.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.Close();
                return true;
            }
            else
                connect.Close();
            return false;
        }
    }
}

