using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketStorage.Models
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string ManufacturerName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
