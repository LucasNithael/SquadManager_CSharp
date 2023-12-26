using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("O campo nome é obrigatório");
            RuleFor(x => x.Email).NotEmpty().WithMessage("O campo email é obrigatório");
            RuleFor(x => x.Password).NotEmpty().WithMessage("O campo senha é obrigatório");
        }
    }
}
