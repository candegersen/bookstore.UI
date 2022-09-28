using bookstore.Core.DataAccess;
using bookstore.Core.DataAccess.EntityFramework;
using bookstore.Core.Entities;
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
    public class AddressDal : EntityRepository<Address>,IAddressDal
    {
        public AddressDal(MyDbContext context):base(context)
        {

        }

        public async Task<IList<Address>> GetAddresses(int id)
        {
            return await dbSet.Include(x => x.Title).ToListAsync();
        }
    }
}
