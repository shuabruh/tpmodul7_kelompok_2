using System;
using System.Text.Json;
using dataMahasiswa;
using KuliahMahasiswa;

internal class Program
{
    private static void Main(string[] args)
    {
        readJSON();
    }
    public static void readJSON()
    {
        string filepath = Path.Combine(@"C:\\Users\\delll\\Documents\\Kuliah S1-4\\KPL-VLY\\Praktikum KPL\\tpmodul7_1302220131\\tpmodul7_1302220131\\tpmodul7_kelompok_2\\tp7_1_1302220131.json");
        string jsonFile = File.ReadAllText(filepath);
        DataMahasiswa1302220131.DataMhs mhsdata = JsonSerializer.Deserialize<DataMahasiswa1302220131.DataMhs>(jsonFile);

        Console.WriteLine("Nama " + mhsdata.nama.depan + " " + mhsdata.nama.belakang);
        Console.WriteLine("nim " + mhsdata.nim);
        Console.WriteLine("fakultas " + mhsdata.fakultas);
    }

    public static void ReadJSON()
    {
        string filepath2 = Path.Combine(@"C:\Users\delll\Documents\Kuliah S1-4\KPL-VLY\Praktikum KPL\tpmodul7_1302220131\tpmodul7_1302220131\tpmodul7_kelompok_2\\tp7_2_1302220131.json");
        string jsonFile2 = File.ReadAllText(filepath2);
        KuliahMahasiswa13022220131.RootKuliah MKObj = JsonSerializer.Deserialize<KuliahMahasiswa13022220131.RootKuliah>(jsonFile2);
        List<KuliahMahasiswa13022220131.MataKuliah> dataJSON = MKObj.matakuliah;

        List<KuliahMahasiswa13022220131.MataKuliah> ListMK = new List<KuliahMahasiswa13022220131.MataKuliah>();

        foreach (KuliahMahasiswa13022220131.MataKuliah ObjMK in dataJSON)
        {
            ListMK.Add(ObjMK);
        }

        for (int i = 0; i < ListMK.Count; i++)
        {
            Console.WriteLine("MK " + (i + 1) + " " + ListMK[i].kodeMK + " - " + ListMK[i].namaMK);
        }
    }
}