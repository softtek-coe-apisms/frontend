using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerseClient.Models
{
    public class ProductCatalog
    {
        public string currentCurrency { get; set; }
        public List<Producto> products { get; set; }
        public int totalItems { get; set; }
    }
}
