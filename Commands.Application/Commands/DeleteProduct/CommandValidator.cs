using FluentValidation;

namespace Commands.Application.Commands.DeleteProduct;

public class CommandValidator : AbstractValidator<Command>
{
    public CommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("Id не может быть пустым.");
    }
}