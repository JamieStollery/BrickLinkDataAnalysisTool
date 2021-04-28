using Data.Common;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class UsersDatabaseInitializer : IDatabaseInitializer
    {
        private readonly IDapperWrapper _dapperWrapper;

        public UsersDatabaseInitializer(IDapperWrapper dapperWrapper)
        {
            _dapperWrapper = dapperWrapper;
        }

        public async Task CreateTables()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Users(
                            Username VARCHAR(20),
                            Password VARCHAR(20),
                            ConsumerKey VARCHAR(50),
                            ConsumerSecret VARCHAR(50),
                            TokenValue VARCHAR(50),
                            TokenSecret VARCHAR(50)
                        )";
            await _dapperWrapper.ExecuteAsync(sql);
        }
    }
}
