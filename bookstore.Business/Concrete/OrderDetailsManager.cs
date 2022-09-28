using AutoMapper;
using bookstore.Business.Abstract;
using bookstore.Business.ValidationRules.FluentValidation;
using bookstore.DataAccess.Abstract;
using bookstore.Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.Concrete
{
    public class OrderDetailsManager : IOrderDetailsService
    {
        private readonly IOrderDetailsDal _orderDetailsDal;
        private readonly IMapper _mapper;
        
        public OrderDetailsManager(IOrderDetailsDal orderDetailsDal, IMapper mapper)
        {
            _mapper = mapper;
            _orderDetailsDal = orderDetailsDal;
        }

        public async Task<IList<OrderDetails>> GetAllOrderDetailsById(int orderId)
        {
            return (IList<OrderDetails>)await _orderDetailsDal.Get(x => x.OrderId == orderId);
        }

    }
}
