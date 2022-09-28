using bookstore.Core.DataAccess;
using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Abstract
{
    public interface IAddressDal : IEntityRepository<Address>
    {
        Task<IList<Address>> GetAddresses(int id);
    }
}
