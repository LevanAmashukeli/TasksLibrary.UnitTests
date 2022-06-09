using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TasksLibrary.Tests
{
    [TestClass]
    public class TestInitAndCleanUpcs
    {
        private ShoppingCard card;
        private Item item;

        // Start before start every testing methods
        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Test Initialize");
            item = new Item();
            item.Name = "Unit Test Lesson";
            item.Quantity = 10;

            card = new ShoppingCard();
            card.Add(item);
        }

        // Start after edning every testing methods
        [TestCleanup]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            card.Dispose();
        }

        [TestMethod]
        public void ShoppingCard_CheckOut_ContaintsItem()
        {
            CollectionAssert.Contains(card.Items, item);
        }

        [TestMethod]
        public void ShoppingCard_RemoveItem_Empty()
        {
            int expected = 0;
            card.Remove(0);
            Assert.AreEqual(expected, card.Count);
        }
    }
}
