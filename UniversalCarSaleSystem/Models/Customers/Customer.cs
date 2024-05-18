using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalCarSaleSystem.Models.Customers
{
    public class Customer
    {
        public int ProcessType { get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string FatherName { get; set; }
        public string CNIC { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        public byte[] CustomerImage { get; set; }
        public string Comments { get; set; }


    }
}
