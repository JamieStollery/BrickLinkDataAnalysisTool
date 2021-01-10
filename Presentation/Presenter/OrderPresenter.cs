using Data.Common;
using Data.Common.Repository.Interface;
using Presentation.Filtering;
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
    public class OrderPresenter : IPresenter
    {
        private readonly IOrderView _orderView;
        private readonly Func<IReadOnlyList<Item>, IItemView> _itemViewFactory;
        private readonly MainStagePresenter _stagePresenter;
        // Maybe this factory does not need the DataMode parameter if it can be resolved from the MainStagePresenter
        private readonly Func<DataMode, IOrderRepository> _repositoryFactory;
        private readonly Func<FilterMode, IFilterModeStrategy> _filterModeStrategyFactory;
        private readonly IDtoMapper _mapper;

        private IReadOnlyList<Order> _orders;

        public OrderPresenter(IOrderView orderView, Func<IReadOnlyList<Item>, IItemView> itemViewFactory, MainStagePresenter stagePresenter, Func<DataMode, IOrderRepository> repositoryFactory, Func<FilterMode, IFilterModeStrategy> filterModeStrategyFactory, IDtoMapper mapper)
        {
            _orderView = orderView;
            _itemViewFactory = (items) =>
            { 
                var itemView = itemViewFactory(items);
                itemView.OnBackButtonClick = () => OpenOrderView();
                return itemView;
            };
            _stagePresenter = stagePresenter;
            _repositoryFactory = repositoryFactory;
            _filterModeStrategyFactory = filterModeStrategyFactory;
            _mapper = mapper;

            _orderView.OnSearchButtonClick = () => Search();
            _orderView.OnFilterChanged = () => FilterOrders();
            _orderView.OnOrderDoubleClick = (id) => OpenItemView(id);

            _orderView.ItemTypes = Enum.GetNames(typeof(ItemType));
            var itemConditions = new List<string>() { "Any" };
            itemConditions.AddRange(Enum.GetNames(typeof(ItemCondition)));
            _orderView.ItemConditions = itemConditions;
        }

        private IEnumerable<ItemType> ItemTypes => _orderView.ItemTypes.Select(type => Enum.Parse<ItemType>(type));
        private ItemCondition? ItemCondition => Enum.TryParse(_orderView.ItemCondition, out ItemCondition itemCondition) ? itemCondition : null as ItemCondition?;
        private IFilterModeStrategy ItemTypeFilterModeStrategy => _filterModeStrategyFactory(Enum.Parse<FilterMode>(_orderView.ItemTypeFilterMode));
        private IFilterModeStrategy ItemConditionFilterModeStrategy => _filterModeStrategyFactory(Enum.Parse<FilterMode>(_orderView.ItemConditionFilterMode));

        public void OpenOrderView() => _stagePresenter.OpenView(_orderView);

        private void OpenItemView(int orderId) => _stagePresenter.OpenView(_itemViewFactory(_orders.Single(order => order.Id == orderId).Items.ToList()));

        private async void Search()
        {
            var orderDtos = await _repositoryFactory(_stagePresenter.DataMode).GetOrders();

            var tasks = orderDtos.Select(async orderDto => _mapper.Map(orderDto, await _repositoryFactory(_stagePresenter.DataMode).GetItems(orderDto.Order_id)));

            _orders = await Task.WhenAll(tasks.ToList());

            FilterOrders();
        }

        private void FilterOrders()
        {
            if (_orders == null) return;
            var orders = ItemTypeFilterModeStrategy.Filter(_orders, item => ItemTypes.Contains(item.Type));
            if (ItemCondition != null)
            {
                orders = ItemConditionFilterModeStrategy.Filter(orders, item => item.Condition == ItemCondition);
            }
            _orderView.Orders = orders.ToList();
        }
    }
}
