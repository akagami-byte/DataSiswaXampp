using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSiswaXampp.controller
{
    class siswafungsi
    {
        //Memanggil Class Koneksi dan create objek baru
        Koneksi koneksi = new Koneksi();

        public bool Insert(SiswaClass siswadata)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO siswadata (NIM, nama, kelas, alamat, email, nohp) VALUES ('" + siswadata.NIM1 + "', '" + siswadata.Nama + "', '" + siswadata.Kelas + "', '" + siswadata.Alamat + "', '" + siswadata.Email + "', '" + siswadata.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception ex) {
                {
                    MessageBox.Show(ex.Message, "Maaf, Data gagal dimasukkan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return status;
        }

        public bool Update(SiswaClass siswadata, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                //koneksi.ExecuteQuery("UPDATE siswadata SET nim='" + siswadata.NIM1 + "', " + "nama='" + siswadata.Nama + "', " + "kelas='" + siswadata.Kelas + "', " + "alamat='" + siswadata.Alamat + "', " + "email='" + siswadata.Email + "', " + "nohp='" + siswadata.Nohp + "' WHERE id='" + id + "'");
                koneksi.ExecuteQuery(
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
                koneksi.CloseConnection();

            }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message, "Maaf, Data gagal dimasukkan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM siswadata WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maaf, Data gagal dihapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
