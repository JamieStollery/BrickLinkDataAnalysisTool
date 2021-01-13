using System.IO;
using System.Threading.Tasks;

namespace Data.Common.Repository.Interface
{
    public interface IItemImageRepository
    {
        Task<Stream> GetItemImage(string type, string no, int colorId);
    }
}
