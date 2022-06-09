using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksLibrary.Tests
{
    [TestClass]
    public class ExpectingExceptions
    {
        // ExpectingException - test to be without failes in process building we take ArgumentNullException
        [ExpectedException(typeof(ArgumentNullException), "Exception was not throw")]
        [TestMethod]
        public void MyClass_Sayhello_Exception()
        {
            MyClass instance = new MyClass();
            instance.SayHello(null);
        }

        [TestMethod]
        public void MyClass_SayHello_ReturnGeorge()
        {
            // arrange
            MyClass instance = new MyClass();
            string expected = "Hello George";

            // act
            string actual = instance.SayHello("George");

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
