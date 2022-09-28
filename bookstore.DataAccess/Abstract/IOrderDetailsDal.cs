using bookstore.Core.DataAccess;
using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Abstract
{
    public interface IOrderDetailsDal : IEntityRepository<OrderDetails>
    {
        Task<OrderDetails> OrderDetailWithOrders(Expression<Func<OrderDetails, bool>> filter);
    }
}
