using Presentation.Filtering.MinMax;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.ItemFiltererTests
{
    public class FilterByItemCount : IClassFixture<ItemFiltererFixture>
    {
        private readonly Func<IReadOnlyList<ItemVm>, int, MinMaxFilterMode?, IReadOnlyList<ItemVm>> _methodOnTest;

        public FilterByItemCount(ItemFiltererFixture fixture)
        {
            _methodOnTest = fixture.ItemFilterer.FilterByItemCount;
        }

        [Fact]
        public void WhenItemsIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>("items", () => _methodOnTest(null, default, default));
        }

        [Fact]
        public void WhenItemsIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<ItemVm>(), default, default);
        }

        [Fact]
        public void WhenFilterModeIsNull_ThenItemsAreNotFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, default, null);
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenFilterModeIsNotNull_ThenItemsAreFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, default, MinMaxFilterMode.Min);
            Assert.NotStrictEqual(items, result);
        }
    }
}
