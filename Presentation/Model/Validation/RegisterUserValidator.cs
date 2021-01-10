using FluentValidation;

namespace Presentation.Model.Validation
{
    public class RegisterUserValidator : LoginUserValidator
    {
        public RegisterUserValidator()
        {
            RuleFor(user => user.ConsumerKey).Must(consumerKey => !string.IsNullOrWhiteSpace(consumerKey))
                .WithMessage("Consumer Key field must contain a value");
            RuleFor(user => user.ConsumerSecret).Must(consumerSecret => !string.IsNullOrWhiteSpace(consumerSecret))
                .WithMessage("Consumer Secret field must contain a value");
            RuleFor(user => user.TokenValue).Must(tokenValue => !string.IsNullOrWhiteSpace(tokenValue))
                .WithMessage("Token Value field must contain a value");
            RuleFor(user => user.TokenSecret).Must(tokenSecret => !string.IsNullOrWhiteSpace(tokenSecret))
                .WithMessage("Token Secret field must contain a value");
        }
    }
}
