using Data.Common.Model.Dto;
using Data.Common.Repository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class OrderRepository : IOrderRepository, IItemImageRepository
    {
        public Task<IEnumerable<OrderDto>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItemDto>> GetItems(int orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<Stream> GetItemImage(string type, string no, int colorId)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://img.bricklink.com/P/5/3832.jpg");
            request.Method = "GET";
            var response = request.GetResponse();
            return response.GetResponseStream();
        }
    }
}
