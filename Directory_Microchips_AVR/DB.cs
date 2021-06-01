using MySql.Data.MySqlClient;
using System;
//using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Microchips_AVR
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection(
            "server=localhost;port=3306;username=root;password=root;database=directory_microcontroller_avr");
        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            catch
            {
                Console.WriteLine("Turn on Server");
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
