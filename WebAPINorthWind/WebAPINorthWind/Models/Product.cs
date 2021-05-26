using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPINorthWind.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public bool Discontinued { get; set; }

        public static explicit operator ProductDTO(Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                UnitPrice = product.UnitPrice
            };
        }

    }
}