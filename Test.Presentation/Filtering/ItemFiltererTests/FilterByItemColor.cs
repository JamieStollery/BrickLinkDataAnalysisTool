using Presentation.View.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.ItemFiltererTests
{
    public class FilterByItemColor : IClassFixture<ItemFiltererFixture>
    {
        private readonly Func<IReadOnlyList<ItemVm>, IReadOnlyList<int>, IReadOnlyList<ItemVm>> _methodOnTest;

        public FilterByItemColor(ItemFiltererFixture fixture)
        {
            _methodOnTest = fixture.ItemFilterer.FilterByItemColor;
        }

        [Fact]
        public void WhenItemsIsNull_AndColorIdsIsNotNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>("items", () => _methodOnTest(null, new List<int>()));
        }

        [Fact]
        public void WhenItemsIsNotNull_AndColorIdsIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>("colorIds", () => _methodOnTest(new List<ItemVm>(), null));
        }

        [Fact]
        public void WhenItemsIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<ItemVm>(), new List<int>());
        }

        [Fact]
        public void WhenColorIdsCountIs0_ThenItemsAreNotFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, new List<int>());
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenColorIdsCountIsMoreThan0_ThenItemsAreFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, new List<int>() { default });
            Assert.NotStrictEqual(items, result);
        }
    }
}
