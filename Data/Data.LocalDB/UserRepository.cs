using Dapper;
using Data.Common.Model;
using Data.Common.Repository.Interface;
using System.Data;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class UserRepository : ILoginRepository, IRegisterRepository
    {
        private readonly IDbConnection _connection;

        public UserRepository(IDbConnection connection)
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
