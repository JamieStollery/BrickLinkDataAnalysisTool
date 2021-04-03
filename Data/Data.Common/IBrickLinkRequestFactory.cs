using Data.Common.Model;
using System.Net;

namespace Data.Common
{
    public interface IBrickLinkRequestFactory
    {
        HttpWebRequest Create(string url, User user);
    }
}