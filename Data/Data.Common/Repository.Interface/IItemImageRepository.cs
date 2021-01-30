using Data.Common.Model.Dto;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Data.Common.Repository.Interface
{
    public interface IItemImageRepository
    {
        Task<IEnumerable<ColorDto>> GetColors();
        Task<Stream> GetItemImage(string type, string no, int colorId);
    }
}
