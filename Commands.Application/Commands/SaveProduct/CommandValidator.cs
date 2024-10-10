using FluentValidation;

namespace Commands.Application.Commands.SaveProduct;

public class CommandValidator : AbstractValidator<Command>
{
    public CommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Название обязательно к заполнению.")
            .MaximumLength(50).WithMessage("Максимальная длина названия 50 символов.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Описание обязательно к заполнению.")
            .MaximumLength(250).WithMessage("Максимальная длина описания 250 символов.");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Цена должна быть больше 0.");

        RuleFor(x => x.PriceWithDiscount)
            .LessThan(x => x.Price).WithMessage("Цена со скидкой должна быть меньше первоначальной цены.");

        RuleFor(x => x.Image)
            .NotNull().WithMessage("Выберите изображение")
            .NotEmpty().WithMessage("Выберите изображение");

    }
}