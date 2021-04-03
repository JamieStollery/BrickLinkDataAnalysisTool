using Data.Common.Repository.Interface;
using Presentation.Filtering;
using Presentation.Filtering.MinMax;
using Presentation.Filtering.StrictLoose;
using Presentation.Model.Items;
using Presentation.Model.Mapping;
using Presentation.Presenter.Stage;
using Presentation.View.Interface;
using Presentation.View.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Presenter
{
    public class ItemPresenter : IPresenter
    {
        private readonly IItemView _view;
        private readonly IItemImageRepository _repository;
        private readonly IStagePresenter _stagePresenter;
        private readonly IReadOnlyList<ItemVm> _items;
        private readonly IItemFilterer _itemFilterer;
        private readonly IVmMapper _vmMapper;
        private IReadOnlyList<ColorVm> _colors;

        public ItemPresenter(IItemView view, IItemImageRepository repository, IStagePresenter stagePresenter,
            Action openOrderView, IReadOnlyList<Item> items, IItemFilterer itemFilterer, IVmMapper vmMapper)
        {
            _view = view;
            _repository = repository;
            _stagePresenter = stagePresenter;
            _items = items.Select(item => vmMapper.Map(item)).ToList();
            _itemFilterer = itemFilterer;
            _vmMapper = vmMapper;
            _colors = new List<ColorVm>();

            _view.OnBackButtonClick = openOrderView;
            _view.OnFilterChanged = FilterItems;
            _view.OnViewOpened = LoadItemImages;
            _view.OnViewOpened = LoadItemColors;

            _view.ItemSearchTypes = new List<string>()
            {
                nameof(ItemVm.Number),
                nameof(ItemVm.InventoryId),
                nameof(ItemVm.Name),
                nameof(ItemVm.CategoryId)
            };
            _view.ItemTypes = Enum.GetNames(typeof(ItemType));
            var itemConditions = new List<string>() { "Any" };
            itemConditions.AddRange(Enum.GetNames(typeof(ItemCondition)));
            _view.ItemConditions = itemConditions;

            _view.Items = _items;
        }

        public void OpenView() => _stagePresenter.OpenView(_view);

        private async void LoadItemColors()
        {
            var colors = await _repository.GetColors();
            _colors = colors.Select(color => _vmMapper.Map(color)).ToList();
            _view.Colors = _colors;
        }

        private async void LoadItemImages()
        {
            var tasks = _items.Select(async item =>
            {
                item.Image = Image.FromStream(await _repository.GetItemImage(item.Type, item.Number, item.ColorId));
                _view.RePaintItem(item.Number, item.InventoryId);
            }).ToList();

            await Task.WhenAll(tasks);
        }

        private void FilterItems()
        {
            IReadOnlyList<ItemVm> filteredItems = new List<ItemVm>(_items);

            filteredItems = _itemFilterer.FilterByItemSearch(filteredItems, _view.ItemSearchValue, _view.ItemSearchType, EnumUtils.ToNullableEnum<StrictLooseFilterMode>(_view.ItemSearchFilterMode));
            filteredItems = _itemFilterer.FilterByItemCondition(filteredItems, EnumUtils.ToNullableEnum<ItemCondition>(_view.ItemCondition));
            filteredItems = _itemFilterer.FilterByItemType(filteredItems, EnumUtils.ToListOfEnum<ItemType>(_view.ItemTypes));
            filteredItems = _itemFilterer.FilterByItemColor(filteredItems, _colors.Where(color => color.Checked).Select(color => color.Id).ToList());
            filteredItems = _itemFilterer.FilterByItemCount(filteredItems, _view.ItemCount, EnumUtils.ToNullableEnum<MinMaxFilterMode>(_view.ItemCountFilterMode));

            _view.Items = filteredItems;
        }
    }
}
