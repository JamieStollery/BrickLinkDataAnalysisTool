using Data.Common.Model;
using System.Threading.Tasks;

namespace Data.Common.Repository.Interface
{
    public interface ILoginRepository
    {
        Task<(bool result, string error)> Login(User user);
    }
}