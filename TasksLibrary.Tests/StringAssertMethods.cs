using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace TasksLibrary.Tests
{
    [TestClass]
    public class StringAssertMethods
    {
        [TestMethod]
        public void StringContainsTest()
        {
            // check for occurrence of a substring in a string
            StringAssert.Contains("Assert samples", "sam");
        }

        [TestMethod]
        public void StringMatchTest()
        {
            // check with use RegEx
            StringAssert.Matches("123", new Regex(@"\d{3}"));
        }

        [TestMethod]
        public void StringStartsWithTest()
        {
            // check , if string starts with concrette word
            StringAssert.StartsWith("Hello world", "Hello");
        }

        [TestMethod]
        public void StringEndsWithTest()
        {
            // check , if string ends with concrette word
            StringAssert.StartsWith("Hello world", "world");
        }
    }
}
