using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Data.Common
{
    public class DapperWrapper : IDapperWrapper
    {
        private readonly IDbConnection _connection;

        public DapperWrapper(IDbConnection connection)
        {
            _connection = connection;
        }

        public Task<int> ExecuteAsync(string sql, object param = null) => 
            _connection.ExecuteAsync(sql, param);
        public Task<IEnumerable<TReturn>> QueryAsync<T1, T2, TReturn>(string sql, 
            Func<T1, T2, TReturn> map, object param = null, string splitOn = null) => 
            _connection.QueryAsync(sql, map, param, splitOn: splitOn);
        public Task<IEnumerable<TReturn>> QueryAsync<T1, T2, T3, TReturn>(string sql, 
            Func<T1, T2, T3, TReturn> map, object param = null, string splitOn = null) => 
            _connection.QueryAsync(sql, map, param, splitOn: splitOn);
        public Task<T> QuerySingleAsync<T>(string sql, object param = null) => 
            _connection.QuerySingleAsync<T>(sql, param);
    }
}
