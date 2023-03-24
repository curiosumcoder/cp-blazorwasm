
using Northwind.UI.Models;

namespace Northwind.UI.Services
{
    public interface IProductService
    {
        Task<List<Product>> Search(string filter);
        Task<Product> Create(Product p);
        Task Update(Product p);
        Task Delete(int id);
    }
}
