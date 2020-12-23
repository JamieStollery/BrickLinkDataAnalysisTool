using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class LoginRepository
    {
        private readonly IDbConnection _connection;

        public LoginRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<bool> Login(string username, string password)
        {
            var sql = @"SELECT COUNT(1) 
                        FROM Users
                        WHERE Username = @username
                        AND Password = @password";

            return await _connection.QuerySingleAsync<bool>(sql, new { username, password });
        } 
    }
}
