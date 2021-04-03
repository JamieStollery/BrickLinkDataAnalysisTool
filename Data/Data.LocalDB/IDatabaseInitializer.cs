using System.Threading.Tasks;

namespace Data.LocalDB
{
    public interface IDatabaseInitializer
    {
        Task CreateTables();
    }
}