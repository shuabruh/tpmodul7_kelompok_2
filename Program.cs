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
        string filepath = Path.Combine(@"D:\matkul jurusan rpl telu\Semester 4\praktikum kpl\tp modul7\tpmodul7_kelompok_2\tp7_1_1302223076.json");
        string jsonFile = File.ReadAllText(filepath);
        DataMahasiswa1302223076.data data = JsonSerializer.Deserialize<DataMahasiswa1302223076.data>(jsonFile);

        Console.WriteLine("Nama :" + data.nama.depan + " " + data.nama.belakang);
        Console.WriteLine("Nim :" + data.nim);
        Console.WriteLine("Fakultas :" + data.fakultas);
    }
}