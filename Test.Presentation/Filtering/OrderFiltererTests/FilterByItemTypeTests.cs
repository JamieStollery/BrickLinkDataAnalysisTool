using Presentation.Filtering.AnyAll;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test.Presentation.Filtering.OrderFiltererTests
{
    public class FilterByItemTypeTests : IClassFixture<OrderFiltererFixture>
    {
        private readonly Func<IReadOnlyList<Order>, IReadOnlyList<ItemType>, AnyAllFilterMode?, IReadOnlyList<Order>> _methodOnTest;

        public FilterByItemTypeTests(OrderFiltererFixture fixture)
        {
            _methodOnTest = fixture.OrderFilterer.FilterByItemType;
        }

        [Fact]
        public void WhenOrdersIsNull_AndItemTypesIsNotNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(null, new List<ItemType>(), default));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndItemTypesIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(new List<Order>(), null, default));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndItemTypesIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<Order>(), new List<ItemType>(), default);
        }

        [Fact]
        public void WhenItemTypesCountIs0_AndFilterModeIsNotNull_ThenOrdersAreNotFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, new List<ItemType>(), AnyAllFilterMode.Any);
            Assert.StrictEqual(orders, result);
        }

        [Fact]
        public void WhenItemTypesCountIsMoreThan0_AndFilterModeIsNull_ThenOrdersAreNotFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, new List<ItemType>() { default }, null);
            Assert.StrictEqual(orders, result);
        }

        [Fact]
        public void WhenItemTypesCountIsMoreThan0_AndFilterModeIsNotNull_ThenOrdersAreFiltered()
        {
            var orders = new List<Order>();
            var result = _methodOnTest(orders, new List<ItemType>() { default }, AnyAllFilterMode.Any);
            Assert.NotStrictEqual(orders, result);
        }
    }
}
