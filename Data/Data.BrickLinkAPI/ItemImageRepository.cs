using Data.Common;
using Data.Common.Model;
using Data.Common.Model.Dto;
using Data.Common.Option;
using Data.Common.Repository.Interface;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class ItemImageRepository : IItemImageRepository
    {
        private readonly IBrickLinkRequestFactory _requestFactory;
        private readonly IOption<User> _userOption;

        public ItemImageRepository(IBrickLinkRequestFactory requestFactory, IOption<User> userOption)
        {
            _requestFactory = requestFactory;
            _userOption = userOption;
        }

        public async Task<Stream> GetItemImage(string type, string no, int colorId)
        {
            var response = await _requestFactory.GetResponse($"items/{type}/{no}/images/{colorId}", _userOption.Value);

            JObject json = null;
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = !string.IsNullOrEmpty(jsonString) ? JObject.Parse(jsonString) : null;
            }
            
            var meta = json?.SelectToken("meta");
            if (meta?.Value<int>("code") == 200)
            {
                var url = json?.SelectToken("data")?.Value<string>("thumbnail_url");
                if (!string.IsNullOrEmpty(url))
                {
                    var client = new HttpClient();
                    return await client.GetStreamAsync($"http:{url}");
                }
            }
            return null;
        }

        public async Task<IEnumerable<ColorDto>> GetColors()
        {
            var response = await _requestFactory.GetResponse("colors", _userOption.Value);

            JObject json = null;
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = !string.IsNullOrEmpty(jsonString) ? JObject.Parse(jsonString) : null;
            }
            
            var meta = json?.SelectToken("meta");
            return meta?.Value<int>("code") == 200 ? json?.SelectToken("data")?.Select(token => token.ToObject<ColorDto>()) : null;
        }
    }
}
