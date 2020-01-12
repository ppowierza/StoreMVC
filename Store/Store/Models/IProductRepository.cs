using System.Collections.Generic;

namespace Store.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
