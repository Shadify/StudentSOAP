using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : Student, IService1
    {
        static List<Student> listOfStudents = new List<Student>();

        public void AddStudent(string name, int semester, int age)
        {
            Student newStudent = new Student();
            newStudent.Name = name;
            newStudent.Semester = semester;
            newStudent.Age = age;
            listOfStudents.Add(newStudent);
        }

        public void DeleteStudent(Student studentA)
        {
            listOfStudents.Remove(studentA);
        }

        public void EditStudent(Student Before, Student After)
        {
            listOfStudents.Remove(Before);
            listOfStudents.Add(After);
        }

        public string FindStudent(string name)
        {
            var find = listOfStudents.Find(Student => Student.Name == name);
            
        }

        public List<Student> GetAllStudent()
        {
            return listOfStudents;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
