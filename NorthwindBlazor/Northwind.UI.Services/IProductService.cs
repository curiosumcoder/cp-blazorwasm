using Northwind.UI.Models;

namespace Northwind.UI.Services
{
    public interface IProductService
    {
        Task<Product> Get(int id);
        Task<List<Product>> Search(string filter);
        Task<Product> Create(Product p);
        Task Update(Product p);
        Task Delete(int id);
    }
}
