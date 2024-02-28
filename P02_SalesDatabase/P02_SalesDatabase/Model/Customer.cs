using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Customer


    {

        public int CustomerId { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string Email { get; set; }
        public string CreaditCardNumber { get; set; }

        public ICollection<Sale> Sales { get; set; }
        //         
        // Name(up to 100 characters, unicode)
        // Email(up to 80 characters, not unicode)
        // CreaditCardNumber(string)
        // Sale
    }
}
