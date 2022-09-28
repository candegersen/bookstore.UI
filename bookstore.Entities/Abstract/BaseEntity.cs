using bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string UpdatedUser { get; set; }
    }
}
