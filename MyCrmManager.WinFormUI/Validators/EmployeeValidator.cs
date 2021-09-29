using FluentValidation;
using MyCrmManager.Domain;
using MyCrmManager.WinFormUI.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Validators
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} cannot be empty.")
                .Length(2, 50).WithMessage("Please provide a valid {PropertyName}.")
                .Must(MyValidationExtension.BeAValidName).WithMessage("{PropertyName} contains invalid charachters.");
            RuleFor(e => e.Lastname).NotEmpty();
            RuleFor(e => e.Birthdate)
                .NotEmpty()
                .Must(MyValidationExtension.BeAValidAge).WithMessage("Invalid {ProperyName}");
            RuleFor(e => e.Email).NotEmpty().EmailAddress();
            RuleFor(e => e.PhoneNumber)
                .NotEmpty()
                .Length(10)
                .Must(MyValidationExtension.BeAValidNumber);
            RuleFor(e => e.NationalId)
                .NotEmpty()
                .Length(11)
                .Must(MyValidationExtension.BeAValidNumber);
            RuleFor(e => e.Password)
                .NotEmpty()
                .Length(3, 50);
        }

        
    }
}
