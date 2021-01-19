using Data.Common;
using Data.Common.Model;
using Data.Common.Repository.Interface;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class UserRepository : ILoginRepository, IRegisterRepository
    {
        private readonly IDapperWrapper _dapperWrapper;

        public UserRepository(IDapperWrapper dapperWrapper)
        {
            _dapperWrapper = dapperWrapper;
        }

        public async Task<bool> Login(User user)
        {
            var sql = @"SELECT COUNT(1) 
                        FROM Users
                        WHERE Username = @Username
                        AND Password = @Password";

            return await _dapperWrapper.QuerySingleAsync<bool>(sql, new { user.Username, user.Password });
        }

        public async Task<bool> Register(User user)
        {
            var sql = @"INSERT INTO Users
                        VALUES(@Username, @Password, @ConsumerKey, @ConsumerSecret, @TokenValue, @TokenSecret)";
            try
            {
                await _dapperWrapper.ExecuteAsync(sql, new { user.Username, user.Password, user.ConsumerKey, user.ConsumerSecret, user.TokenValue, user.TokenSecret });
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
