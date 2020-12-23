using Dapper;
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

        public async Task Register(string username, string password, string consumerKey, string consumerSecret, string tokenValue, string tokenSecret)
        {
            var sql = @"INSERT INTO Users
                        VALUES(@username, @password, @consumerKey, @consumerSecret, @tokenValue, @tokenSecret)";

            await _connection.ExecuteAsync(sql, new { username, password, consumerKey, consumerSecret, tokenValue, tokenSecret });
        }
    }
}
