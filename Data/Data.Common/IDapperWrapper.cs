using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Common
{
    public interface IDapperWrapper
    {
        Task<int> ExecuteAsync(string sql, object param = null);
        Task<IEnumerable<TReturn>> QueryAsync<T1, T2, TReturn>(string sql, Func<T1, T2, TReturn> map, object param = null, string splitOn = null);
        Task<IEnumerable<TReturn>> QueryAsync<T1, T2, T3, TReturn>(string sql, Func<T1, T2, T3, TReturn> map, object param = null, string splitOn = null);
        Task<T> QuerySingleAsync<T>(string sql, object param = null);
    }
}