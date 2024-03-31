using System;
using System.IO;
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
        string filepath = Path.Combine("tp7_1_1302220085.json")
        string jsonFile = File.ReadAllText(filepath);
        DataMahasiswa1302220085.data data = JsonSerializer.Deserialize<DataMahasiswa1302220085.data>(jsonFile);

        Console.WriteLine("Nama " + data.nama.depan + " " + data.nama.belakang);
        Console.WriteLine("nim " + data.nim);
        Console.WriteLine("fakultas " + data.fakultas);
    }
}