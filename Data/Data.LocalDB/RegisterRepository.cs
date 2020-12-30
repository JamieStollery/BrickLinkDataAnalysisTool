using Dapper;
using Data.Common.Model;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class RegisterRepository
    {
        private readonly IDbConnection _connection;

        public RegisterRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<bool> Register(User user)
        {
            var sql = @"INSERT INTO Users
                        VALUES(@Username, @Password, @ConsumerKey, @ConsumerSecret, @TokenValue, @TokenSecret)";
            try
            {
                await _connection.ExecuteAsync(sql, new { user.Username, user.Password, user.ConsumerKey, user.ConsumerSecret, user.TokenValue, user.TokenSecret });
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
