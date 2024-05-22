using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for thisStock
        clsStock mThisStock = new clsStock();
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

        

        //constructor for the class
        public clsStockCollection()
        {

            

            //variable for the index
            Int32 Index = 0;
            //vairiable to store the data connect
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records to process
            RecordCount = DB.Count;
            //while there ae records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AStock = new clsStock();
                //read in the fields for the current record
                AStock.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AStock.StockTotal = Convert.ToInt32(DB.DataTable.Rows[Index]["StockTotal"]);
                AStock.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AStock.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                AStock.CarBrand = Convert.ToString(DB.DataTable.Rows[Index]["CarBrand"]);
                AStock.StockArriveDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockArriveDate"]);
                AStock.StockAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["StockAvailable"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            throw new NotImplementedException();
        }
    }
}