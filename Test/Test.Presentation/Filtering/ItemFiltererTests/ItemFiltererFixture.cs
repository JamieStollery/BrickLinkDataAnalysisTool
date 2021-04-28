using Moq;
using Presentation.Filtering;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.View.Model;

namespace Test.Presentation.Filtering.ItemFiltererTests
{
    public class ItemFiltererFixture
    {
        public ItemFiltererFixture()
        {
            var minMaxFilterModeMock = new Mock<IMinMaxFilterModeStrategy<ItemVm>>();
            var strictLooseFilterModeMock = new Mock<IStrictLooseFilterModeStrategy<ItemVm>>();

            ItemFilterer = new ItemFilterer((type, mode) => string.IsNullOrWhiteSpace(type) ? null : strictLooseFilterModeMock.Object, mode => minMaxFilterModeMock.Object);
        }

        public ItemFilterer ItemFilterer { get; }
    }
}
