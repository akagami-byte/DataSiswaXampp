using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataSiswaXampp.controller
{
    class Koneksi
    {
        string connectionstring = "Server=localhost;Database=siswa;Uid=root;Pwd=;";
        public MySqlConnection con;

        public void OpenConnection()
        {
            con = new MySqlConnection(connectionstring);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet data = new DataSet();

            //Open Connection
            OpenConnection();
            // Create a command object for the query
            MySqlCommand command = new MySqlCommand(query, con);
            // Assign the command to the adapter's SelectCommand
            adapter.SelectCommand = command;
            // Fill the DataSet
            adapter.Fill(data);
            // Close the connection
            CloseConnection();

            object bebas = data.Tables[0];
            return bebas;
        }
    }


}
