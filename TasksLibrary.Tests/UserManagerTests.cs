using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TasksLibrary.Tests
{

    //Data Driven Test - test, who gave using for start, datas 
    // Test runs one by one per one row from data.
    [TestClass]
    public class UserManagerTests
    {
        public TestContext TestContext { get; set; }
        private UserManager manager = new UserManager();

        //DataSource
           // 1 parameter - name of provider
           // 2 parameter - string connection or file path
           // 3 parameter - name of column or XML element
           // 4 parameter - how to access rows from Data Access
           [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "testData.xml", "User", DataAccessMethod.Sequential)]
           [TestMethod]
        public void UserManager_Add_FromXML() // DataRow not available, need to find another solution
        {
            string userId = Convert.ToString(TestContext.DataRow["userid"]);
            string tepehone = Convert.ToString(TestContext.DataRow["tepehone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);

            bool result = manager.Add(userId, tepehone, email);

            Assert.IsTrue(result, "User can't be created");
        }
    }
}
