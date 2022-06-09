using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TasksLibrary.Tests
{
    [TestClass]
    public class MySampleTest
    {
        //TestContext use for save information about this unit tests
        //When testing web services , save URL
        //When testing asp.net apps - give permission to asp pages
        //When use Data Driven tests , gives permission to data access
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestRunDirectory {0}", TestContext.TestRunDirectory);
            TestContext.WriteLine("TestName {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutCome {0}", TestContext.CurrentTestOutcome);
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestContext.WriteLine("TestName (CleanUp) {0}", TestContext.TestName);
            TestContext.WriteLine("CurrentTestOutCome (CleanUp) {0}", TestContext.CurrentTestOutcome);
        }
    }
}
