using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        /******************Supplier OK TESTS******************/

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
            AnSupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void EmailSupplierOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string TestData = "MyEmail@gmail.com";
            //assign the data to the supplier
            AnSupplier.SupplierEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.SupplierEmail, TestData);
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

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method 
            Found = AnSupplier.Find(SupplierId);
            //test to see  if the result is true
            Assert.IsTrue(Found);
        }

        /******************Supplier DATA TESTS******************/

        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method 
            Found = AnSupplier.Find(SupplierId);
            //check the Supplier id  of the supplier
            if (AnSupplier.SupplierId != 20)
            {
                OK = false;
            }
            //test to see  if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastOrderDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the last order date added to the supplier
            if (AnSupplier.LastOrderDate != Convert.ToDateTime("01/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier name 
            if (AnSupplier.SupplierName != "Audi")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the email of the supplier
            if (AnSupplier.SupplierEmail != "audi@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the phone number of supplier
            if (AnSupplier.PhoneNumber != "01234567890")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the Address of supplier
            if (AnSupplier.Address != "Leicester LE4 0AH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 20;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the active property
            if (AnSupplier.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
