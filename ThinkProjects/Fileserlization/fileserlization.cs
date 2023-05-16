using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Fileserlization
{
    internal class fileserlization
{
        [Serializable]
        class student
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        static void Main(string[] args)
        {
           
            student s2 = new student();
            s2.id = 2;
            s2.name = "test2";
            string path = "C:\\Users\\User\\Desktop\\ThinkQuan\\MyApp\\ThinkProjects\\index.txt";
            FileStream fs=new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
           student data= (student)bf.Deserialize(fs);
            Console.WriteLine( data.id);
            Console.WriteLine( data.name);
            fs.Close();
            Console.WriteLine( "file retrive sucessfully");



        }
}
}
