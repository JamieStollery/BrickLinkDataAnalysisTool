using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class UserRepository
    {
        private readonly IDbConnection _connection;

        public UserRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<bool> Login(string username)
        {
            var sql = @"SELECT COUNT(1) 
                        FROM Users
                        WHERE Username = @username";

            return await _connection.QuerySingleAsync<bool>(sql, new { username });
        } 
    }
}
