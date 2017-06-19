using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenjisBicyclesSelfHost
{
    public class clsBrand
    {
        public string BrandName { get; set; }
        public string WarrantyPeriod { get; set; }
        public string BrandContactPhone { get; set; }
        public List<clsBicycle> BicycleList { get; set; }
    }

    public class clsBicycle
    {
        public int BicycleId { get; set; }
        public string BicycleType { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public int Size { get; set; }
        public int StockQuantity { get; set; }
        public DateTime LastModified { get; set; }
        public int? NoOfGears { get; set; }
        public int? Range { get; set; }
        public string MotorPosition { get; set; }
        public string BrandName { get; set; }
        public List<clsOrder> OrderList { get; set; }
    }

    public class clsOrder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime OrderDate { get; set; }
        public int ItemQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int BicycleID { get; set; }
    }
}
