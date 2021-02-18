using System.Net;

namespace Data.Common
{
    public interface IBrickLinkRequestFactory
    {
        HttpWebRequest Create(string url);
    }
}