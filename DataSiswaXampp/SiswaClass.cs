using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class SiswaClass
    {
        string NIM, nama, kelas, alamat, email, nohp; //field
        public SiswaClass() { } //konstruktor kosong

        public SiswaClass(string NIM, string nama, string kelas, string alamat, string email, string nohp) //konstruktor dengan parameter
        {
            NIM1 = NIM;
            Nama = nama;
            Kelas = kelas;
            Alamat = alamat;
            Email = email;
            Nohp = nohp;
        }

        public string NIM1 { get => NIM; set => NIM = value; } //properti
        public string Nama { get => nama; set => nama = value; }
        public string Kelas { get => kelas; set => kelas = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}
