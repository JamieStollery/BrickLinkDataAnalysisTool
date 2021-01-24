using Moq;
using Presentation.Filtering;
using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;

namespace Test.Presentation.OrderFiltererTests
{
    public class OrderFiltererFixture
    {
        public OrderFiltererFixture()
        {
            var anyAllFilterModeMock = new Mock<IAnyAllFilterModeStrategy>();
            var minMaxFilterModeMock = new Mock<IMinMaxFilterModeStrategy>();
            var strictLooseFilterModeMock = new Mock<IStrictLooseFilterModeStrategy>();

            OrderFilterer = new OrderFilterer((mode) => anyAllFilterModeMock.Object, (type, mode) => minMaxFilterModeMock.Object, (type, mode) => strictLooseFilterModeMock.Object);
        }

        public OrderFilterer OrderFilterer { get; }
    }
}
