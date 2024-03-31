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
        string filepath = Path.Combine(@"C:\Users\delll\Documents\Kuliah S1-4\KPL-VLY\Praktikum KPL\tpmodul7_1302220131\tpmodul7_1302220131\tpmodul7_kelompok_2\tp7_1_1302220131.json");
        string jsonFile = File.ReadAllText(filepath);
        DataMahasiswa1302220131_Aufa.data data = JsonSerializer.Deserialize<DataMahasiswa1302220131_Aufa.data>(jsonFile);

        Console.WriteLine("Nama :" + data.nama.depan + " " + data.nama.belakang);
        Console.WriteLine("Nim :" + data.nim);
        Console.WriteLine("Fakultas :" + data.fakultas);
    }
}