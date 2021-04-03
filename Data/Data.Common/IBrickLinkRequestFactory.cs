using Data.Common.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace Data.Common
{
    public interface IBrickLinkRequestFactory
    {
        Task<HttpResponseMessage> GetResponse(string url, User user);
    }
}