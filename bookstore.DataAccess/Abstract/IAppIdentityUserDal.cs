using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Abstract
{
    public interface IAppIdentityUserDal
    {
        Task<List<AppIdentityUser>> GetUsersAsync();
        List<Order> GetGivenCustomersOrders(AppIdentityUser user);
        string GetOrderOwnerFullNameWithId(int userId);
    }
}
