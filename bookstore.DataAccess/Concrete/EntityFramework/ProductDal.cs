using bookstore.Core.DataAccess.EntityFramework;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Concrete.EntityFramework
{
    public class ProductDal : EntityRepository<Product>, IProductDal
    {
        public ProductDal(MyDbContext context):base(context)
        {
        }

        public async Task<Product> GetProduct(Expression<Func<Product, bool>> filter = null)
        {
            var product = await dbSet.FirstOrDefaultAsync(filter);
            return product;
        }

        public async Task<IList<Product>> GetProductsByCategory()
        {
           return await dbSet.Include(x => x.Category).ToListAsync();
        }

       

        public async Task<IList<Product>> ProductList()
        {
            return await dbSet.ToListAsync();
        }
    }
}
