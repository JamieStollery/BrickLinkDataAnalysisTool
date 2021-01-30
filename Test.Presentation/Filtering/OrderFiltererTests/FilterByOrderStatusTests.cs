using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.OrderFiltererTests
{
    public class FilterByOrderStatusTests : IClassFixture<OrderFiltererFixture>
    {
        private readonly Func<IReadOnlyList<Order>, IReadOnlyList<OrderStatus>, IReadOnlyList<Order>> _methodOnTest;

        public FilterByOrderStatusTests(OrderFiltererFixture fixture)
        {
            _methodOnTest = fixture.OrderFilterer.FilterByOrderStatus;
        }

        [Fact]
        public void WhenOrdersIsNull_AndStatusesIsNotNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(null, new List<OrderStatus>()));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndStatusesIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(new List<Order>(), null));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndStatusesIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<Order>(), new List<OrderStatus>());
        }

        [Fact]
        public void WhenStatusesCountIs0_ThenOrdersAreNotFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, new List<OrderStatus>());
            Assert.StrictEqual(orders, result);
        }

        [Fact]
        public void WhenStatusesCountIsMoreThan0_ThenOrdersAreFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, new List<OrderStatus>() { default });
            Assert.NotStrictEqual(orders, result);
        }
    }
}
