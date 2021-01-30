using Data.Common.Model.Dto;
using Presentation.Model.Items;
using Presentation.View.Model;

namespace Presentation.Model.Mapping
{
    public interface IVmMapper
    {
        ItemVm Map(Item item);
        ColorVm Map(ColorDto color);
    }
}