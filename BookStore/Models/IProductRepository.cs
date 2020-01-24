using System.Collections.Generic;

namespace BookStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
