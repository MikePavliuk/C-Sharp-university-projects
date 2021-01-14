using System;
using System.Linq;
using System.Threading.Tasks;
using SoftwareStore.Domain.Entities.App;

namespace SoftwareStore.Domain.Repositories.Abstract
{
    public interface ICatalogRepository
    {
        #region Products
        IQueryable<Product> GetProducts();
        Task<Product> GetProductByIdAsync(Guid id);
        Task<Guid> SaveProductAsync(Product entity);
        Task DeleteProductAsync(Guid id);
        #endregion

        #region Orders
        IQueryable<Order> GetOrders();
        IQueryable<Order> GetOrdersFiltered(string productId, string dateFrom, string dateTo);
        IQueryable<Order> GetOrdersByAppUserId(Guid id);
        IQueryable<Order> GetOrdersByProductId(Guid id);
        Task<Order> GetOrderByIdAsync(Guid id);
        Task<Guid> SaveOrderAsync(Order entity);
        Task DeleteOrderAsync(Guid id);
        #endregion
    }
}
