using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for staff id property
        private Int32 mStaffId;
        //staffId public property
        public Int32 staffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        //private data member for staff name property
        private string mStaffName;
        //staff name public property
        public string staffName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }
        }

        //private data member for job title property
        private string mJobTitle;
        //job title public property
        public string jobTitle
        {
            get
            {
                //this line of code sends data out of the property
                return mJobTitle;
            }
            set
            {
                //this line of code allows data into the property
                mJobTitle = value;
            }
        }

        //private data member for staff email property
        private string mStaffEmail;
        //staff email public property
        public string staffEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                //this line of code allows data into the property
                mStaffEmail = value;
            }
        }

        //private data member for staff address property
        private string mStaffAddress;
        //staff address public property
        public string staffAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffAddress;
            }
            set
            {
                //this line of code allows data into the property
                mStaffAddress = value;
            }
        }

        //private data member for dateJoined property
        private DateTime mDateJoined;
        //dateJoined public property
        public DateTime dateJoined
        {
            get
            {
                //this line of code sends data out of the property
                return mDateJoined;
            }
            set
            {
                //this line of code allows data into the property
                mDateJoined = value;
            }
        }

        //private data member for isAdmin property
        private Boolean mIsAdmin;
        //isAdmin public property
        public bool isAdmin
        {
            get
            {
                //this line of code sends data out of the property
                return mIsAdmin;
            }
            set
            {
                //this line of code allows data into the property
                mIsAdmin = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int staffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@staffId", staffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one then record is found
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["staffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["staffName"]);
                mJobTitle = Convert.ToString(DB.DataTable.Rows[0]["jobTitle"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["staffEmail"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["staffAddress"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["dateJoined"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["isAdmin"]);

                //return that everything worked ok
                return true;
            }
            else { 
                //return false indicating that there is a problem
                return false; 
            }
        }
    }
}