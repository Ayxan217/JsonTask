using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace JsonFileTask;


internal class Program
{
    static void Main(string[] args)
    {

        

        List<string> names = new List<string> { "Ayxan", "john", "doe", "Ağakerim", "David", "Enstain" };

        string result = JsonConvert.SerializeObject(names);

        string path = Path.GetFullPath(Path.Combine(@"..", "..", "..", "Files", "Name.json"));


        using (StreamWriter sw = new StreamWriter(path))
        {

            sw.WriteLine(result);
        }

        void Additem(string name)
        {
            StreamReader sr = new StreamReader(path);

            string oldNames = sr.ReadToEnd();

            sr.Close();

            var newNames = JsonConvert.DeserializeObject<List<string>>(oldNames);
            newNames.Add(name);

            string newResult = JsonConvert.SerializeObject(newNames);

            using (StreamWriter sw = new StreamWriter(path))

            {
                
                sw.WriteLine(newResult);
            }

        }

        Additem("abbas");

        

        void Delete(string name)
        {

            StreamReader sr = new StreamReader(path);

            string oldNames = sr.ReadToEnd();

            sr.Close();

            var newNames = JsonConvert.DeserializeObject<List<string>>(oldNames);
            newNames.Remove(name);



            string newResult = JsonConvert.SerializeObject(newNames);
            using (StreamWriter sw = new StreamWriter(path))

            {
                sw.WriteLine(newResult);
            }


        }
        Delete("Ayxan");


        bool Search(string name)
        {
            StreamReader sr = new StreamReader(path);
            string searchNames = sr.ReadToEnd();
            sr.Close();
            var listofSearch = JsonConvert.DeserializeObject<List<string>>(searchNames);
            

         return listofSearch.Contains(name);
           


            

        }

        Console.WriteLine(Search("abbas")); ;


    }
}
