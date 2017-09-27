using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAPConsumer.ServiceReference1;

namespace SOAPConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            Student a = client.AddStudent("Bob", 3, 15);

            Console.WriteLine("Name: " + a.Name + " Age: " + a.Age + " Semester: " + a.Semester);
  
            Student found = client.FindStudent("Bob");
            Console.WriteLine(found.Name + found.Age + found.Semester);

            Student b = client.AddStudent("Bob1", 4, 16);

            Console.WriteLine(b.Name + b.Age + b.Semester);

            var c = client.GetAllStudent();

            Console.WriteLine("List of students");
            foreach (var student in c)
            {
                Console.WriteLine(student.Name);
            }

            client.DeleteStudent(0);

            var d = client.GetAllStudent();

            Console.WriteLine("List of students 2.0");
            foreach (var student in d)
            {
                Console.WriteLine(student.Name);
            }
            Console.ReadLine();
        }
    }
}
