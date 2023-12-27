using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validator;

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            user.Email = "lucasnithael32@gmail.com";

            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);

            if(!results.IsValid)
            {
                foreach(var item in results.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }

            return View("Index", user);
        }
        [HttpPost]
        public IActionResult Teste(UserViewModel user)
        {
            user.Email = "email enviado";
            return View("Index", user);
        }
    }
}
