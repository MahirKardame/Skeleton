using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // Private data member for the list.
        List<clsOrder> privOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList 
        {
            get
            {
                // Return the private data.
                return privOrderList;
            }

            set
            {
                // Set the private data.
                privOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                // Return the private data.
                return privOrderList.Count;
            }
            set
            { 
                // Return to this later.
            }
        }
        public clsOrder ThisOrder { get; set; }
        public clsOrderCollection()
        {
            // Variable for the index.
            Int32 Index = 0;
            // Variable to store the record count.
            Int32 RecordCount = 0;
            // Object for the data connection.
            clsDataConnection sqlDB = new clsDataConnection();
            // Execute the stored procedure.
            sqlDB.Execute("sproc_tblOrder_SelectAll");
            // Get the count of records.
            RecordCount = sqlDB.Count;
            // While there are records to process.
            while (Index < RecordCount) 
            {
                // Create a blank address.
                clsOrder AnOrder = new clsOrder();
                // Read in the fields for the current record.
                AnOrder.OrderID = Convert.ToInt32(sqlDB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.IsPaid = Convert.ToBoolean(sqlDB.DataTable.Rows[Index]["IsPaid"]);
                AnOrder.DateOrderPlaced = Convert.ToDateTime(sqlDB.DataTable.Rows[Index]["DateOrderPlaced"]);
                AnOrder.StaffNote = Convert.ToString(sqlDB.DataTable.Rows[Index]["StaffNote"]);
                AnOrder.CustomerNote = Convert.ToString(sqlDB.DataTable.Rows[Index]["CustomerNote"]);
                AnOrder.OrderPrice = Convert.ToInt32(sqlDB.DataTable.Rows[Index]["OrderPrice"]);
                // Add the record to the private data member.
                privOrderList.Add(AnOrder);
                // Point at the next record.
                Index++;
            }
        }
    }
}