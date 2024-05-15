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

        public bool Find(int CarID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CarID to search for
            DB.AddParameter("@CarID", CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByCarID");
            //if one record is found (there should be either one or zerp)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mStockTotal = Convert.ToInt32(DB.DataTable.Rows[0]["StockTotal"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mCarColour = Convert.ToString(DB.DataTable.Rows[0]["CarColour"]);
                mCarBrand = Convert.ToString(DB.DataTable.Rows[0]["CarBrand"]);
                mStockAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailable"]);
                mStockArriveDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StockArriveDate"]);
                //return that everthing worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
            
            
        }

        public string Valid(string stockTotal, string carModel, string carColour, string carBrand, string stockArriveDate)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the StockTotal is blank
            if (stockTotal.Length == 0)
            {
                //record the error
                Error = Error + "The Stock Total may not be blank : ";
            }
            //if the StockTotal is greater than 4 characters
            if (stockTotal.Length > 4)
            {
                //record the error
                Error = Error + "The Stock Total must be less than 4 charcters : ";
            }
            //copy the stockArriveDate value to the DateTemp variable
            DateTemp = Convert.ToDateTime(stockArriveDate);
            //check to see if the date is less than today's date
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past :";
            }
            //return any error messages
            return Error;
        }

        
    }
}