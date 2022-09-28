using bookstore.Core.DataAccess;
using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.DataAccess.Abstract
{
    public interface IShipperDal : IEntityRepository<Shipper>
    {
      
    }
}
