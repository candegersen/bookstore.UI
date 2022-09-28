using bookstore.Core.DataAccess;
using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Abstract
{
    public interface ICategoryService  
    {
        Task Add(CategoryDto categoryDto);
        Task Update(Category category);
        Task Delete(string name);
        Task<Category> GetCategoryById(int id);
        Task<Category> GetCategoryByName(string categoryName);
        Task<IList<Category>> GetList();
    }
}
