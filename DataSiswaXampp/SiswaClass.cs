using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace DataSiswaXampp
{
    class SiswaClass
    {
        string NIM, nama, kelas, alamat, email, nohp;
        public SiswaClass() { }

        public SiswaClass(string NIM, string nama, string kelas, string alamat, string email, string nohp)
        {
            NIM1 = NIM;
            Nama = nama;
            Kelas = kelas;
            Alamat = alamat;
            Email = email;
            Nohp = nohp;
        }

        public string NIM1 { get => NIM; set => NIM = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Kelas { get => kelas; set => kelas = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}
