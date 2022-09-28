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
    public class PaymentManager : IPaymentService
    {
        private readonly IPaymentDal _paymentDal;
        private readonly IMapper _mapper;
        public PaymentManager(IPaymentDal paymentDal, IMapper mapper)
        {
            _paymentDal = paymentDal;
            _mapper = mapper;
        }
        
                 
        

    }
}
