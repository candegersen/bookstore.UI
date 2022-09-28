using bookstore.Core.DataAccess;
using bookstore.Core.DataAccess.EntityFramework;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Concrete.EntityFramework
{
    public class OrderDal : EntityRepository<Order>, IOrderDal
    {
        public OrderDal(MyDbContext context): base(context)
        {
        }

        public async Task<IList<Order>> GetOrdersWithCustomers()
        {
            return await dbSet.Include(x => x.Customer).Include(x => x.OrderDetails).Where(x => x.IsAllowed == true).ToListAsync();
        }
    }
}
