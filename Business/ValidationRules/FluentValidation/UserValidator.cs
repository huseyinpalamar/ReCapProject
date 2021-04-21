using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(3);
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.Email).NotEmpty();
            //RuleFor(u => u.Email).Must(EndsWithCom).WithMessage("Invalid email");
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8);
            //RuleFor(u => u.Password.Length).ExclusiveBetween(8,15);
        }

        private bool EndsWithCom(string arg)
        {
            return arg.EndsWith(".com");
        }
    }
}
