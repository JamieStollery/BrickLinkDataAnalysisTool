using Data.Common;
using Data.Common.Model;
using FluentValidation;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;

namespace Data.LocalDB
{
    public class RegisterUserValidator : AbstractValidator<User>
    {
        public RegisterUserValidator(IDapperWrapper dapperWrapper, IBrickLinkRequestFactory requestFactory)
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.Username)
                .Must(username => !string.IsNullOrWhiteSpace(username)).WithMessage("Username field must contain a value")
                .MustAsync(async (username, cancellation) =>
                {
                    var sql = @"SELECT COUNT(1) 
                                FROM Users
                                WHERE Username = @username";
                    return !await dapperWrapper.QuerySingleAsync<bool>(sql, new { username });
                }).WithMessage("Username already exists!");
;
            RuleFor(user => user.Password)
                .Must(password => !string.IsNullOrWhiteSpace(password)).WithMessage("Password field must contain a value");

            RuleFor(user => user.ConsumerKey)
                .Must(consumerKey => !string.IsNullOrWhiteSpace(consumerKey)).WithMessage("Consumer Key field must contain a value");

            RuleFor(user => user.ConsumerSecret)
                .Must(consumerSecret => !string.IsNullOrWhiteSpace(consumerSecret)).WithMessage("Consumer Secret field must contain a value");

            RuleFor(user => user.TokenValue)
                .Must(tokenValue => !string.IsNullOrWhiteSpace(tokenValue)).WithMessage("Token Value field must contain a value");

            RuleFor(user => user.TokenSecret)
                .Must(tokenSecret => !string.IsNullOrWhiteSpace(tokenSecret)).WithMessage("Token Secret field must contain a value");

            RuleFor(user => user)
                .MustAsync(async (user, cancellation) =>
                {
                    var response = await requestFactory.GetResponse("orders", user);
                    
                    JObject json = null;
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        var reader = new StreamReader(stream, Encoding.UTF8);
                        string jsonString = reader.ReadToEnd();
                        json = JObject.Parse(jsonString);
                    }

                    var meta = json.SelectToken("meta");
                    return meta.Value<int>("code") == 200;
                }).WithMessage("Invalid API credentials");
        }
    }
}
