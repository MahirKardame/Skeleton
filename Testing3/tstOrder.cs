using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Test to see that it exists.
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void IsPaidPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            Boolean TestData = true;
            // Assign the data to the property
            AnOrder.IsPaid = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }

        [TestMethod]
        public void DateOrderPlacedPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnOrder.DateOrderPlaced = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateOrderPlaced, TestData);
        }

        [TestMethod]
        public void DateOrderPaidPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnOrder.DateOrderPaid = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateOrderPaid, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            int TestData = 10000;
            // Assign the data to the property
            AnOrder.OrderPrice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void StaffNotePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            string TestData = "Staff Note.";
            // Assign the data to the property
            AnOrder.StaffNote = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffNote, TestData);
        }

        [TestMethod]
        public void CustomerNotePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            string TestData = "Customer Note.";
            // Assign the data to the property
            AnOrder.CustomerNote = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerNote, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            int TestData = 42;
            // Assign the data to the property
            AnOrder.OrderID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
    }
}
