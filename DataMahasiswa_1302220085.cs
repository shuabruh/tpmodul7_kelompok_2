using System;

namespace DataMahasiswa
{
    public class DataMahasiswa1302220085
    {
        public class nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class data
        {
            public nama nama { get; set; }
            public int nim { get; set; }
            public string fakultas { get; set; }
        }
    }
}
