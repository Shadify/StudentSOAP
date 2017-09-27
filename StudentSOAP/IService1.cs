using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Student AddStudent(string name, int semester, int age);

        [OperationContract]
        Student FindStudent(string name);

        [OperationContract]
        void DeleteStudent(int index);

        [OperationContract]
        Student EditStudent(Student studentA, Student studentB);

        [OperationContract]
        List<Student> GetAllStudent();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Semester { get; set; }

        [DataMember]
        public int Age { get; set; }

        public override string ToString()
        {
            return " Name: " + Name + " Semester: " + Semester + " Age: " + Age;
        }
    }


    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
