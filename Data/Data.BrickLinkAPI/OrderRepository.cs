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
            var request = _requestFactory.Create("orders?status=-purged", _userOption.Value);

            var response = await request.GetResponseAsync();

            JObject json = null;
            using (var stream = response.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = JObject.Parse(jsonString);
            }

            var meta = json.SelectToken("meta");
            return meta?.Value<int>("code") == 200 ?
                json.SelectToken("data").Select(token => token.ToObject<OrderDto>()) :
                null;
        }

        public async Task<IEnumerable<OrderItemDto>> GetItems(int orderId)
        {
            var request = _requestFactory.Create($"orders/{orderId}/items", _userOption.Value);

            var response = await request.GetResponseAsync();

            JObject json = null;
            using (var stream = response.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = JObject.Parse(jsonString);
            }

            var meta = json.SelectToken("meta");
            return meta?.Value<int>("code") == 200 ?
                json.SelectToken("data").SelectMany(token => token.Select(token => token.ToObject<OrderItemDto>())) :
                null;
        }
    }
}
