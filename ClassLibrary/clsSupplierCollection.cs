using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        //constructor for the class
        public clsSupplierCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of the record
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsSupplier AnSupplier = new clsSupplier();
                //set its properties
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnSupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnSupplier.LastOrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastOrderDate"]);
                AnSupplier.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add the record to the private data mmber
                mSupplierList.Add(AnSupplier);
                //point at the next record
                Index++;
            }
        }

        //public property of the supplier list
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }

       //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //set shall worry about this later
               
            }
        }


        public clsSupplier ThisSupplier { get; set; }
    }
}