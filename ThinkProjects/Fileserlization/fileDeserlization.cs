using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Fileserlization
{
    internal class fileDeserlization
{
        [Serializable]
        class student
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        static void Main(string[] args)
           
        {
            string path = @"C:\\Users\\User\\Desktop\\ThinkQuan\\MyApp\\ThinkProjects\\index.txt";
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
           student data= (student)bf.Deserialize(fs);
            Console.WriteLine( data.id);
            Console.WriteLine( data.name);
            fs.Close();
            Console.WriteLine( "file retrive sucessfully");
            Console.ReadKey();
        }
    }
}
