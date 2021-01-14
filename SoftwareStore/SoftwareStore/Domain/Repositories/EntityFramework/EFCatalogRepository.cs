using System;
using System.Linq;
using System.Threading.Tasks;
using SoftwareStore.Domain.Entities.App;
using SoftwareStore.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace SoftwareStore.Domain.Repositories.EntityFramework
{
    public class EFCatalogRepository : ICatalogRepository
    {
        private readonly AppDbContext context;

        public EFCatalogRepository(AppDbContext context)
        {
            this.context = context;
        }

        #region Products
        public IQueryable<Product> GetProducts()
        {
            return context.Products;
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid> SaveProductAsync(Product entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteProductAsync(Guid id)
        {
            Product entity = await context.Products.AsNoTracking().SingleAsync(x => x.Id == id);

            context.Products.Remove(entity);

            await context.SaveChangesAsync();
        }
        #endregion

        #region Orders
        public IQueryable<Order> GetOrders()
        {
            return context.Orders.Include(x=>x.Product).Include(x=>x.AppUser);
        }

        public IQueryable<Order> GetOrdersFiltered(string productId, string dateFrom, string dateTo)
        {
            IQueryable<Order> result = context.Orders.Include(x=>x.Product).Include(x=>x.AppUser);

            if (Guid.TryParse(productId, out Guid idParsed) && idParsed != default)
                result = result.Where(x => x.ProductId == idParsed);

            if (DateTime.TryParse(dateFrom, out DateTime dateFromParsed) && dateFromParsed != default)
                result = result.Where(x => x.DateAdded >= dateFromParsed);

            if (DateTime.TryParse(dateTo, out DateTime dateToParsed) && dateToParsed != default)
                result = result.Where(x => x.DateAdded <= dateToParsed);

            return result;
        }

        public IQueryable<Order> GetOrdersByAppUserId(Guid id)
        {
            return context.Orders.Include(x=>x.Product).Where(x => x.AppUserId == id);
        }

        public IQueryable<Order> GetOrdersByProductId(Guid id)
        {
            return context.Orders.Where(x => x.ProductId == id);
        }

        public async Task<Order> GetOrderByIdAsync(Guid id)
        {
            return await context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Guid> SaveOrderAsync(Order entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteOrderAsync(Guid id)
        {
            Order entity = await context.Orders.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            context.Orders.Remove(entity);

            await context.SaveChangesAsync();
        }
        #endregion
    }
}
