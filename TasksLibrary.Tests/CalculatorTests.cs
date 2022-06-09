using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            // arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            // act
            Calculator calc = new Calculator();
            int actual = calc.Sum(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
