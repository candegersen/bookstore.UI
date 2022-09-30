using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using FluentValidation;

namespace bookstore.Business.ValidationRules.FluentValidation
{
    public class AppIdentityValidator : AbstractValidator<RegisterDto>
    {
        public AppIdentityValidator()
        {
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.Email).NotNull();
            RuleFor(x => x.Password).NotNull();
            RuleFor(x => x.ConfirmPassword).NotNull();
        }
    }
}
