using System;

namespace dataMahasiswa
{
    public class DataMahasiswa1302220072
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class DataMhs
        {
            public Nama nama { get; set; }
            public int nim { get; set; }
            public string fakultas { get; set; }
        }
    }
}