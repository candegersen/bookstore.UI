using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class OrderDetails : IEntity
    {
        public int Id { get; set; }
        public decimal Price { get; set;}   
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public Product product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
