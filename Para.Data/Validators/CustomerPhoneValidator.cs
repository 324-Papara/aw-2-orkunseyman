using FluentValidation;
using Para.Data.Domain;

namespace Para.Data.Validators
{
    public class CustomerPhoneValidator : AbstractValidator<CustomerPhone>
    {
        public CustomerPhoneValidator()
        {
            RuleFor(cp => cp.CustomerId)
                .NotEmpty().WithMessage("Customer ID is required.")
                .GreaterThan(0).WithMessage("Customer ID must be greater than 0.");

            RuleFor(cp => cp.CountyCode)
                .NotEmpty().WithMessage("Country code is required.")
                .Length(3).WithMessage("Country code must be exactly 3 characters.");
            
            RuleFor(cp => cp.Phone)
                .NotEmpty().WithMessage("Phone number is required.")
                .MaximumLength(15).WithMessage("Phone number cannot exceed 15 characters.");

            RuleFor(cp => cp.IsDefault)
                .NotNull().WithMessage("IsDefault flag must be set.");
        }
    }
}