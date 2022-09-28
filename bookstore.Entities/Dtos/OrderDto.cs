using bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Dtos
{
    public class OrderDto
    {
        public int UserId { get; set; }
        public bool State { get; set; }
        public List <OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
