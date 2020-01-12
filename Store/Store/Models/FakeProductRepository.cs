using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Lord of the rings", Price = 50 },
            new Product { Name = "Witcher The Last Wish", Price = 30 },
            new Product { Name = "Witcher Sword of Destiny", Price = 30 },
            new Product { Name = "Painted Man", Price = 25 },
        };
    }
}
