using FluentValidation;

namespace Data.Common.Model.Validation
{
    public class LoginUserValidator : AbstractValidator<User>
    {
        public LoginUserValidator()
        {
            RuleFor(user => user.Username).Must(username => !string.IsNullOrWhiteSpace(username))
                .WithMessage("Username field must contain a value");
            RuleFor(user => user.Password).Must(password => !string.IsNullOrWhiteSpace(password))
                .WithMessage("Password field must contain a value");
        }
    }
}
