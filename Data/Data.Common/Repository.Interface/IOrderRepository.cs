using Data.Common.Model.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Common.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderDto>> GetOrders();
        Task<IEnumerable<OrderItemDto>> GetItems(int orderId);
    }
}
