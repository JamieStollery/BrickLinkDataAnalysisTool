using Data.Common;
using Data.Common.Model;
using OAuth;
using System.Net;

namespace Data.BrickLinkAPI
{
    public class BrickLinkRequestFactory : IBrickLinkRequestFactory
    {
        private const string URL_PREFIX = "http://api.bricklink.com/api/store/v1/";

        public HttpWebRequest Create(string url, User user)
        {
            var client = OAuthRequest.ForProtectedResource("GET", 
                user.ConsumerKey, user.ConsumerSecret, user.TokenValue, user.TokenSecret);
            client.RequestUrl = URL_PREFIX + url;

            var request = (HttpWebRequest)WebRequest.Create(client.RequestUrl);
            request.Headers.Add("Authorization", client.GetAuthorizationHeader());
            return request;
        }
    }
}
