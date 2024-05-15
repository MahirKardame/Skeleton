using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass the method
        string StockTotal = "12";
        string CarModel = "Focus";
        string CarColour = "Blue";
        string CarBrand = "Ford";
        string StockArriveDate = ("12/02/2024");

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCarIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //check the car id
            if (AStock.CarID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockTotalFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //check the stock total
            if (AStock.StockTotal != 12)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //check the car model
            if (AStock.CarModel != "Focus")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarColourFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //check the car colour
            if (AStock.CarColour != "Blue")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarBrandFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //check the car brand
            if (AStock.CarBrand != "Ford")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //check the stock available
            if (AStock.StockAvailable != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockArriveDateFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CarID = 1;
            //invoke the method
            Found = AStock.Find(CarID);
            //check the stock arrive date
            if (AStock.StockArriveDate != Convert.ToDateTime("12/02/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AStock.Valid(StockTotal, CarModel, CarColour, CarBrand, StockArriveDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = "1"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = "11"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = "111"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = "1111"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = "11111"; //this should fail
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = "111"; //this should be ok
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockTotalExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockTotal = "";
            StockTotal = StockTotal.PadRight(500, '1'); //this should fail
            //invoke the method
            Error = AStock.Valid(StockTotal, StockTotal, CarModel, CarColour, StockArriveDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockArriveDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //String variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StockArriveDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(StockTotal, CarModel, CarColour, CarBrand, StockArriveDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
