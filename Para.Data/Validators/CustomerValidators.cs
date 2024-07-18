using FluentValidation;
using Para.Data.Domain;
using System.Text.RegularExpressions;

namespace Para.Data.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(50).WithMessage("First name cannot exceed 50 characters.");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(50).WithMessage("Last name cannot exceed 50 characters.");

            RuleFor(c => c.IdentityNumber)
                .NotEmpty().WithMessage("Identity number is required.")
                .MaximumLength(20).WithMessage("Identity number cannot exceed 20 characters.")
                .Matches(@"^[A-Za-z0-9]+$").WithMessage("Identity number can only contain letters and numbers.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(100).WithMessage("Email cannot exceed 100 characters.");

            RuleFor(c => c.CustomerNumber)
                .GreaterThan(0).WithMessage("Customer number must be greater than 0.");

            RuleFor(c => c.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.")
                .LessThan(DateTime.Today).WithMessage("Date of birth cannot be in the future.");
        }
    }
}