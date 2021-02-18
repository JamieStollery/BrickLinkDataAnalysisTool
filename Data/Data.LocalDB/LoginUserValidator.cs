using Data.Common;
using Data.Common.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.LocalDB
{
    public class LoginUserValidator : AbstractValidator<User>
    {
        public LoginUserValidator(IDapperWrapper dapperWrapper)
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.Username)
                .Must(username => !string.IsNullOrWhiteSpace(username)).WithMessage("Username field must contain a value")
                .MustAsync(async (username, cancellation) =>
                {
                    var sql = @"SELECT COUNT(1) 
                                FROM Users
                                WHERE Username = @username";
                    return await dapperWrapper.QuerySingleAsync<bool>(sql, new { username });
                }).WithMessage("Username does not exist!");
;
            RuleFor(user => user.Password)
                .Must(password => !string.IsNullOrWhiteSpace(password)).WithMessage("Password field must contain a value")
                .MustAsync(async (user, password, cancellation) =>
                {
                    var sql = @"SELECT COUNT(1) 
                                FROM Users
                                WHERE Username = @Username
                                AND Password = @password";

                    return await dapperWrapper.QuerySingleAsync<bool>(sql, new { user.Username, password });
                }).WithMessage("Incorrect Password!");
        }
    }
}
