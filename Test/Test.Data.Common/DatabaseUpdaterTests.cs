using Data.Common;
using Data.Common.Model.Dto;
using Data.Common.Repository.Interface;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Test.Data.Common
{
    public class DatabaseUpdaterTests
    {
        private readonly Mock<IDapperWrapper> _dapperWrapperMock;
        private readonly Mock<IOrderRepository> _orderRepositoryMock;
        private readonly IDatabaseUpdater _databaseUpdater;

        public DatabaseUpdaterTests()
        {
            // Define IDapperWapper Mock
            _dapperWrapperMock = new Mock<IDapperWrapper>();
            // Setup ExecuteAsync method
            _dapperWrapperMock.Setup(mock => mock.ExecuteAsync(It.IsAny<string>(), It.IsAny<object>())).ReturnsAsync(default(int));

            // Define IOrderRepository Mock
            _orderRepositoryMock = new Mock<IOrderRepository>();
            // Setup GetOrders method
            var orders = new List<OrderDto>()
            {
                new OrderDto(),
                new OrderDto(),
                new OrderDto() 
            };
            _orderRepositoryMock.Setup(repo => repo.GetOrders()).ReturnsAsync(orders);
            // Setup GetOrderItems method
            var items = new List<OrderItemDto>()
            {
                new OrderItemDto()
            };
            _orderRepositoryMock.Setup(repo => repo.GetItems(It.IsAny<int>())).ReturnsAsync(items);

            // Define DatabaseUpdater
            _databaseUpdater = new DatabaseUpdater(_dapperWrapperMock.Object, _orderRepositoryMock.Object);
        }

        [Fact]
        public async void WhenUpdateDatabaseIsCalled_ThenCountEqualsAmountOfOrders()
        {
            // Call UpdateDatabase
            var (count, _) = await _databaseUpdater.UpdateDatabase();

            // Get orders from IOrderRepository
            var orders = await _orderRepositoryMock.Object.GetOrders();

            // Verify count is equal to amount of orders
            Assert.Equal(orders.Count(), count);
        }

        [Fact]
        public async void WhenUpdateDatabaseIsCalled_ThenNoDapperWrapperCallsAreMadeUntilTasksAreAwaited()
        {
            // Call UpdateDatabase
            var (_, tasks) = await _databaseUpdater.UpdateDatabase();

            // Verify no calls are made
            _dapperWrapperMock.VerifyNoOtherCalls();

            // Await tasks
            await foreach (var task in tasks) { }

            // Verify ExecuteAsync method is called
            _dapperWrapperMock.Verify(mock => mock.ExecuteAsync(It.IsAny<string>(), It.IsAny<object>()), Times.AtLeastOnce());
        }

        [Fact]
        public async void WhenUpdateDatabaseIsCalled_ThenGetOrdersIsCalledOnce()
        {
            // Call UpdateDatabase
            var (_, tasks) = await _databaseUpdater.UpdateDatabase();

            // Await tasks
            await foreach (var task in tasks) { }

            // Verify GetOrders is called only once
            _orderRepositoryMock.Verify(repo => repo.GetOrders(), Times.Once());
        }

        [Fact]
        public async void WhenUpdateDatabaseIsCalled_ThenGetItemsIsCalledForEachOrder()
        {
            // Call UpdateDatabase
            var (count, tasks) = await _databaseUpdater.UpdateDatabase();

            // Await tasks
            await foreach (var task in tasks) { }

            // Get orders from IOrderRepository
            var orders = await _orderRepositoryMock.Object.GetOrders();

            // Verify GetItems is called for each order
            _orderRepositoryMock.Verify(repo => repo.GetItems(It.IsAny<int>()), Times.Exactly(orders.Count()));
        }

        [Fact]
        public async void WhenClearDatabaseIsCalled_ThenExecuteAsyncMethodIsCalledOnce()
        {
            await _databaseUpdater.ClearDatabase();

            // Verify ExecuteAsync method is called
            _dapperWrapperMock.Verify(mock => mock.ExecuteAsync(It.IsAny<string>(), null), Times.Once());
        }
    }
}
