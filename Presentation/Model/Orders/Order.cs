using System;
using System.Collections.Generic;
using Presentation.Model.Items;

namespace Presentation.Model.Orders
{
    public class Order
    {
        public Order(int id, DateTime dateOrdered, string sellerName, string storeName, string buyerName, int totalCount, int uniqueCount, OrderStatus status, Payment payment, Cost cost, IReadOnlyList<Item> items)
        {
            Id = id;
            DateOrdered = dateOrdered;
            SellerName = sellerName;
            StoreName = storeName;
            BuyerName = buyerName;
            TotalCount = totalCount;
            UniqueCount = uniqueCount;
            Status = status;
            Payment = payment;
            Cost = cost;
            Items = items;
        }

        public int Id { get; }
        public DateTime DateOrdered { get; }
        public string SellerName { get; }
        public string StoreName { get; }
        public string BuyerName { get; }
        public int TotalCount { get; }
        public int UniqueCount { get; }
        public OrderStatus Status { get; }
        public Payment Payment { get; }
        public Cost Cost { get; }
        public IReadOnlyList<Item> Items { get; }
    }
}
