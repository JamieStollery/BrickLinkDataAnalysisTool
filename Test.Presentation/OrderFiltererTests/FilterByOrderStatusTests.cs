using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.OrderFiltererTests
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
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(null, new List<OrderStatus>() { default }));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndStatusesIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(new List<Order>() { default }, null));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndStatusesIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<Order>() { default }, new List<OrderStatus>() { default });
        }
    }
}
