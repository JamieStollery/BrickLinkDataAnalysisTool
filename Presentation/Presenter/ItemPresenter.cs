using Data.Common.Repository.Interface;
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
        private readonly MainStagePresenter _stagePresenter;
        private readonly IReadOnlyList<ItemVm> _items;
        private readonly IItemImageRepository _repository;

        public ItemPresenter(IItemView view, MainStagePresenter stagePresenter, IItemImageRepository repository, IReadOnlyList<ItemVm> items)
        {
            _view = view;
            _stagePresenter = stagePresenter;
            _items = items;
            _repository = repository;

            _view.OnViewOpened = () => Task.Run(() => LoadItemImages());
            _view.Items = _items;
        }

        public Action BackToOrderView { set => _view.OnBackButtonClick = value; }

        public void OpenView() => _stagePresenter.OpenView(_view);

        private async Task LoadItemImages()
        {
            var tasks = _items.Select(async item =>
            {
                item.Image = Image.FromStream(await _repository.GetItemImage(item.Type, item.Number, item.ColorId));
                _view.RePaintItem(item.Number, item.InventoryId);
            }).ToList();

            await Task.WhenAll(tasks);
        }
    }
}
