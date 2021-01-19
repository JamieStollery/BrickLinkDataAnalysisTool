using Data.Common.Model.Dto;
using Data.Common.Repository.Interface;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Common
{
    public class DatabaseUpdater : IDatabaseUpdater
    {
        private readonly IDapperWrapper _dapperWrapper;
        private readonly IOrderRepository _orderRepository;
        public DatabaseUpdater(IDapperWrapper dapperWrapper, IOrderRepository orderRepository)
        {
            _dapperWrapper = dapperWrapper;
            _orderRepository = orderRepository;
        }

        public async Task<(int count, IAsyncEnumerable<Task> tasks)> UpdateDatabase()
        {   
            var orders = (await _orderRepository.GetOrders()).ToList();
            var tasks = ReplaceOrdersAndItems(orders);
            return (orders.Count, tasks);
        }

        private async IAsyncEnumerable<Task> ReplaceOrdersAndItems(IEnumerable<OrderDto> orders)
        {
            foreach(var order in orders)
            {
                // Replace the order
                await ReplaceOrder(order);
                // Get order items
                var orderItems = await _orderRepository.GetItems(order.Order_id);
                // Replace the order items
                var tasks = orderItems.Select(orderItem => InsertOrderItemIfNotExists(orderItem, order.Order_id));
                // Wait for all order items to be inserted
                yield return Task.WhenAll(tasks.ToArray());
            }
        } 

        public async Task ClearDatabase()
        {
            var sql = @"DELETE FROM Costs;
                        DELETE FROM Payments;
                        DELETE FROM OrderItems;
                        DELETE FROM Items;
                        DELETE FROM Orders;";
            await _dapperWrapper.ExecuteAsync(sql);
        }

        private async Task ReplaceOrder(OrderDto order)
        {
            var sql = @"REPLACE INTO Orders VALUES (@Order_id, @Buyer_name, @Date_ordered, @Seller_name, @Status, @Store_name, @Total_count, @Unique_count)";
            await _dapperWrapper.ExecuteAsync(sql, new
            {
                order.Order_id,
                order.Buyer_name,
                order.Date_ordered,
                order.Seller_name,
                order.Status,
                order.Store_name,
                order.Total_count,
                order.Unique_count
            });

            sql = @"INSERT INTO Payments
                    SELECT @Order_id, @Method, @Status, @Date_paid, @Currency_code
                    WHERE NOT EXISTS(SELECT * FROM Payments WHERE Order_id = @Order_id)";
            await _dapperWrapper.ExecuteAsync(sql, new
            {
                order.Order_id,
                order.Payment?.Method,
                order.Payment?.Status,
                order.Payment?.Date_paid,
                order.Payment?.Currency_code
            });

            sql = @"INSERT INTO Costs
                    SELECT @Order_id, @Subtotal, @Grand_total, @Currency_code
                    WHERE NOT EXISTS(SELECT * FROM Costs WHERE Order_id = @Order_id)";
            await _dapperWrapper.ExecuteAsync(sql, new
            {
                order.Order_id,
                order.Cost?.Subtotal,
                order.Cost?.Grand_total,
                order.Cost?.Currency_code
            });
        }

        private async Task InsertOrderItemIfNotExists(OrderItemDto orderItem, int orderId)
        {
            var sql = @"INSERT INTO Items
                        SELECT @No, @Name, @Type, @CategoryID
                        WHERE NOT EXISTS(SELECT * FROM Items WHERE No = @No)";

            await _dapperWrapper.ExecuteAsync(sql, new
            {
                orderItem.Item?.No,
                orderItem.Item?.Name,
                orderItem.Item?.Type,
                orderItem.Item?.CategoryID
            });

            sql = @"INSERT INTO OrderItems
                    SELECT @Order_id, @Inventory_id, @No, @Color_id, @Quantity, @New_or_used, @Completeness, @Unit_price, @Unit_price_final,
                        @Disp_unit_price, @Disp_unit_price_final, @Currency_code, @Disp_currency_code, @Description, @Remarks
                    WHERE NOT EXISTS(SELECT * FROM OrderItems WHERE Order_id = @Order_id AND Inventory_id = @Inventory_id)";

            await _dapperWrapper.ExecuteAsync(sql, new
            {
                Order_id = orderId,
                orderItem.Inventory_id,
                orderItem.Item?.No,
                orderItem.Color_id,
                orderItem.Quantity,
                orderItem.New_or_used,
                orderItem.Completeness,
                orderItem.Unit_price,
                orderItem.Unit_price_final,
                orderItem.Disp_unit_price,
                orderItem.Disp_unit_price_final,
                orderItem.Currency_code,
                orderItem.Disp_currency_code,
                orderItem.Description,
                orderItem.Remarks
            });
        }
    }
}
