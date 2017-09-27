using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestSOAP.ServiceReference1;

namespace UnitTestSOAP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            using (Service1Client client = new Service1Client())
            {
                var a = client.AddStudent("Bob", 5, 15);
                Assert.AreEqual("Bob", a.Name);
            }
        }

        [TestMethod]
        public void TestFindMethod()
        {
            using (Service1Client client = new Service1Client())
            {
                var b = client.FindStudent("Bob");
                Assert.AreEqual("Bob", b.Name);
            }
        }

        [TestMethod]
        public void TestEditMethod()
        {
            using (Service1Client client = new Service1Client())
            {
                var a = client.AddStudent("Bob", 4, 15);
                var b = client.AddStudent("NewBob", 4, 14);

                var c = client.EditStudent(a, b);
                Assert.AreEqual("NewBob", c.Name);
            }
        }
    }
}
