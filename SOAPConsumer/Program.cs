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
            client.AddStudent("Bob", 3, 15);
            client.FindStudent("Bob");
            client.AddStudent("Bob1", 4, 16);
            client.GetAllStudent();
            client.DeleteStudent(1);
            client.GetAllStudent();
            Console.ReadLine();
        }
    }
}
