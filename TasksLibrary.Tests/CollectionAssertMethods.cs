using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TasksLibrary.Tests
{
    [TestClass]
    public class CollectionAssertMethods
    {
        static List<string> employees;

    [ClassInitialize]
    public static void InitializeCurrentTest(TestContext testContext)
    {
            employees = new List<string>();

            employees.Add("Rick");
            employees.Add("Trick");
            employees.Add("George");
            employees.Add("Peter");
    }

    [TestMethod]
    public void AllItemsAreNotNull()
    {
            // Check , if all conllection elemets are created
            CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
    }

    [TestMethod]
    public void AllItemsAreUnique()
    {
            // Check , if all conllection elemets are created
            CollectionAssert.AllItemsAreNotNull(employees, "Uniqueness failed");
    }

    [TestMethod]
    public void AreEqual() // this tests are filed too, because employees and employeesTest names not кшпре subsequences
        {
            List<string> employeesTest = new List<string>();

            employeesTest.Add("Trick");
            employeesTest.Add("Rick");
            employeesTest.Add("Peter");
            employeesTest.Add("George");

            // check all element for equals.
            CollectionAssert.AreEqual(employees, employeesTest);
    }

    [TestMethod]
    public void AreEquivalent()
    {
            List<string> employeesTest = new List<string>();

            employeesTest.Add("Trick");
            employeesTest.Add("Rick");
            employeesTest.Add("Peter");
            employeesTest.Add("George");

            // check all element for equals.
            CollectionAssert.AreEquivalent(employees, employeesTest);
    }

        [TestMethod]
        public void employees_Subset()
        {
            List<string> employees_Subset = new List<string>();

            employees_Subset.Add(employees[2]);

            // check all element for equals.
            CollectionAssert.IsSubsetOf(employees_Subset, employees, "failed!");
        }
    }
}
