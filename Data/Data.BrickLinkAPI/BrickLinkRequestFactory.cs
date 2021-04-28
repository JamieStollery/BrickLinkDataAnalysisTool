using Data.Common;
using Data.Common.Model;
using OAuth;
using System.Net.Http;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class BrickLinkRequestFactory : IBrickLinkRequestFactory
    {
        private const string URL_PREFIX = "http://api.bricklink.com/api/store/v1/";

        public Task<HttpResponseMessage> GetResponse(string url, User user)
        {
            var client = OAuthRequest.ForProtectedResource("GET", 
                user.ConsumerKey, user.ConsumerSecret, user.TokenValue, user.TokenSecret);
            client.RequestUrl = URL_PREFIX + url;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", client.GetAuthorizationHeader());
            return httpClient.GetAsync(client.RequestUrl);
        }
    }
}
