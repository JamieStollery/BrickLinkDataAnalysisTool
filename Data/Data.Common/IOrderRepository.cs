using Data.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Common
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrders();
    }
}
