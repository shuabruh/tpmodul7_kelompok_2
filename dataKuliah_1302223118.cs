using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class DataMahasiswa1302223118
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
        public static void readJSON()
        {
            string filepath = "../../../tp7_1_1302223118.json";
            string jsonFile = File.ReadAllText(filepath);
            DataMahasiswa1302223118.data data = JsonSerializer.Deserialize<DataMahasiswa1302223118.data>(jsonFile);

            Console.WriteLine("Nama :" + data.nama.depan + " " + data.nama.belakang);
            Console.WriteLine("Nim :" + data.nim);
            Console.WriteLine("Fakultas :" + data.fakultas);
        }
    }


}