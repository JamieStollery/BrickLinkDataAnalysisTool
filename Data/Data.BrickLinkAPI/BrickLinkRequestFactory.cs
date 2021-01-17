using Data.Common.Model;
using OAuth;
using System.Net;

namespace Data.BrickLinkAPI
{
    public class BrickLinkRequestFactory
    {
        private readonly User _user;

        public BrickLinkRequestFactory(User user)
        {
            _user = user;
        }

        public string UrlPrefix => "http://api.bricklink.com/api/store/v1/";

        public HttpWebRequest Create(string url)
        { 
            var client = OAuthRequest.ForProtectedResource("GET", _user.ConsumerKey, _user.ConsumerSecret, _user.TokenValue, _user.TokenSecret);
            client.RequestUrl = url;
            var request = (HttpWebRequest)WebRequest.Create(client.RequestUrl);
            request.Headers.Add("Authorization", client.GetAuthorizationHeader());
            return request;
        }
    }
}
