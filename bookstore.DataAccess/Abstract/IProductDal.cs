using bookstore.Core.DataAccess;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        Task<IList<Product>> GetProductsByCategory();

        Task<IList<Product>> ProductList();

        Task<Product> GetProduct(Expression<Func<Product, bool>> filter = null);
    }
}
