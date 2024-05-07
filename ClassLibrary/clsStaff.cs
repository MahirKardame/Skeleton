using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool IsAdmin { get; set; }
        public DateTime dateJoined { get; set; }
        public int staffId { get; set; }
        public string staffName { get; set; }
        public string jobTitle { get; set; }
        public string staffEmail { get; set; }
        public string staffAddress { get; set; }
    }
}