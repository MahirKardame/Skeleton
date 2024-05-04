using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
            public void AvailableSupplierOK()
            {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to a supplier
            Boolean TestData = true;
            //assign the data to a supplier
            AnSupplier.Available = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.Available, TestData);
        }

        [TestMethod]
        public void LastOrderDateSupplierOK()
        { 
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            DateTime TestDate = DateTime.Now.Date;
            //asign the date to the supplier
            AnSupplier.LastOrderDate = TestDate;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.LastOrderDate, TestDate);
        }

        [TestMethod]
        public void SupplierIdSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            Int32 TestData = 1;
            //assign the data to the supplier
            AnSupplier.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
        }

        [TestMethod]
        public void NameSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "Hassan";
            //assign the data to the supplier
            AnSupplier.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Name, TestData);
        }

        [TestMethod]
        public void EmailSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "MyEmail@gmail.com";
            //assign the data to the supplier
            AnSupplier.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Email, TestData);
        }

        [TestMethod]
        public void PhoneNumberSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "12345678901";
            //assign the data to the supplier
            AnSupplier.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.PhoneNumber, TestData);
        }

        [TestMethod]
        public void AddressSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "Some Street, PostCode";
            //assign the data to the supplier
            AnSupplier.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Address, TestData);
        }
    }
}
