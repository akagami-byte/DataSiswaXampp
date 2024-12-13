using System.Data;
using DataSiswaXampp.controller;
using MySql.Data.MySqlClient;

namespace DataSiswaXampp
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        SiswaClass SisClass = new SiswaClass();
        string id;

        public Form1()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            //Query Database
            DataSiswa.DataSource = koneksi.ShowData("SELECT * FROM siswadata");

            //ubah nama colom
            DataSiswa.Columns[0].HeaderText = "ID";
            DataSiswa.Columns[1].HeaderText = "NIM";
            DataSiswa.Columns[2].HeaderText = "Nama";
            DataSiswa.Columns[3].HeaderText = "Kelas";
            DataSiswa.Columns[4].HeaderText = "Alamat";
            DataSiswa.Columns[5].HeaderText = "Email";
            DataSiswa.Columns[6].HeaderText = "Nomor Telefon";
        }

        private void TampilFilter(string kolom, string nilaiFilter)
        {
            //siswafungsi sf = new siswafungsi();
            //DataTable dt = sf.FilterData(kolom);
            //DataSiswa.DataSource = dt;
            string query = $"SELECT * FROM siswadata WHERE {kolom} LIKE '%{nilaiFilter}%'";
            DataSiswa.DataSource = koneksi.ShowData(query);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
            comboBox1.Items.Add("Pilih Filter");
            comboBox1.Items.Add("NIM");
            comboBox1.Items.Add("Nama");
            comboBox1.Items.Add("Kelas");
            comboBox1.Items.Add("Alamat");
            comboBox1.Items.Add("Email");
            comboBox1.Items.Add("Nomor Telepon");
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TombolSimpan_Click(object sender, EventArgs e)
        {
            if (Nama.Text == "" || NIM.Text == "" || Kelas.Text == "" || Alamat.Text == "" || Email.Text == "" || Nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                siswafungsi sisfung = new siswafungsi();
                SisClass.NIM1 = NIM.Text;
                SisClass.Nama = Nama.Text;
                SisClass.Kelas = Kelas.Text;
                SisClass.Alamat = Alamat.Text;
                SisClass.Email = Email.Text;
                SisClass.Nohp = Nohp.Text;

                sisfung.Insert(SisClass);
                NIM.Text = "";
                Nama.Text = "";
                Kelas.Text = "";
                Alamat.Text = "";
                Email.Text = "";
                Nohp.Text = "";

                Tampil();
            }
        }

        private void NamaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataSiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            NIM.Text = DataSiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            Nama.Text = DataSiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            Kelas.Text = DataSiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            Alamat.Text = DataSiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            Email.Text = DataSiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
            Nohp.Text = DataSiswa.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void TombolUbah_Click(object sender, EventArgs e)
        {
            if (Nama.Text == "" || NIM.Text == "" || Kelas.Text == "" || Alamat.Text == "" || Email.Text == "" || Nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                siswafungsi sisfung = new siswafungsi();
                SisClass.NIM1 = NIM.Text;
                SisClass.Nama = Nama.Text;
                SisClass.Kelas = Kelas.Text;
                SisClass.Alamat = Alamat.Text;
                SisClass.Email = Email.Text;
                SisClass.Nohp = Nohp.Text;

                sisfung.Update(SisClass, id);
                NIM.Text = "";
                Nama.Text = "";
                Kelas.Text = "";
                Alamat.Text = "";
                Email.Text = "";
                Nohp.Text = "";

                Tampil();
            }
        }

        private void TombolHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Data akan dihapus! Anda Yakin?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                siswafungsi sisfung = new siswafungsi();
                sisfung.Delete(id);
                Tampil();
            }
        }

        private void CariData_TextChanged(object sender, EventArgs e)
        {
            //DataSiswa.DataSource = koneksi.ShowData("SELECT * FROM siswadata WHERE nim LIKE '%' '" + CariData.Text + "' '%' OR nama LIKE '%' '" + CariData.Text + "' '%'"); 
            //DataSiswa.DataSource = koneksi.ShowData($"SELECT * FROM siswadata WHERE nim LIKE @nim OR nama LIKE @nama OR kelas LIKE @kelas OR alamat LIKE @alamat OR email LIKE @email"); 
            DataSiswa.DataSource = koneksi.ShowData(
                $"SELECT * FROM siswadata WHERE nim LIKE '%{CariData.Text}%' " +
                $"OR nama LIKE '%{CariData.Text}%'" +
                $"OR kelas LIKE '%{CariData.Text}%'" +
                $"OR alamat LIKE '%{CariData.Text}%'" +
                $"OR email LIKE '%{CariData.Text}%'" +
                $"OR nohp LIKE '%{CariData.Text}%'"
            );
        }

        private void DataBaseSiswa_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string tampilan = comboBox1.SelectedItem.ToString();
            //if (tampilan == "Biasa")
            //{
            //    Tampil();
            //}
            //else if (tampilan == "Filter")
            //{
            //    TampilFilter("NIM, Nama, Kelas, Alamat, Email, NoHP");
            //}

            //string kolom = comboBox1.SelectedItem.ToString();
            //string nilaiFilter = textBoxFilter.Text;
            //if (nilaiFilter != "")
            //{
            //    TampilFilter(kolom, nilaiFilter);
            //}
            //else
            //{
            //    Tampil();
            //}
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string FilterPilih = comboBox1.SelectedItem.ToString();
            if (FilterPilih == "Pilih Filter")
            {
                DataSiswa.DataSource = koneksi.ShowData("SELECT * FROM siswadata");
            }
            if (FilterPilih == "NIM")
            {
                DataSiswa.DataSource = koneksi.ShowData("SELECT NIM FROM siswadata");
            }
            if (FilterPilih == "Nama")
            {
                DataSiswa.DataSource = koneksi.ShowData("SELECT nama FROM siswadata");
            }
            if (FilterPilih == "Kelas")
            {
                DataSiswa.DataSource = koneksi.ShowData("SELECT kelas FROM siswadata");
            }
            if (FilterPilih == "Email")
            {
                DataSiswa.DataSource = koneksi.ShowData("SELECT email FROM siswadata");
            }
            if (FilterPilih == "No. hp ")
            {
                DataSiswa.DataSource = koneksi.ShowData("SELECT nohp FROM siswadata");
            }
            if (FilterPilih == "Alamat")
            {
                DataSiswa.DataSource = koneksi.ShowData("SELECT alamat FROM siswadata");
            }
        }

        private void TombolCari_Click(object sender, EventArgs e)
        {

        }
    }
}

//OR kelas LIKE '%'" + CariData.Text + "' '%' OR alamat LIKE '%'" + CariData.Text + "' '%' OR email LIKE '%'" + CariData.Text + "' '%' OR alamat LIKE '%'")