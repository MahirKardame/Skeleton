using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CarId { get; set; }
        public int StockTotal { get; set; }
        public string CarColour { get; set; }
        public string CarModel { get; set; }
        public string CarBrand { get; set; }
        public DateTime StockArriveDate { get; set; }
        public bool StockAvailable { get; set; }
    }
}