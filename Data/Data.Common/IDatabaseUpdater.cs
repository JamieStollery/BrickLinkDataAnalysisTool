using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Common
{
    public interface IDatabaseUpdater
    {
        Task ClearDatabase();
        Task<(int count, IAsyncEnumerable<Task> tasks)> UpdateDatabase();
    }
}