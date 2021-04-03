using Data.Common;
using Data.Common.Model;
using Data.Common.Model.Dto;
using Data.Common.Option;
using Data.Common.Repository.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IBrickLinkRequestFactory _requestFactory;
        private readonly IOption<User> _userOption;

        public OrderRepository(IBrickLinkRequestFactory requestFactory, IOption<User> userOption)
        {
            _requestFactory = requestFactory;
            _userOption = userOption;
        }

        public async Task<IEnumerable<OrderDto>> GetOrders()
        {
            var response = await _requestFactory.GetResponse("orders?status=-purged", _userOption.Value);

            JObject json = null;
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = !string.IsNullOrEmpty(jsonString) ? JObject.Parse(jsonString) : null;
            }

            var meta = json?.SelectToken("meta");
            return meta?.Value<int>("code") == 200 ?
                json?.SelectToken("data")?.Select(token => token.ToObject<OrderDto>()) :
                null;
        }

        public async Task<IEnumerable<OrderItemDto>> GetItems(int orderId)
        {
            var response = await _requestFactory.GetResponse($"orders/{orderId}/items", _userOption.Value);

            JObject json = null;
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = !string.IsNullOrEmpty(jsonString) ? JObject.Parse(jsonString) : null;
            }

            var meta = json.SelectToken("meta");
            return meta?.Value<int>("code") == 200 ?
                json?.SelectToken("data")?.SelectMany(token => token.Select(token => token.ToObject<OrderItemDto>())) :
                null;
        }
    }
}
