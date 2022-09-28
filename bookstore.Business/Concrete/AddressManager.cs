using bookstore.Business.Abstract;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public async Task<IList<Address>> GetListByCity(string city)
        {
            return await _addressDal.GetList(x => x.City == city);
        }
    }
}
    
  