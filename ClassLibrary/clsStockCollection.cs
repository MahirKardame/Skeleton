using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public object ThisStock { get; set; }

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        public clsStockCollection()
        {
            //create the items of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.CarID = 1;
            TestItem.StockTotal = 12;
            TestItem.CarModel = "Ford";
            TestItem.CarColour = "Blue";
            TestItem.CarBrand = "Focus";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = true;
            //add the test item to the test list
            mStockList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStock();
            //set its properties
            TestItem.CarID = 1;
            TestItem.StockTotal = 12;
            TestItem.CarModel = "Ford";
            TestItem.CarColour = "Blue";
            TestItem.CarBrand = "Focus";
            TestItem.StockArriveDate = DateTime.Now;
            TestItem.StockAvailable = true;
            //add the item to the test list
            mStockList.Add(TestItem);
        }
    }
}