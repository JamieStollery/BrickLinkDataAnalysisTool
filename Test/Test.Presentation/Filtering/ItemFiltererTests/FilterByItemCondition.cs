using Presentation.Model.Items;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.ItemFiltererTests
{
    public class FilterByItemCondition : IClassFixture<ItemFiltererFixture>
    {
        private readonly Func<IReadOnlyList<ItemVm>, ItemCondition?, IReadOnlyList<ItemVm>> _methodOnTest;

        public FilterByItemCondition(ItemFiltererFixture fixture)
        {
            _methodOnTest = fixture.ItemFilterer.FilterByItemCondition;
        }

        [Fact]
        public void WhenItemsIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>("items", () => _methodOnTest(null, default));
        }

        [Fact]
        public void WhenItemsIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<ItemVm>(), default);
        }

        [Fact]
        public void WhenConditionIsNull_ThenItemsAreNotFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, null);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenConditionIsNotNull_ThenItemsAreFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, ItemCondition.New);
            Assert.NotStrictEqual(items, result);
        }
    }
}
