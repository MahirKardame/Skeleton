using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);

        }

       

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.EmailOptIn = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerEmail = "max@hotmail.com";
            TestCustomer.CustomerPhone = "1234567890";
            TestCustomer.RegistrationDate = DateTime.Now;
            TestCustomer.Address = "Milton Keynes";
            TestCustomer.FullName = "Max Verstappen";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.EmailOptIn = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "max@hotmail.com";
            TestItem.CustomerPhone = "1234567890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "Milton Keynes";
            TestItem.FullName = "Max Verstappen";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.EmailOptIn = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "max@hotmail.com";
            TestItem.CustomerPhone = "1234567890";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Address = "Milton Keynes";
            TestItem.FullName = "Max Verstappen";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);



        }
    }
}
