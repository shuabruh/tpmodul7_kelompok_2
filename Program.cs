﻿using System;
using System.Text.Json;
using dataMahasiswa;

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

    public static void ReadJSON()
    {
        string filepath2 = Path.Combine("tp7_2_1302220072.json");
        string jsonFile2 = File.ReadAllText(filepath2);
    }
}