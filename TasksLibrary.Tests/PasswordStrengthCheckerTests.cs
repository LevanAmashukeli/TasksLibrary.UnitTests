using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TasksLibrary.Tests
{
    [TestClass()]
    public class PasswordStrengthCheckerTests
    {
        [TestMethod]
        public void GetPasswordStrenght_AllChars_5Points()
        {
            // arrage
            string password = "P2ssW0rd#";
            int expected = 5;

            // act
            int actual = PasswordStrengthChecker.GetPasswordStrenght(password);

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrenght_UpperCase_3Points()
        {
            // arrage
            string password = "Password";
            int expected = 3; // upper register 1, lenght 1, small register 1 points

            // act
            int actual = PasswordStrengthChecker.GetPasswordStrenght(password);

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrenght_ConteinsNumber_0_4Points()
        {
            // arrage
            string password = "Passw0rd";
            int expected = 4; // upper register 1, lenght 1, small register 1 and for number 1 points

            // act
            int actual = PasswordStrengthChecker.GetPasswordStrenght(password);

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrenght_ConteinsNumber_1_4Points()
        {
            // arrage
            string password = "Passw1rd";
            int expected = 4; // upper register 1, lenght 1, small register 1 and for number1 1 points

            // act
            int actual = PasswordStrengthChecker.GetPasswordStrenght(password);

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrenght_ContainsSpecialChar_at_5Points()
        {
            // arrage
            string password = "Passw0rd@";
            int expected = 5; // upper register 1, lenght 1, small register 1 , number 1 and special symbol points 1

            // act
            int actual = PasswordStrengthChecker.GetPasswordStrenght(password);

            // assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
