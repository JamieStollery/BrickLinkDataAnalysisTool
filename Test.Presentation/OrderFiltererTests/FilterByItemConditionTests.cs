using Presentation.Filtering.AnyAll;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.OrderFiltererTests
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
    }
}
