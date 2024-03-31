using System.Text.Json;
using DataMahasiswa;

internal class Program
{
    private static void Main(string[] args)
    {
        readJSON();
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
}