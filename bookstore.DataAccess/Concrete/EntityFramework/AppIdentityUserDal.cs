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
    public class AppIdentityUserDal : IAppIdentityUserDal
    {
        private readonly MyDbContext _db;
        public AppIdentityUserDal(MyDbContext db)
        {
            _db = db;
        }

        public List<Order> GetGivenCustomersOrders(AppIdentityUser user)
        {
            return _db.Users.Single(x => x.Id == user.Id).Orders.ToList();
        }

        public string GetOrderOwnerFullNameWithId(int userId)
        {
            AppIdentityUser user = _db.Users.Single(x => x.Id == userId.ToString());
            return $"{user.Name} {user.Surname}";
        }

        public async Task<List<AppIdentityUser>> GetUsersAsync()
        {
            return await _db.Users.ToListAsync();
        }
    }
}
