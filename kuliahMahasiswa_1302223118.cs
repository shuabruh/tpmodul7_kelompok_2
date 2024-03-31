using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class Courses
    {
        public String code { get; set; }
        public String name { get; set; }
    }

    public class KuliahMahasiswa1302223118
    {
        public List<Courses> courses { get; set; }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("../../../tp7_2_1302223118.json");

            KuliahMahasiswa1302223118 dataJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223118>(jsonString);

            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}