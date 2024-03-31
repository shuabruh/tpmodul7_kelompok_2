using System;

namespace KuliahMahasiswa
{
    public class KuliahMahasiswa1302220072
    {
        public class MataKuliah
        {
            public string kodeMK { get; set; }
            public string namaMK { get; set; }
        }

        public class RootKuliah
        {
            public List<MataKuliah> matakuliah { get; set; }
        }
    }
}