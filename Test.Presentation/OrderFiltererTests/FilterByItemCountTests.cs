using Presentation.Filtering.MinMax;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.OrderFiltererTests
{
    public class FilterByItemCountTests : IClassFixture<OrderFiltererFixture>
    {
        private readonly Func<IReadOnlyList<Order>, int, string, MinMaxFilterMode?, IReadOnlyList<Order>> _methodOnTest;

        public FilterByItemCountTests(OrderFiltererFixture fixture)
        {
            _methodOnTest = fixture.OrderFilterer.FilterByItemCount;
        }

        [Fact]
        public void WhenOrdersIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(null, default, default, default));
        }

        [Fact]
        public void WhenOrdersIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<Order>() { default }, default, default, default);
        }
    }
}
