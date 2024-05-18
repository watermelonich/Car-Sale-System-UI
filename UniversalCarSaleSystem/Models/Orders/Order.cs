using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalCarSaleSystem.Models.Orders
{
    public class Order
    {
        public int ProcessType { get; set; }
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CarName { get; set; }
        public string CarCategory { get; set; }
        public string CarColor { get; set; }
        public int CarModal { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public string NetPrice { get; set; }
        public string TaxAndExpenses { get; set; }
        public string TotalAmount { get; set; }
        public string DownPayment { get; set; }
        public string RemainingAmount { get; set; }
        public int CustomerId { get; set; }
        public int StockId { get; set; }
        public string Comments { get; set; }
 
    }
}
