using System.Text.Json;
using DataMahasiswa;
using KuliahMahasiswa;

internal class Program
{
    private static void Main(string[] args)
    {
        ReadJSON();
    }

    public static void readJSON()
    {
        string filepath = Path.Combine(@"C:\Users\myous\Documents\GitHub\tpmodul7_1302220085\tpmodul7_kelompok_2\tp7_1_1302220085.json");
        string jsonFile = File.ReadAllText(filepath);
        DataMahasiswa1302220085.data data = JsonSerializer.Deserialize<DataMahasiswa1302220085.data>(jsonFile);

        Console.WriteLine("Nama :" + data.nama.depan + " " + data.nama.belakang);
        Console.WriteLine("Nim :" + data.nim);
        Console.WriteLine("Fakultas :" + data.fakultas);
    }

    public static void ReadJSON()
    {
        string filepath2 = Path.Combine(@"C:\Users\myous\Documents\GitHub\tpmodul7_1302220085\tpmodul7_kelompok_2\tp7_2_1302220085.json");
        string jsonFile2 = File.ReadAllText(filepath2);
        KuliahMahasiswa1302220085.RootKuliah MKObj = JsonSerializer.Deserialize<KuliahMahasiswa1302220085.RootKuliah>(jsonFile2);
        List<KuliahMahasiswa1302220085.MataKuliah> dataJSON = MKObj.MataKuliah;

        List<KuliahMahasiswa1302220085.MataKuliah> ListMK = new List<KuliahMahasiswa1302220085.MataKuliah>();

        foreach (KuliahMahasiswa1302220085.MataKuliah ObjMK in dataJSON)
        {
            ListMK.Add(ObjMK);
        }

        for (int i = 0; i < ListMK.Count; i++)
        {
            Console.WriteLine("MK " + (i + 1) + " " + ListMK[i].kodeMK + " - " + ListMK[i].namaMK);
        }
    }
}