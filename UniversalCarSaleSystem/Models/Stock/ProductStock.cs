using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalCarSaleSystem.Models.Stock
{
    public class ProductStock
    {
        public int ProcessType { get; set; }
        public int StockId { get; set; }
        
        public string CarCategory { get; set; }
        public string CarName { get; set; }
        public int CarModal { get; set; }
        public string CarPrice { get; set; }
        public string Color { get; set; }
        public int InStock { get; set; }
        public byte[] CarImage { get; set; }
        public string Comments { get; set; }
    }
}
