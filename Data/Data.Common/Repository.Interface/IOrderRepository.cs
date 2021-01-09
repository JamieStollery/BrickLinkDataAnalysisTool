using Data.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Common.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrders();
    }
}
