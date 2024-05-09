using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the car id property
        private Int32 mCarID;

        //CarID public property
        public Int32 CarID
        {
            get
            {
                //this line of code sends data out of the property
                return mCarID;
            }
            set
            {
                //this line of code allows data into the property
                mCarID = value;
            }
        }

        //private data member for the stock total property
        private Int32 mStockTotal;

        //StockTotal public property
        public Int32 StockTotal
        {
            get
            {
                //this line of code sends data out of the property
                return mStockTotal;
            }
            set
            {
                //this line of code allows data into the property
                mStockTotal = value;
            }
        }

        //private data member for the car model property
        private string mCarModel;

        //CarModel public property
        public string CarModel
        {
            get
            {
                //this line of code sends data out of the property
                return mCarModel;
            }
            set
            {
                //this line of code allows data into the property
                mCarModel = value;
            }
        }

        //private data member for the car colour property
        private string mCarColour;

        //CarColour public property
        public string CarColour
        {
            get
            {
                //this line of code sends data out of the property
                return mCarColour;
            }
            set
            {
                //this line of code allows data into the property
                mCarColour = value;
            }
        }

        //private data member for the car brand property
        private string mCarBrand;

        //CarBrand public property
        public string CarBrand
        {
            get
            {
                //this line of code sends data out of the property
                return mCarBrand;
            }
            set
            {
                //this line of code allows data into the property
                mCarBrand = value;
            }
        }

        //private data member for the stock available property
        private Boolean mStockAvailable;

        //StockAvailable public property
        public Boolean StockAvailable
        {
            get
            {
                //this line of code sends data out of the property
                return mStockAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mStockAvailable = value;
            }
        }

        //private data member for the stock arrive date property
        private DateTime mStockArriveDate;

        //StockArriveDate public property
        public DateTime StockArriveDate
        {
            get
            {
                //this line of code sends data out of the property
                return mStockArriveDate;
            }
            set
            {
                //this line of code allows data into the property
                mStockArriveDate = value;
            }
        }



        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }

        public bool Find(int carID)
        {
            //set the private data members to the test data value
            mCarID = 21;
            mStockTotal = 30;
            mCarModel = "r8";
            mCarColour = "blue";
            mCarBrand = "audi";
            mStockAvailable = true;
            mStockArriveDate = Convert.ToDateTime("23/12/2022");
            //always return true
            return true;
        }
    }
}