using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string Address;

        public bool Email {  get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}