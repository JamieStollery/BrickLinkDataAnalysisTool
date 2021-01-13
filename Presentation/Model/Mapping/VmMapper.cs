using AutoMapper;
using Presentation.Model.Items;
using Presentation.View.Model;

namespace Presentation.Model.Mapping
{
    public class VmMapper : IVmMapper
    {
        private readonly IMapper _mapper;

        public VmMapper()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Item, ItemVm>()
                .ForMember(vm => vm.FinalUnitPrice, opt => opt.MapFrom(item => $"{item.DisplayPrice.FinalUnitPrice} {item.DisplayPrice.CurrencyCode}"));
            });

            _mapper = mapperConfig.CreateMapper();
        }

        public ItemVm Map(Item item) => _mapper.Map<ItemVm>(item);
    }
}
