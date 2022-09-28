using bookstore.Core.DataAccess.EntityFramework;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Concrete.EntityFramework
{
    public class OrderDetailsDal : EntityRepository<OrderDetails>, IOrderDetailsDal
    {
        public OrderDetailsDal(MyDbContext context):base(context)
        {
        }

        public async Task<OrderDetails> OrderDetailWithOrders(Expression<Func<OrderDetails, bool>> filter)
        {
            return await dbSet.Include(x => x.Order).Include(x => x.product).Where(filter).FirstOrDefaultAsync();
        }
    }
}
