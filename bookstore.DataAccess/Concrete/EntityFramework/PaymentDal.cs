using bookstore.Core.DataAccess;
using bookstore.Core.DataAccess.EntityFramework;
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
    public class PaymentDal : EntityRepository<Payment>, IPaymentDal
    {
        public PaymentDal(MyDbContext context): base(context)
        {
        }

        public Task<IList<Payment>> GetAllPayments()
        {
            throw new NotImplementedException();
        }

        public string GetPaymentNameWithId(int? paymentId)
        {
            throw new NotImplementedException();
        }
    }
}
