using Autofac;
using Data.Common.Model.Dto;
using GUI;
using Moq;
using Newtonsoft.Json;
using Presentation.Model.Mapping;
using Presentation.Presenter;
using Presentation.View.Interface;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Xunit;

namespace Test.Integration
{
    public class OrderViewIntegrationTest : IClassFixture<IntegrationTestFixture>
    {
        private readonly IEnumerable<OrderDto> _orders;

        public OrderViewIntegrationTest(IntegrationTestFixture fixture)
        {
            _orders = fixture.Orders;
        }

        [Fact]
        public void WhenTheSearchButtonIsClicked_ThenTheExpectedOrdersFromTheDatabaseAreDisplayed()
        {
            // Initialize Variables
            Action onSearchButtonClick = null;
            var orderViewMock = new Mock<IOrderView>();
            var builder = new ContainerBuilder();

            // Setup
            {
                // Setup IOrderView mock
                orderViewMock.SetupSet(view => view.OnSearchButtonClick = It.IsAny<Action>())
                    .Callback<Action>(action => onSearchButtonClick = action);

                // Register IoC components
                builder.RegisterModule<IoCModule>();
                builder.RegisterModule<TestingIoCModule>();
                builder.RegisterInstance(orderViewMock.Object).As<IOrderView>().SingleInstance();
            }

            // Action
            {
                // Build IoC container
                var container = builder.Build();
                using var scope = container.BeginLifetimeScope();

                // Resolve OrderPresenter
                _ = scope.ResolveKeyed<IPresenter>(Key.Order);

                // Invoke the IOrderView mock's OnSearchButtonClick Action
                onSearchButtonClick();
            }

            // Verify
            {
                // Verify the IOrderView mock's Orders property was set with the expected values
                orderViewMock.VerifySet(view =>
                    view.Orders = It.Is<IEnumerable<OrderVm>>(result => VerifyEqual(result)));
            }
        }

        private bool VerifyEqual(IEnumerable<OrderVm> result)
        {
            // Converts order DTOs to VMs
            static IEnumerable<OrderVm> GetExpectedOrders(IEnumerable<OrderDto> orders)
            {
                var dtoMapper = new DtoMapper();
                var vmMapper = new VmMapper();

                return orders.Select(order => vmMapper.Map(dtoMapper.Map(order, null)));
            }

            // Serialize order VMs to JSON strings
            var expectedJson = JsonConvert.SerializeObject(GetExpectedOrders(_orders));
            var actualJson = JsonConvert.SerializeObject(result);

            // Compare results
            return expectedJson == actualJson;
        }
    }
}
