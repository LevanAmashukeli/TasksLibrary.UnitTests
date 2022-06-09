using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TasksLibrary.Tests
{
    [TestClass]
    public class MyClassTests
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            // arrange
            const double input = 4;
            const double expected = 2;

            // act
            double actual = MyClass.GetSqrt(input);

            // assert
            Assert.AreEqual(expected, actual, "sqrt of {0} should have been {1}!", input, expected);
        }

        [TestMethod]
        public void DeltaTest()
        {
            // arrange
            const double expected = 3.1;
            const double delta = 0.07;

            // act
            double actual = MyClass.GetSqrt(10);

            // assert
            Assert.AreEqual(expected, actual, delta, "Fail Message!!");
        }

        [TestMethod]
        public void StringAreEqualTest()
        {
            // arrange
            const string input = "HELLO";
            const string expected = "hello";

            // act and assert
            // 3th parameter - ignore reester
            Assert.AreEqual(expected, input, true);
        }

        [TestMethod]
        public void StringSameTest()
        {
            string a = "Hello";
            string b = "Hello";

            // check reference equal
            Assert.AreSame(a , b);
        }

        [TestMethod]
        public void IntegersSameTest()
        {
            int i = 10;
            int j = 10;

            // check reference equal
            Assert.AreSame(i, j);
        }
    }
}
