using Data.Common.Model;
using System.Threading.Tasks;

namespace Data.Common.Repository.Interface
{
    public interface IRegisterRepository
    {
        Task<bool> Register(User user);
    }
}