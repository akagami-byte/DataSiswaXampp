using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
#nullable disable

//Kelas: SI-KJ-24-01
//Kelompok: 09
//Anggota Kelompok:
//1. Muhammad Raihan Divanda (102042430032)
//2. Sulthan Muhammad Avedha Maheswara(102042400144)
//3. Hany kumalasari(102042330003)
//4. Puti Azzahra Navita (102042400105)

namespace DataSiswaXampp
{
    class Koneksi
    {
        string connectionstring_0109 = "Server=localhost;Database=siswa;Uid=root;Pwd=;"; //nama server
        public MySqlConnection con_0109;

        public void OpenConnection()
        {
            con_0109 = new MySqlConnection(connectionstring_0109);
            con_0109.Open();
        }

        public void CloseConnection()
        {
            con_0109.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con_0109);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet data = new DataSet();

            //Open Connection
            OpenConnection();
            // Create a command object for the query
            MySqlCommand command = new MySqlCommand(query, con_0109);
            // Assign the command to the adapter's SelectCommand
            adapter.SelectCommand = command;
            // Fill the DataSet
            adapter.Fill(data);
            // Close the con_0109nection
            CloseConnection();

            object bebas_0109 = data.Tables[0];
            return bebas_0109;
        }
    }
}
