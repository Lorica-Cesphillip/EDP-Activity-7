using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace PNR_Locomotive_Management_System
{
    public class MySQLHandler
    {
        public string con;

        public MySQLHandler(string server, string db, string user, string password)
        {
            this.con = $"server={server};user={user};password={password};database={db}";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(con);
        }

        public async Task<object> ExecuteScalarAsync(string query, MySqlParameter[] parameters = null)
        {
            object result = null;
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach(var param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }

                    result = await cmd.ExecuteScalarAsync();
                }
            }
            return result;
        }

        public bool ExecuteNonQuery(string query, MySqlParameter[] param = null)
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);

                    if (param != null)
                    {
                        command.Parameters.AddRange(param);
                    }
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }catch
                {
                    return false;
                }
            }
        }

        //Retrieve from database and load it to SqlDataGridView
        public MySqlDataReader ExecuteQuery(string query)
        {
            MySqlConnection conn = new MySqlConnection(con);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }catch
            {
                return null;
            }
        }

        public void CloseReader(MySqlDataReader reader)
        {
            if(reader != null)
            {
                reader.Close();
            }
        }

        public void CloseCon()
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                } 
            }
        }
    }
}
