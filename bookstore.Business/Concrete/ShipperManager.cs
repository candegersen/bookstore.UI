using AutoMapper;
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
    public class ShipperManager : IShipperService
    {
        private readonly IShipperDal _shipperDal;
        private readonly IMapper _mapper;
        public ShipperManager(IShipperDal shipperDal, IMapper mapper)
        {
            _mapper = mapper;
            _shipperDal = shipperDal;
        }
        public async Task<IList<Shipper>> GetShipperList()
        {
            return await _shipperDal.GetList();
        }
    }
}
