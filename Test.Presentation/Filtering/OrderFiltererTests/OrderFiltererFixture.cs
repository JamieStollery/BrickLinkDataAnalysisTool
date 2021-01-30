using Moq;
using Presentation.Filtering;
using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Orders;

namespace Test.Presentation.Filtering.OrderFiltererTests
{
    public class OrderFiltererFixture
    {
        public OrderFiltererFixture()
        {
            var anyAllFilterModeMock = new Mock<IAnyAllFilterModeStrategy>();
            var minMaxFilterModeMock = new Mock<IMinMaxFilterModeStrategy<Order>>();
            var strictLooseFilterModeMock = new Mock<IStrictLooseFilterModeStrategy<Order>>();

            OrderFilterer = new OrderFilterer((mode) => anyAllFilterModeMock.Object,
                (type, mode) => string.IsNullOrWhiteSpace(type) ? null : minMaxFilterModeMock.Object,
                (type, mode) => string.IsNullOrWhiteSpace(type) ? null : strictLooseFilterModeMock.Object);
        }

        public OrderFilterer OrderFilterer { get; }
    }
}
