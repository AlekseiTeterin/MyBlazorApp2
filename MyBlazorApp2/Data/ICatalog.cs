
using System.Collections.Concurrent;

namespace MyBlazorApp2.Data
{
    public interface ICatalog
    {
        void AddProduct(Product product);
        ConcurrentBag<Product> GetProducts();
        void DeleteProduct(int id);
        
    }
}