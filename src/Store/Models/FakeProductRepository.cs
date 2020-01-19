using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product> {
            new Product { Name = "Witcher", Price = 30},
            new Product { Name = "Lord Of The Rings", Price = 40},
            new Product { Name = "Hobbit", Price = 50}
        };
    }
}
