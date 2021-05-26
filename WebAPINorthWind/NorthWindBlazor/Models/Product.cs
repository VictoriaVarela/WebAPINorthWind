using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWindBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? UnitPrice { get; set; }
    }
}
