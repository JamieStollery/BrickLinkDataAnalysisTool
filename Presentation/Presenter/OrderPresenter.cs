﻿using Data.Common;
using Data.Common.Model;
using Presentation.Filtering;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

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

        private IReadOnlyList<Order> _orders;

        public OrderPresenter(IOrderView orderView, Func<IReadOnlyList<Item>, IItemView> itemViewFactory, MainStagePresenter stagePresenter, Func<DataMode, IOrderRepository> repositoryFactory, Func<FilterMode, IFilterModeStrategy> filterModeStrategyFactory)
        {
            _orderView = orderView;
            _itemViewFactory = (items) =>
            { 
                var itemView = itemViewFactory(items);
                itemView.OnBackButtonClick = (view) => CloseItemView(view);
                return itemView;
            };
            _stagePresenter = stagePresenter;
            _repositoryFactory = repositoryFactory;
            _filterModeStrategyFactory = filterModeStrategyFactory;

            _orderView.OnSearchButtonClick = () => Search();
            _orderView.OnFilterChanged = () => FilterOrders();
            _orderView.OnOrderDoubleClick = (id) => OpenItemView(id);
            _orderView.ItemTypes = Enum.GetNames(typeof(ItemType));
        }

        private IEnumerable<ItemType> ItemTypes => _orderView.ItemTypes.Select(type => Enum.Parse<ItemType>(type));
        private IFilterModeStrategy ItemTypeFilterModeStrategy => _filterModeStrategyFactory(Enum.Parse<FilterMode>(_orderView.ItemTypeFilterMode));

        public void OpenView() => _stagePresenter.OpenView(_orderView);

        private async void Search()
        {
            var orders = await _repositoryFactory(_stagePresenter.DataMode).GetOrders();
            _orders = orders.ToList();

            FilterOrders();
        }

        private void FilterOrders()
        {
            if (_orders == null) return;
            var orders = ItemTypeFilterModeStrategy.Filter(_orders, item => ItemTypes.Contains(item.ItemType));
            _orderView.Orders = orders.ToList();
        }

        private void OpenItemView(int orderId)
        {
            _stagePresenter.CloseView(_orderView);
            _stagePresenter.OpenView(_itemViewFactory(_orders.Single(order => order.Id == orderId).Items.ToList()));
        }
        
        private void CloseItemView(IItemView itemView)
        {
            _stagePresenter.CloseView(itemView);
            OpenView();
        }
    }
}