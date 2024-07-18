using FluentValidation;
using Para.Data.Domain;

namespace Para.Data.Validators
{
    public class CustomerAddressValidator : AbstractValidator<CustomerAddress>
    {
        public CustomerAddressValidator()
        {
            RuleFor(ca => ca.CustomerId)
                .NotEmpty().WithMessage("Customer ID is required.")
                .GreaterThan(0).WithMessage("Customer ID must be greater than 0.");

            RuleFor(ca => ca.Country)
                .NotEmpty().WithMessage("Country is required.")
                .MaximumLength(50).WithMessage("Country name cannot exceed 50 characters.");

            RuleFor(ca => ca.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(50).WithMessage("City name cannot exceed 50 characters.");

            RuleFor(ca => ca.AddressLine)
                .NotEmpty().WithMessage("Address line is required.")
                .MaximumLength(100).WithMessage("Address line cannot exceed 100 characters.");

            RuleFor(ca => ca.ZipCode)
                .NotEmpty().WithMessage("Zip code is required.")
                .MaximumLength(20).WithMessage("Zip code cannot exceed 10 characters.");

            RuleFor(ca => ca.IsDefault)
                .NotNull().WithMessage("IsDefault flag must be set.");
        }
    }
}