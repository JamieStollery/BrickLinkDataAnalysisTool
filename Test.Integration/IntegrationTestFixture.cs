using Autofac;
using Data.Common;
using Data.Common.Model.Dto;
using Data.Common.Repository.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Test.Integration
{
    public class IntegrationTestFixture : IAsyncLifetime
    {
        private readonly ILifetimeScope _scope;

        // Runs before test
        public IntegrationTestFixture()
        {
            // Create test orders
            Orders = CreateOrders(1, 2, 3);

            // Initialize IOrderRepository mock
            var orderRepositoryMock = new Mock<IOrderRepository>();
            orderRepositoryMock.Setup(repo => repo.GetOrders()).Returns(Task.FromResult(Orders));

            // Setup IoC
            var builder = new ContainerBuilder();
            builder.RegisterModule<TestingIoCModule>();
            builder.RegisterInstance(orderRepositoryMock.Object).As<IOrderRepository>().SingleInstance();
            var container = builder.Build();
            _scope = container.BeginLifetimeScope();
        }

        public IEnumerable<OrderDto> Orders { get; }

        // Runs before test to populate database
        public async Task InitializeAsync()
        {
            var databaseUpdater = _scope.Resolve<IDatabaseUpdater>();
            var (_, tasks) = await databaseUpdater.UpdateDatabase();
            await tasks.ToListAsync();
        }

        // Runs after test to clear database
        public async Task DisposeAsync()
        {
            var databaseUpdater = _scope.Resolve<IDatabaseUpdater>();
            await databaseUpdater.ClearDatabase();
            _scope.Dispose();
        }

        private IEnumerable<OrderDto> CreateOrders(params int[] ids)
        {
            foreach (int id in ids)
            {
                yield return new OrderDto
                {
                    Order_id = id,
                    Date_ordered = DateTime.Today,
                    Seller_name = "Test Seller",
                    Store_name = "Test Store",
                    Buyer_name = "Test Buyer",
                    Total_count = 1,
                    Unique_count = 1,
                    Status = "Completed",
                    Payment = new PaymentDto
                    {
                        Method = "Test Method",
                        Status = "Completed",
                        Date_paid = DateTime.Today,
                        Currency_code = "GBP"
                    },
                    Cost = new CostDto
                    {
                        Subtotal = 10,
                        Grand_total = 15,
                        Currency_code = "GBP"
                    },
                };
            }
        }
    }
}
