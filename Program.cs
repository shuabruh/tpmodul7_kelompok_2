using System;
using System.Text.Json;
using dataMahasiswa;
using KuliahMahasiswa;

internal class Program
{
    private static void Main(string[] args)
    {
        ReadJSON();
    }
    public static void readJSON()
    {
        string filepath = Path.Combine("tp7_1_1302220072.json");
        string jsonFile = File.ReadAllText(filepath);
        DataMahasiswa1302220072.DataMhs mhsdata = JsonSerializer.Deserialize<DataMahasiswa1302220072.DataMhs>(jsonFile);

        Console.WriteLine("Nama " + mhsdata.nama.depan + " " + mhsdata.nama.belakang);
        Console.WriteLine("nim " + mhsdata.nim);
        Console.WriteLine("fakultas " + mhsdata.fakultas);
    }

    public static void ReadJSON()
    {
        string filepath2 = Path.Combine("tp7_2_1302220072.json");
        string jsonFile2 = File.ReadAllText(filepath2);
        KuliahMahasiswa1302220072.RootKuliah MKObj= JsonSerializer.Deserialize<KuliahMahasiswa1302220072.RootKuliah>(jsonFile2);
        List<KuliahMahasiswa1302220072.MataKuliah> dataJSON = MKObj.matakuliah;

        List<KuliahMahasiswa1302220072.MataKuliah> ListMK = new List<KuliahMahasiswa1302220072.MataKuliah>();

        foreach(KuliahMahasiswa1302220072.MataKuliah ObjMK in dataJSON)
        {
            ListMK.Add(ObjMK);
        }

        for (int i = 0; i < ListMK.Count; i++)
        {
            Console.WriteLine("MK " + (i+1) + " " + ListMK[i].kodeMK + " - " + ListMK[i].namaMK);
        }
    }
}