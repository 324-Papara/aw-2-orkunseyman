using FluentValidation;
using Para.Data.Domain;

namespace Para.Data.Validators
{
    public class CustomerDetailValidator : AbstractValidator<CustomerDetail>
    {
        public CustomerDetailValidator()
        {
            RuleFor(cd => cd.CustomerId)
                .NotEmpty().WithMessage("Customer ID is required.")
                .GreaterThan(0).WithMessage("Customer ID must be greater than 0.");

            RuleFor(cd => cd.FatherName)
                .MaximumLength(50).WithMessage("Father's name cannot exceed 50 characters.");

            RuleFor(cd => cd.MotherName)
                .MaximumLength(50).WithMessage("Mother's name cannot exceed 50 characters.");

            RuleFor(cd => cd.EducationStatus)
                .MaximumLength(50).WithMessage("Education status cannot exceed 50 characters.");

            RuleFor(cd => cd.MontlyIncome)
                .MaximumLength(20).WithMessage("Monthly income cannot exceed 20 characters.");

            RuleFor(cd => cd.Occupation)
                .MaximumLength(50).WithMessage("Occupation cannot exceed 50 characters.");
        }
    }
}