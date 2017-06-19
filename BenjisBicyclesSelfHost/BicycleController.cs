using System;
using System.Collections.Generic;
using System.Data;

namespace BenjisBicyclesSelfHost
{
    public class BicycleController : System.Web.Http.ApiController
    {
        public List<string> GetBrandNames() //gets all brands available and puts them in the listbox
        {
            DataTable lcResult = clsDBConnection.GetDataTable("SELECT BrandName FROM tblBrand", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public List<string> GetOrders() //gets all orders and puts them in the listbox
        {
            DataTable lcResult = clsDBConnection.GetDataTable("SELECT CustomerName FROM tblOrder", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public List<decimal> GetTotalOrderValue() //gets the total price of all orders 
        {
            DataTable lcResult = clsDBConnection.GetDataTable("SELECT Sum(TotalPrice) FROM tblOrder", null);
            List<decimal> lcTotal = new List<decimal>();
            foreach (DataRow dr in lcResult.Rows)
                lcTotal.Add((decimal)dr[0]);
            return lcTotal;
        }

        public string DeleteOrder(clsOrder prOrder)
        {   // delete
            try
            {
                int lcRecordCount = clsDBConnection.Execute(
        "DELETE FROM tblOrder WHERE CustomerName = @CustomerName", prepareOrderParameters(prOrder));
                if (lcRecordCount == 1)
                    return "Order Deleted";
                else
                    return "Unexpected order update count: " + lcRecordCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareOrderParameters(clsOrder prOrder)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(6);
            par.Add("OrderID", prOrder.OrderID);
            par.Add("Speciality", prOrder.CustomerName);
            par.Add("OrderDate", prOrder.OrderDate);
            par.Add("ItemQuantity", prOrder.ItemQuantity);
            par.Add("TotalPrice", prOrder.TotalPrice);
            par.Add("BicycleID", prOrder.BicycleID);
            return par;
        }

        public clsOrder GetOrder(string Order) //gets the selected order information 
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Order", Order);
            DataTable lcResult = clsDBConnection.GetDataTable("SELECT * FROM tblOrder WHERE CustomerName = @Order", par);
            if (lcResult.Rows.Count > 0)
                return new clsOrder()
                {
                    CustomerName = (string)lcResult.Rows[0]["CustomerName"],
                    CustomerPhone = (string)lcResult.Rows[0]["CustomerPhone"],
                    OrderDate = (DateTime)lcResult.Rows[0]["OrderDate"],
                    ItemQuantity = (int)lcResult.Rows[0]["ItemQuantity"],
                    //TotalPrice = (int)lcResult.Rows[0]["TotalPrice"],
                    //BicycleID = (int)lcResult.Rows[0]["BicycleID"]
                };
            else
                return null;
        }

        public clsBrand GetBrandName(string BrandName) //gets the selected brand information 
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BrandName", BrandName);
            DataTable lcResult = clsDBConnection.GetDataTable("SELECT * FROM tblBrand WHERE BrandName = @BrandName", par);
            if (lcResult.Rows.Count > 0)
                return new clsBrand()
                {
                    BrandName = (string)lcResult.Rows[0]["BrandName"],
                    WarrantyPeriod = (string)lcResult.Rows[0]["WarrantyPeriod"],
                    BrandContactPhone = (string)lcResult.Rows[0]["BrandContactPhone"],
                    BicycleList = GetBrandsBicycle(BrandName)
                };
            else
                return null;
        }

        public List<clsBicycle> GetBrandsBicycle(string BrandName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BrandName", BrandName);
            DataTable lcResult = clsDBConnection.GetDataTable("SELECT * FROM tblBicycle WHERE BrandName = @BrandName", par);
            List<clsBicycle> lcBicycle = new List<clsBicycle>();
            foreach (DataRow prDataRow in lcResult.Rows)
                lcBicycle.Add(dataRow2Bicycle(prDataRow));
            return lcBicycle;
        }

        public clsBicycle dataRow2Bicycle(DataRow prDataRow)
        {
            return new clsBicycle()
            {
                BicycleId = Convert.ToInt16(prDataRow["BicycleID"]),
                BicycleType = Convert.ToString(prDataRow["BicycleType"]),
                ModelName = Convert.ToString(prDataRow["Varchar"]),
                Price = Convert.ToDecimal(prDataRow["Price"]),
                Weight = Convert.ToSingle(prDataRow["Weight"]),
                Size = Convert.ToInt16(prDataRow["Size"]),
                StockQuantity = Convert.ToInt16(prDataRow["StockQuantity"]),
                LastModified = Convert.ToDateTime(prDataRow["LastModified"]),
                NoOfGears = prDataRow["NoOfGears"] is DBNull ? (int?)null : Convert.ToInt16(prDataRow["NoOfGears"]),
                Range = prDataRow["Range"] is DBNull ? (int?)null : Convert.ToInt16(prDataRow["Range"]),
                MotorPosition = prDataRow["MotorPosition"] is DBNull ? string.Empty : Convert.ToString(prDataRow["MotorPosition"]),
                BrandName = Convert.ToString(prDataRow["BrandName"])
            };
        }

    }
}
