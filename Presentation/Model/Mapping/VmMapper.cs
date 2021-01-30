using AutoMapper;
using Data.Common.Model.Dto;
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

                cfg.CreateMap<ColorDto, ColorVm>()
                .ForMember(vm => vm.Id, opt => opt.MapFrom(dto => dto.Color_id))
                .ForMember(vm => vm.Name, opt => opt.MapFrom(dto => dto.Color_name));
            });

            _mapper = mapperConfig.CreateMapper();
        }

        public ItemVm Map(Item item) => _mapper.Map<ItemVm>(item);

        public ColorVm Map(ColorDto color) => _mapper.Map<ColorVm>(color);
    }
}
