using System;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        readJSON();
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
}

public class DataMahasiswa1302220072
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMhs
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
    }
}