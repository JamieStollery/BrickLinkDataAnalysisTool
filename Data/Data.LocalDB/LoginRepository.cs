using Data.Common;
using Data.Common.Model;
using Data.Common.Repository.Interface;
using FluentValidation;
using System.Linq;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IDapperWrapper _dapperWrapper;
        private readonly IValidator<User> _validator;

        public LoginRepository(IDapperWrapper dapperWrapper, IValidator<User> validator)
        {
            _dapperWrapper = dapperWrapper;
            _validator = validator;
        }

        public async Task<(bool result, string error)> Login(User user)
        {
            (bool result, string error) response = (false, string.Empty);

            var validationResult = await _validator.ValidateAsync(user);
            response.result = validationResult.IsValid;

            if (!response.result)
            {
                response.error = validationResult.Errors.First().ErrorMessage;
                return response;
            }
            var sql = @"SELECT ConsumerKey, ConsumerSecret, TokenValue, TokenSecret
                        FROM Users
                        WHERE Username = @Username";

            var (consumerKey, consumerSecret, tokenValue, tokenSecret) = await _dapperWrapper.QuerySingleAsync<(string consumerKey, string consumerSecret, string tokenValue, string tokenSecret)>(sql, new { user.Username });

            user.ConsumerKey = consumerKey;
            user.ConsumerSecret = consumerSecret;
            user.TokenValue = tokenValue;
            user.TokenSecret = tokenSecret;

            return response;
        }
    }
}