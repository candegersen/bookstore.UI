using bookstore.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Business.ValidationRules.FluentValidation
{
    public class ShipperValidator : AbstractValidator<Shipper>
    {
        public ShipperValidator()
        {
            RuleFor(x => x.ShipperName).MaximumLength(50);
            RuleFor(x => x.ShipperName).NotNull();
        }
    }
}
