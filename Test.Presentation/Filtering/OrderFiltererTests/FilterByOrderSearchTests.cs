using Presentation.Filtering.StrictLoose;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.OrderFiltererTests
{
    public class FilterByOrderSearchTests : IClassFixture<OrderFiltererFixture>
    {
        private readonly Func<IReadOnlyList<Order>, string, string, StrictLooseFilterMode?, IReadOnlyList<Order>> _methodOnTest;

        public FilterByOrderSearchTests(OrderFiltererFixture fixture)
        {
            _methodOnTest = fixture.OrderFilterer.FilterByOrderSearch;
        }

        [Fact]
        public void WhenOrdersIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(null, default, default, default));
        }

        [Fact]
        public void WhenOrdersIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<Order>(), default, default, default);
        }

        [Fact]
        public void WhenSearchValueIsNull_ThenOrdersAreNotFiltered()
        {
            var items = new List<Order>();
            var result = _methodOnTest(items, null, "test", StrictLooseFilterMode.Strict);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenFilterStrategyIsNull_ThenOrdersAreNotFiltered()
        {
            var items = new List<Order>();
            var result = _methodOnTest(items, "test", null, StrictLooseFilterMode.Strict);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenFilterModeIsNull_ThenOrdersAreNotFiltered()
        {
            var items = new List<Order>();
            var result = _methodOnTest(items, "test", "test", null);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenSearchValueIsNotNull_AndFilterStrategyIsNotNull_AndFilterModeIsNotNull_ThenOrdersAreFiltered()
        {
            var items = new List<Order>();
            var result = _methodOnTest(items, "test", "test", StrictLooseFilterMode.Strict);
            Assert.NotStrictEqual(items, result);
        }
    }
}
