using Presentation.Model.Items;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Presentation.Filtering.ItemFiltererTests
{
    public class FilterByItemType : IClassFixture<ItemFiltererFixture>
    {
        private readonly Func<IReadOnlyList<ItemVm>, IReadOnlyList<ItemType>, IReadOnlyList<ItemVm>> _methodOnTest;

        public FilterByItemType(ItemFiltererFixture fixture)
        {
            _methodOnTest = fixture.ItemFilterer.FilterByItemType;
        }

        [Fact]
        public void WhenItemsIsNull_AndItemTypesIsNotNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>("items", () => _methodOnTest(null, new List<ItemType>()));
        }

        [Fact]
        public void WhenItemsIsNotNull_AndItemTypesIsNull_ThenArgumentNullExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>("itemTypes", () => _methodOnTest(new List<ItemVm>(), null));
        }

        [Fact]
        public void WhenItemsIsNotNull_ThenNoExceptionIsThrown()
        {
            _ = _methodOnTest(new List<ItemVm>(), new List<ItemType>());
        }

        [Fact]
        public void WhenItemTypesCountIs0_ThenItemsAreNotFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, new List<ItemType>());
            Assert.StrictEqual(items, result);
        }

        [Fact]
        public void WhenItemTypesCountIsMoreThan0_ThenItemsAreFiltered()
        {
            var items = new List<ItemVm>();
            var result = _methodOnTest(items, new List<ItemType>() { default });
            Assert.NotStrictEqual(items, result);
        }
    }
}
