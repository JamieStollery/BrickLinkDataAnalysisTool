using Data.Common;
using Data.Common.Model;
using OAuth;
using System.Net;

namespace Data.BrickLinkAPI
{
    public class BrickLinkRequestFactory : IBrickLinkRequestFactory
    {
        private const string URL_PREFIX = "http://api.bricklink.com/api/store/v1/";
        private readonly User _user;

        public BrickLinkRequestFactory(User user)
        {
            _user = user;
        }

        public HttpWebRequest Create(string url)
        {
            var client = OAuthRequest.ForProtectedResource("GET", _user.ConsumerKey, _user.ConsumerSecret, _user.TokenValue, _user.TokenSecret);
            client.RequestUrl = URL_PREFIX + url;
            var request = (HttpWebRequest)WebRequest.Create(client.RequestUrl);
            request.Headers.Add("Authorization", client.GetAuthorizationHeader());
            return request;
        }
    }
}
