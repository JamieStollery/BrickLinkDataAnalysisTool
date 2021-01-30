using Presentation.Filtering.AnyAll;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.OrderFiltererTests
{
    public class FilterByItemConditionTests : IClassFixture<OrderFiltererFixture>
    {
        private readonly Func<IReadOnlyList<Order>, ItemCondition?, AnyAllFilterMode?, IReadOnlyList<Order>> _methodOnTest;

        public FilterByItemConditionTests(OrderFiltererFixture fixture)
        {
            _methodOnTest = fixture.OrderFilterer.FilterByItemCondition;
        }

        [Fact]
        public void WhenOrdersIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(null, default, default));
        }

        [Fact]
        public void WhenOrdersIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<Order>() { default }, default, default);
        }

        [Fact]
        public void WhenConditionIsNull_AndFilterModeIsNotNull_ThenOrdersAreNotFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, null, AnyAllFilterMode.Any);
            Assert.StrictEqual(orders, result);
        }

        [Fact]
        public void WhenConditionIsNotNull_AndFilterModeIsNull_ThenOrdersAreNotFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, ItemCondition.Used, null);
            Assert.StrictEqual(orders, result);
        }

        [Fact]
        public void WhenConditionIsNotNull_AndFilterModeIsNotNull_ThenOrdersAreFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, ItemCondition.Used, AnyAllFilterMode.Any);
            Assert.NotStrictEqual(orders, result);
        }
    }
}
