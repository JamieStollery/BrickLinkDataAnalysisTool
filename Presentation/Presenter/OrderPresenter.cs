using Data.Common;
using Data.Common.Repository.Interface;
using Presentation.Filtering;
using Presentation.Filtering.AnyAll;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model;
using Presentation.Model.Items;
using Presentation.Model.Mapping;
using Presentation.Model.Orders;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Presenter
{
    public partial class OrderPresenter : IPresenter
    {
        private readonly IOrderView _orderView;
        private readonly Func<IReadOnlyList<ItemVm>, ItemPresenter> _itemPresenterFactory;
        private readonly MainStagePresenter _stagePresenter;
        // Maybe this factory does not need the DataMode parameter if it can be resolved from the MainStagePresenter
        private readonly Func<DataMode, IOrderRepository> _repositoryFactory;
        private readonly IDtoMapper _dtoMapper;
        private readonly IVmMapper _vmMapper;
        private readonly IOrderFilterer _orderFilterer;
        private IReadOnlyList<Order> _orders;

        public OrderPresenter(IOrderView orderView, Func<IReadOnlyList<ItemVm>, ItemPresenter> itemPresenterFactory, MainStagePresenter stagePresenter,
            Func<DataMode, IOrderRepository> repositoryFactory, IDtoMapper dtoMapper, IVmMapper vmMapper, IOrderFilterer orderFilterer)
        {
            _orderView = orderView;
            _itemPresenterFactory = (items) =>
            {
                var presenter = itemPresenterFactory(items);
                presenter.BackToOrderView = OpenView;
                return presenter;
            };
            _stagePresenter = stagePresenter;
            _repositoryFactory = repositoryFactory;
            _dtoMapper = dtoMapper;
            _vmMapper = vmMapper;
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

        private void OpenItemView(int orderId) => _itemPresenterFactory(_orders.Single(order => order.Id == orderId).Items.Select(item => _vmMapper.Map(item)).ToList()).OpenView();

        private async void Search()
        {
            var orderDtos = await _repositoryFactory(_stagePresenter.DataMode).GetOrders();

            var tasks = orderDtos.Select(async orderDto => _dtoMapper.Map(orderDto, await _repositoryFactory(_stagePresenter.DataMode).GetItems(orderDto.Order_id)));

            _orders = await Task.WhenAll(tasks.ToList());

            FilterOrders();
        }

        private void FilterOrders()
        {
            if (_orders == null) return;
            IReadOnlyList<Order> filteredOrders = new List<Order>(_orders);

            filteredOrders = _orderFilterer.FilterByOrderStatus(filteredOrders, ToListOfEnum<OrderStatus>(_orderView.OrderStatuses));
            filteredOrders = _orderFilterer.FilterByItemType(filteredOrders, ToListOfEnum<ItemType>(_orderView.ItemTypes), ToNullableEnum<AnyAllFilterMode>(_orderView.ItemTypeFilterMode));
            filteredOrders = _orderFilterer.FilterByItemCondition(filteredOrders, ToNullableEnum<ItemCondition>(_orderView.ItemCondition), ToNullableEnum<AnyAllFilterMode>(_orderView.ItemConditionFilterMode));
            filteredOrders = _orderFilterer.FilterByItemCount(filteredOrders, _orderView.ItemCount, _orderView.ItemCountType, ToNullableEnum<MinMaxFilterMode>(_orderView.ItemCountTypeFilterMode));
            filteredOrders = _orderFilterer.FilterByOrderSearch(filteredOrders, _orderView.OrderSearchValue, _orderView.OrderSearchType, ToNullableEnum<StrictLooseFilterMode>(_orderView.OrderSearchFilterMode));

            _orderView.Orders = filteredOrders.ToList();

            static TEnum? ToNullableEnum<TEnum>(string value) where TEnum : struct
            {
                return Enum.TryParse(value, out TEnum result) ? result : null as TEnum?;
            }
            
            static IReadOnlyList<TEnum> ToListOfEnum<TEnum>(IEnumerable<string> values) where TEnum : struct
            {
                return ToEnums(values)?.ToList();

                static IEnumerable<TEnum> ToEnums(IEnumerable<string> values)
                {
                    foreach (var value in values)
                    {
                        if (Enum.TryParse<TEnum>(value, out var result))
                        {
                            yield return result;
                        }
                    }
                }
            }
        }
    }
}
