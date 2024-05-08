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
        public void DeliveryTypePropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            string TestData = "Express";
            // Assign the data to the property
            AnOrder.DeliveryType = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryType, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 21;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the Order ID.
            if (AnOrder.OrderID != 21) 
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestIsPaidOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 21;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check isPaid.
            if (AnOrder.IsPaid != true)
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestDateOrderPlacedOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 21;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the DateOrderPlaced.
            if (AnOrder.DateOrderPlaced != Convert.ToDateTime("08/05/2024"))
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestDeliveryTypeOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 21;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the DeliveryType.
            if (AnOrder.DeliveryType != "Express")
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestOrderPriceOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 21;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the OrderPrice.
            if (AnOrder.OrderPrice != 10000)
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestStaffNoteOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 21;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the Order ID.
            if (AnOrder.StaffNote != "Staff note.")
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }

        [TestMethod]
        public void TestCustomerNoteOK()
        {
            // Create an instance of the class we want to create.
            clsOrder AnOrder = new clsOrder();
            // Create a Boolean variable to store the results of the validation.
            Boolean Found = false;
            // Create a Boolean Variable to record if the data is OK (assume it is).
            Boolean dataOK = true;
            // Create some test data to use with the method.
            Int32 OrderID = 21;
            // Invoke the method.
            Found = AnOrder.Find(OrderID);
            // Check the Order ID.
            if (AnOrder.CustomerNote != "Customer note.")
            {
                dataOK = false;
            }
            // Test to see if the result is true.
            Assert.IsTrue(dataOK);
        }
    }
}
