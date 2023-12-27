using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("O campo nome é obrigatório");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email inválido");
            RuleFor(x => x.Email).NotNull().WithMessage("O campo email é obrigatório");
            RuleFor(x => x.Password).NotNull().WithMessage("O campo senha é obrigatório");
        }
    }
}
