using bookstore.Core.DataAccess;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Abstract
{
    public interface IProductService
    {
        Task Add (Product product);
        Task Update (Product product);
        Task Delete (Product product);
        Task<IList<Product>> GetProductList();
        Task<Product> GetProductById (int id);
        Task<IList<Product>> ProductWithCategory();
        Task<IList<Product>> MaxPriceProduct();
        Task<IList<Product>> MinPriceProduct();
        Task<Product> GetProduct(Expression<Func<Product, bool>> filter = null);

       
       
    }
}
