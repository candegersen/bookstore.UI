using bookstore.Core.DataAccess;
using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Abstract
{
    public interface IOrderDetailsService
    {
        Task<IList<OrderDetails>> GetAllOrderDetailsById(int orderId);

    }
}
