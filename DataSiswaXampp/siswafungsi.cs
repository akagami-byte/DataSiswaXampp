using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//Kelas: SI-KJ-24-01
//Kelompok: 09
//Anggota Kelompok:
//1. Muhammad Raihan Divanda (102042430032)
//2. Sulthan Muhammad Avedha Maheswara(102042400144)
//3. Hany kumalasari(102042330003)
//4. Puti Azzahra Navita (102042400105)

namespace DataSiswaXampp
{
    class siswafungsi
    {
        //Memanggil Class Koneksi dan create objek baru
        Koneksi koneksi_0109 = new Koneksi();

        public bool Insert(SiswaClass siswadata)
        {
            bool status = false;
            try
            {
                koneksi_0109.OpenConnection();
                
                string checkQuery = $"SELECT COUNT(*) FROM siswadata WHERE NIM = '{siswadata.NIM1}' AND nama = '{siswadata.Nama}' AND alamat = '{siswadata.Alamat}' AND email = '{siswadata.Email}'";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, koneksi_0109.con_0109);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Data dengan kombinasi NIM, nama, alamat, email dan no.telp ini sudah ada. SIlahkan coba lagi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi_0109.ExecuteQuery("INSERT INTO siswadata (NIM, nama, kelas, alamat, email, nohp) VALUES ('" + siswadata.NIM1 + "', '" + siswadata.Nama + "', '" + siswadata.Kelas + "', '" + siswadata.Alamat + "', '" + siswadata.Email + "', '" + siswadata.Nohp + "')");
                    status = true;
                    MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                koneksi_0109.CloseConnection();

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Maaf, Data gagal dimasukkan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return status;
        }

        public bool Update(SiswaClass siswadata, string id)
        {
            bool status = false;
            try
            {
                koneksi_0109.OpenConnection();
                //koneksi.ExecuteQuery("UPDATE siswadata SET nim='" + siswadata.NIM1 + "', " + "nama='" + siswadata.Nama + "', " + "kelas='" + siswadata.Kelas + "', " + "alamat='" + siswadata.Alamat + "', " + "email='" + siswadata.Email + "', " + "nohp='" + siswadata.Nohp + "' WHERE id='" + id + "'");
                koneksi_0109.ExecuteQuery(
                    $"UPDATE siswadata " +
                    $"SET nim='{siswadata.NIM1}', " +
                    $"nama='{siswadata.Nama}', " +
                    $"kelas='{siswadata.Kelas}', " +
                    $"alamat='{siswadata.Alamat}', " +
                    $"email='{siswadata.Email}', " +
                    $"nohp='{siswadata.Nohp}' " +
                    $"WHERE id='{id}'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi_0109.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maaf, Data gagal dimasukkan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id_0109)
        {
            bool status = false;
            try
            {
                koneksi_0109.OpenConnection();
                koneksi_0109.ExecuteQuery("DELETE FROM siswadata WHERE id='" + id_0109 + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi_0109.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maaf, Data gagal dihapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


    }
}
