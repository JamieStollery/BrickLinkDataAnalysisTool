using Dapper;
using Data.Common.Model.Dto;
using Data.Common.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Data.LocalDB
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDbConnection _connection;

        public OrderRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<OrderDto>> GetOrders()
        {
            var sql = @"SELECT * FROM Orders AS o
                        INNER JOIN Payments AS p ON o.Order_id = p.Order_id
                        INNER JOIN Costs AS c ON o.Order_id = c.Order_id";

            return await _connection.QueryAsync<OrderDto, PaymentDto, CostDto, OrderDto>(sql,
                (order, payment, cost) =>
                {
                    order.Payment = payment;
                    order.Cost = cost;
                    return order;
                },
                splitOn: "Order_id");
        }

        public async Task<IEnumerable<OrderItemDto>> GetItems(int orderId)
        {
            var sql = @"SELECT * FROM OrderItems AS oi
                        INNER JOIN Items AS i ON oi.Item_no = i.No
                        WHERE oi.Order_id = @Order_Id";

            return await _connection.QueryAsync<OrderItemDto, ItemDto, OrderItemDto>(sql,
                (orderItem, item) =>
                {
                    orderItem.Item = item;
                    return orderItem;
                },
                new { Order_id = orderId },
                splitOn: "No");
        }
    }
}
