using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BeWithHer
{
    static class BeWithHerConnector
    {
        public static void Connect()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.1.4";
            builder.Port = 3306;
            builder.Database = "BeWithHer";
            builder.UserID = "bewithher";
            builder.Password = "bewithher";
            builder.ConnectionTimeout = 10;
            mBeWithHerConnection = new MySqlConnection(builder.ToString());
            mBeWithHerConnection.Open();
        }

        public static void Disconnect()
        {
            mBeWithHerConnection.Close();
        }

        public static void ExecuteNonQuery(string sqlQuery)
        {
            MySqlCommand cmd = new MySqlCommand(sqlQuery, mBeWithHerConnection);
            cmd.ExecuteNonQuery();
        }


        public static List<object[]> ExecuteQuery(string sqlQuery)
        {
            List<object[]> result = new List<object[]>();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, mBeWithHerConnection);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount]; 
                    reader.GetValues(row);
                    result.Add(row);
                }
            }
            finally
            {
                reader.Close();
            }
            
            return result;
        }


        private static MySqlConnection mBeWithHerConnection = null;


    }
}
