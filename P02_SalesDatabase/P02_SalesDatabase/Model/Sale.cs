using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Sale
    {

        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int StoreId { get; set; }
       public Store store { get; set; }
    //        SaleId
    // Date
    // Product
    // Customer
    // Store
}
}
