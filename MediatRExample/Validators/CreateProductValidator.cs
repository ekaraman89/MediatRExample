using FluentValidation;
using MediatRExample.Mediatr.Commands;

namespace MediatRExample.Validators
{
    public class CreateProductValidator : AbstractValidator<CreateProduct.Command>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("This field is required")
                .NotEmpty().WithMessage("This field is required")
                .MinimumLength(3).WithMessage("Min characters 3");

            RuleFor(x => x.Price)
                .NotNull().WithMessage("This field is required")
                .NotEmpty().WithMessage("This field is required")
                .GreaterThan(5).WithMessage("Min value is 5");


        }
    }
}
