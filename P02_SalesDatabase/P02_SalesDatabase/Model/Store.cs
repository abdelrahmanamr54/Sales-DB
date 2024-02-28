using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Store
    {
        public int StoreId { get; set; }
        [Column(TypeName = "NVARCHAR(80)")]
        public string Name { get; set; }
        public ICollection<Sale> Sales { get; set; }

        //            StoreId
        // Name(up to 80 characters, unicode)
        // Sale
    }
}
