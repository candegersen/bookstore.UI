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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        private readonly IMapper _mapper;
        public OrderManager(IOrderDal orderDal, IMapper mapper)
        {
            _mapper = mapper;
            _orderDal = orderDal;
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _orderDal.Get(x => x.Id == orderId);
        }

        public async Task<IList<Order>> OrderListByCustomerId(int customerId)
        {
            return await _orderDal.GetList(x => x.CustomerId == customerId);
        }
    }
}
