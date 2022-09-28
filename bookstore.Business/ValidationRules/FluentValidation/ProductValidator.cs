using bookstore.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product> 
    {
        public ProductValidator()
        {
            RuleFor(x => x.Title).MaximumLength(100);
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.Price).NotNull();
            RuleFor(x => x.Author).NotNull();
        }
    }
}
