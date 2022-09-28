using bookstore.Entities.Concrete;
using FluentValidation;

namespace bookstore.Business.ValidationRules.FluentValidation
{
    public class AppIdentityValidator : AbstractValidator<AppIdentityUser>
    {
        public AppIdentityValidator()
        {
            RuleFor(x => x.Addresses).NotNull();
            RuleFor(x => x.Email).NotNull();
            RuleFor(x => x.Name).NotNull();
        }
    }
}
