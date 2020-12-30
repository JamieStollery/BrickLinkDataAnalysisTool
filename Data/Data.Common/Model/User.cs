using Data.Common.Model.Validation;
using FluentValidation;
using FluentValidation.Results;
using System;

namespace Data.Common.Model
{
    public class User
    {
        private readonly Func<UserValidationType, IValidator<User>> _validatorFactory;

        public User(Func<UserValidationType, IValidator<User>> validatorFactory)
        {
            _validatorFactory = validatorFactory;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string TokenValue { get; set; }
        public string TokenSecret { get; set; }

        public bool IsLoggedIn => !string.IsNullOrEmpty(Username);

        public ValidationResult Validate(UserValidationType validationType) => _validatorFactory(validationType).Validate(this);

        public void Invalidate()
        {
            Username = string.Empty;
            Password = string.Empty;
            ConsumerKey = string.Empty;
            ConsumerSecret = string.Empty;
            TokenValue = string.Empty;
            TokenSecret = string.Empty;
        }
    }
}
