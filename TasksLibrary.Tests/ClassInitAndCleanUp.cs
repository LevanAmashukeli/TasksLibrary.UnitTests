using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TasksLibrary.Tests
{
    [TestClass]
    public class ClassInitAndCleanUp
    {
        private static ShoppingCard card;
        // Start before first test method
        // method need to be public, static and has a properties
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("Class Initialize");
            Item item = new Item();
            item.Name = "Unit Test Lessons";
            item.Quantity = 10;

            card = new ShoppingCard();
            card.Add(item);
        }

        // Starts after end last testing method
        // method need to be a public, static and return void
        [ClassCleanup]
        public static void TestCleanUp()
        {
            Debug.WriteLine("Class CleanUp");
            card.Dispose();
        }

        [TestMethod]
        public void ShoppingCard_AddToCard()
        {
            int exptected = card.Items.Count + 1;

            card.Add(new Item() { Name = "Test", Quantity = 1 });

            Assert.AreEqual(exptected, card.Count);
        }
    }
}
