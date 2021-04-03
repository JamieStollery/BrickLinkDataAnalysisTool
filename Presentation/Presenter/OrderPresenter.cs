using Data.Common.Repository.Interface;
using Presentation.Filtering;
using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Items;
using Presentation.Model.Mapping;
using Presentation.Model.Orders;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Presenter
{
    public partial class OrderPresenter : IPresenter
    {
        private readonly IOrderView _orderView;
        private readonly Func<IOrderRepository> _repositoryFactory;
        private readonly IStagePresenter _stagePresenter;
        private readonly Func<IReadOnlyList<Item>, IPresenter> _itemPresenterFactory;
        private readonly IDtoMapper _dtoMapper;
        private readonly IOrderFilterer _orderFilterer;
        private IReadOnlyList<Order> _orders;

        public OrderPresenter(IOrderView orderView, Func<IOrderRepository> repositoryFactory, IStagePresenter stagePresenter, 
            Func<IReadOnlyList<Item>, Action, IPresenter> itemPresenterFactory, IDtoMapper dtoMapper, IOrderFilterer orderFilterer)
        {
            _orderView = orderView;
            _repositoryFactory = repositoryFactory;
            _stagePresenter = stagePresenter;
            _itemPresenterFactory = (items) => itemPresenterFactory(items, OpenView);
            _dtoMapper = dtoMapper;
            _orderFilterer = orderFilterer;

            _orderView.OnSearchButtonClick = Search;
            _orderView.OnFilterChanged = FilterOrders;
            _orderView.OnOrderDoubleClick = OpenItemView;

            _orderView.ItemTypes = Enum.GetNames(typeof(ItemType));
            var itemConditions = new List<string>() { "Any" };
            itemConditions.AddRange(Enum.GetNames(typeof(ItemCondition)));
            _orderView.ItemConditions = itemConditions;
            _orderView.ItemCountTypes = new List<string>()
            {
                nameof(Order.TotalCount),
                nameof(Order.UniqueCount)
            };
            _orderView.OrderStatuses = Enum.GetNames(typeof(OrderStatus));
            _orderView.OrderSearchTypes = new List<string>()
            {
                nameof(Order.Id),
                nameof(Order.BuyerName)
            };
        }

        public void OpenView() => _stagePresenter.OpenView(_orderView);

        private void OpenItemView(int orderId) => _itemPresenterFactory(_orders.Single(order => order.Id == orderId).Items).OpenView();

        private async void Search()
        {
            var orderDtos = await _repositoryFactory().GetOrders();

            var tasks = orderDtos.Select(async orderDto => _dtoMapper.Map(orderDto, await _repositoryFactory().GetItems(orderDto.Order_id)));

            _orders = await Task.WhenAll(tasks.ToList());

            FilterOrders();
        }

        private void FilterOrders()
        {
            if (_orders == null) return;
            IReadOnlyList<Order> filteredOrders = new List<Order>(_orders);

            filteredOrders = _orderFilterer.FilterByOrderStatus(filteredOrders, EnumUtils.ToListOfEnum<OrderStatus>(_orderView.OrderStatuses));
            filteredOrders = _orderFilterer.FilterByItemType(filteredOrders, EnumUtils.ToListOfEnum<ItemType>(_orderView.ItemTypes), EnumUtils.ToNullableEnum<AnyAllFilterMode>(_orderView.ItemTypeFilterMode));
            filteredOrders = _orderFilterer.FilterByItemCondition(filteredOrders, EnumUtils.ToNullableEnum<ItemCondition>(_orderView.ItemCondition), EnumUtils.ToNullableEnum<AnyAllFilterMode>(_orderView.ItemConditionFilterMode));
            filteredOrders = _orderFilterer.FilterByItemCount(filteredOrders, _orderView.ItemCount, _orderView.ItemCountType, EnumUtils.ToNullableEnum<MinMaxFilterMode>(_orderView.ItemCountTypeFilterMode));
            filteredOrders = _orderFilterer.FilterByOrderSearch(filteredOrders, _orderView.OrderSearchValue, _orderView.OrderSearchType, EnumUtils.ToNullableEnum<StrictLooseFilterMode>(_orderView.OrderSearchFilterMode));

            _orderView.Orders = filteredOrders;
        }
    }
}
