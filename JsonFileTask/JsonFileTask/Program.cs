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
            using (StreamReader sr = new StreamReader(path))
            {
               string newNames =  sr.ReadToEnd();
            }

            names.Add(name);
            string newResult = JsonConvert.SerializeObject(names);
            
             using (StreamWriter sw = new StreamWriter(path))
           
            {

                sw.WriteLine(newResult);
            }

        }

        Additem("abbas");

        void Delete(int index)
        {

            StreamReader sr = new StreamReader(path);
            
                sr.ReadToEnd();
                 sr.Close();

            names.FindAll(x => x.Equals(x[index]));
            
        }
       



    }
}
