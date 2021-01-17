using Data.Common.Model.Dto;
using Data.Common.Repository.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BrickLinkRequestFactory _requestFactory;

        public OrderRepository(BrickLinkRequestFactory requestFactory)
        {
            _requestFactory = requestFactory;
        }

        public async Task<IEnumerable<OrderDto>> GetOrders()
        {
            var url = $"{_requestFactory.UrlPrefix}orders?status=-purged";
            var request = _requestFactory.Create(url);

            var response = await request.GetResponseAsync();

            JObject json = null;
            using (var stream = response.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = JObject.Parse(jsonString);
            }

            var meta = json.SelectToken("meta");
            if (meta.Value<int>("code") == 200)
            {
                return json.SelectToken("data").Select(token => token.ToObject<OrderDto>());
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task<IEnumerable<OrderItemDto>> GetItems(int orderId)
        {
            var url = $"{_requestFactory.UrlPrefix}orders/{orderId}/items";
            var request = _requestFactory.Create(url);

            var response = await request.GetResponseAsync();

            JObject json = null;
            using (var stream = response.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                string jsonString = reader.ReadToEnd();
                json = JObject.Parse(jsonString);
            }

            var meta = json.SelectToken("meta");
            if (meta.Value<int>("code") == 200)
            {
                return json.SelectToken("data").SelectMany(token => token.Select(token => token.ToObject<OrderItemDto>()));
            }
            else
            {
                throw new NotImplementedException();
            }
        }

    }
}
