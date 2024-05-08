using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateAdded, TestData);
        }


        [TestMethod]
        public void CarIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.CarID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CarID, TestData);
        }

        [TestMethod]
        public void StockTotalPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockTotal = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockTotal, TestData);
        }

        [TestMethod]
        public void CarColourPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "blue";
            //assign the data to the property
            AStock.CarColour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CarColour, TestData);
        }

        [TestMethod]
        public void CarModelPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "R8";
            //assign the data to the property
            AStock.CarModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CarModel, TestData);
        }

        [TestMethod]
        public void CarBrandPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Audi";
            //assign the data to the property
            AStock.CarBrand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CarBrand, TestData);
        }

        [TestMethod]
        public void StockArriveDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.StockArriveDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockArriveDate, TestData);
        }

        [TestMethod]
        public void StockAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.StockAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockAvailable, TestData);
        }
    }
}
