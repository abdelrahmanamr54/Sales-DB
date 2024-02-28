using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Product
    {


        public int ProductId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ICollection<Sale> Sales { get; set; }
        //         
        // Name(up to 50 characters, unicode)
        // (real number)
        // Price
        // Sales
    }
}
