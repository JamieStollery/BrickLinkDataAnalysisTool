using Presentation.Filtering.AnyAll;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test.Presentation.OrderFiltererTests
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
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(null, new List<ItemType>() { default }, default));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndItemTypesIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => _methodOnTest(new List<Order>() { default }, null, default));
        }

        [Fact]
        public void WhenOrdersIsNotNull_AndItemTypesIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<Order>() { default }, new List<ItemType>() { default }, default);
        }
    }
}
