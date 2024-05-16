using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank address
                clsStaff Staff = new clsStaff();
                //read in the fields for the current record
                Staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staffId"]);
                Staff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["staffName"]);
                Staff.JobTitle = Convert.ToString(DB.DataTable.Rows[Index]["jobTitle"]);
                Staff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["staffEmail"]);
                Staff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["staffAddress"]);
                Staff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateJoined"]);
                Staff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["isAdmin"]);
                //add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                //set the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count 
        {
            get
            {
                return StaffList.Count;
            }
            set
            {
                //nothing for now
            }
        }
        public clsStaff ThisStaffMember { get; set; }
    }
}