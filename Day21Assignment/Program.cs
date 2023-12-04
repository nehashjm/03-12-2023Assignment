//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day21Assignment
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee obj = new Employee()
//            {
//                ID = 1,
//                FirstName = "Nehash",
//                LastName = "madabhavi",
//                Salary = 90000
//            };
//            IFormatter formatter = new BinaryFormatter();
//            Stream stream = new FileStream(@"D:\mphasis Simplilearn\Day21\Day21Assignment\employee.txt",
//                FileMode.Create, FileAccess.Write);
//            formatter.Serialize(stream, obj);
//            stream.Close();

//            stream = new FileStream(@"D:\mphasis Simplilearn\Day21\Day21Assignment\employee.txt",
//                FileMode.Open, FileAccess.Read);
//            Employee objnew=(Employee)formatter.Deserialize(stream);
//            Console.WriteLine(objnew.ID);
//            Console.WriteLine(objnew.FirstName);
//            Console.WriteLine(objnew.LastName);
//            Console.WriteLine(objnew.Salary);
//            Console.ReadKey();
//        }
//    }
//}
//XML Serilization
using System;
using System.IO;
using System.Xml.Serialization;
namespace XMLSerilzation
{
    [Serializable]

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Saalary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee { Id = 1, FirstName="NEHASH",LastName = "JM",Saalary = 250000};
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using(TextWriter writer = new StreamWriter("employee.xml"))
            {
                serializer.Serialize(writer, employee);
            }
            using(TextReader reader = new StreamReader("employee.xml"))
            {
                Employee deserailizedEmployee = (Employee)serializer.Deserialize(reader);
                Console.WriteLine($"ID:{deserailizedEmployee.Id},FirstName:{deserailizedEmployee.FirstName},LastName:{deserailizedEmployee.LastName},Salary{deserailizedEmployee.Saalary}");

            }
            Console.ReadKey();

        }
    }
}