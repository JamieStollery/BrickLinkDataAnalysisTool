using Data.Common.Model.Dto;
using Data.Common.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.BrickLinkAPI
{
    public class OrderRepository : IOrderRepository
    {
        public Task<IEnumerable<OrderDto>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItemDto>> GetItems(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
