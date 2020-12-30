using Dapper;
using Data.Common.Model;
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

        public async Task<bool> Login(User user)
        {
            var sql = @"SELECT COUNT(1) 
                        FROM Users
                        WHERE Username = @Username
                        AND Password = @Password";

            return await _connection.QuerySingleAsync<bool>(sql, new { user.Username, user.Password });
        } 
    }
}
