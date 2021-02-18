using Data.Common;
using Data.Common.Model;
using Data.Common.Repository.Interface;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly IDapperWrapper _dapperWrapper;
        private readonly IValidator<User> _validator;

        public RegisterRepository(IDapperWrapper dapperWrapper, IValidator<User> validator)
        {
            _dapperWrapper = dapperWrapper;
            _validator = validator;
        }

        public async Task<(bool result, string error)> Register(User user)
        {
            var validationResult = await _validator.ValidateAsync(user);
            if (!validationResult.IsValid)
            {
                return (false, validationResult.Errors.First().ErrorMessage);
            }

            var sql = @"INSERT INTO Users
                        VALUES(@Username, @Password, @ConsumerKey, @ConsumerSecret, @TokenValue, @TokenSecret)";
            await _dapperWrapper.ExecuteAsync(sql, new { user.Username, user.Password, user.ConsumerKey, user.ConsumerSecret, user.TokenValue, user.TokenSecret });
            return (true, string.Empty);
        }
    }
}
