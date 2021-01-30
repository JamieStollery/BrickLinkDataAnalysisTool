using Presentation.Filtering.StrictLoose;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.ItemFiltererTests
{
    public class FilterByItemSearch : IClassFixture<ItemFiltererFixture>
    {
        private readonly Func<IReadOnlyList<ItemVm>, string, string, StrictLooseFilterMode?, IReadOnlyList<ItemVm>> _methodOnTest;

        public FilterByItemSearch(ItemFiltererFixture fixture)
        {
            _methodOnTest = fixture.ItemFilterer.FilterByItemSearch;
        }

        [Fact]
        public void WhenItemsIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>("items", () => _methodOnTest(null, default, default, default));
        }

        [Fact]
        public void WhenItemsIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<ItemVm>(), default, default, default);
        }

        [Fact]
        public void WhenSearchValueIsNull_ThenItemsAreNotFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, null, "test", StrictLooseFilterMode.Strict);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenFilterStrategyIsNull_ThenItemsAreNotFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, "test", null, StrictLooseFilterMode.Strict);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenFilterModeIsNull_ThenItemsAreNotFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, "test", "test", null);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenSearchValueIsNotNull_AndFilterStrategyIsNotNull_AndFilterModeIsNotNull_ThenItemsAreFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, "test", "test", StrictLooseFilterMode.Strict);
            Assert.NotStrictEqual(items, result);
        }
    }
}
