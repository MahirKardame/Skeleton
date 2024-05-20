using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Test to see that it exists.
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void AddressListOK() 
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create some test data to assign to the property --
            // in this case, the data needs to be a list of objects.
            List<clsOrder> TestList = new List<clsOrder>();
            // Add an item to the List
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Set its properties.
            TestItem.OrderID = 1;
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "Test note customer.";
            TestItem.StaffNote = "Test note staff.";
            TestItem.OrderPrice = 10000;
            // Add the item to the test list.
            TestList.Add(TestItem);
            // Assign the data to the property.
            AllOrders.OrderList = TestList;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create some test data to assign to the property.
            clsOrder TestOrder = new clsOrder();
            // Set the properties of the test object.
            TestOrder.OrderID = 1;
            TestOrder.IsPaid = true;
            TestOrder.DateOrderPlaced = DateTime.Now;
            TestOrder.DeliveryType = "Slow";
            TestOrder.CustomerNote = "Test note customer.";
            TestOrder.StaffNote = "Test note staff.";
            TestOrder.OrderPrice = 10000;
            // Assign the data to the property.
            AllOrders.ThisOrder = TestOrder;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create some test data to assign to the property --
            // in this case, the data needs to be a list of objects.
            List<clsOrder> TestList = new List<clsOrder>();
            // Add an Item to the List.
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Set its properties.
            TestItem.OrderID = 1;
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "Test note customer.";
            TestItem.StaffNote = "Test note staff.";
            TestItem.OrderPrice = 10000;
            // Add the item to the test list.
            TestList.Add(TestItem);
            // Assign the data to the property.
            AllOrders.OrderList = TestList;
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the class we want to create.
            clsOrderCollection AllOrders = new clsOrderCollection();
            // Create the item of test data.
            clsOrder TestItem = new clsOrder();
            // Variable to store the primary key.
            Int32 PrimaryKey = 33;
            // Set its properties.
            TestItem.OrderID = 33;
            TestItem.IsPaid = true;
            TestItem.DateOrderPlaced = DateTime.Now;
            TestItem.DeliveryType = "Slow";
            TestItem.CustomerNote = "This is a test for the Add Method.";
            TestItem.StaffNote = "This is a test for the AddMethodOK.";
            TestItem.OrderPrice = 100000;
            // Set ThisOrder to the test data.
            AllOrders.ThisOrder = TestItem;
            // Add the record.
            PrimaryKey = AllOrders.Add();
            // Find the record.
            AllOrders.ThisOrder.Find(PrimaryKey);
            // Test to see that the two values are the same.
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

    }
}
