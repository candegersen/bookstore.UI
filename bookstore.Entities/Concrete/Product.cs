using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        //public virtual Shipper Shipper { get; set; }

        public int Quantity { get; set; }

        public virtual Category Category { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
       
    }
}
