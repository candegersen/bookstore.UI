using bookstore.Core.DataAccess.EntityFramework;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Concrete.EntityFramework
{
    public class CategoryDal : EntityRepository<Category>, ICategoryDal
    {
        public CategoryDal(MyDbContext context):base(context)
        {
        }

        public async Task<IList<Category>> GetProductsByCategory(int id)
        {
            return await dbSet.Include(x => x.Products).ToListAsync();
        }
    }
}
