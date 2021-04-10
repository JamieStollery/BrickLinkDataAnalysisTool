using AutoMapper;
using Data.Common.Model.Dto;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using Presentation.View.Model;
using System.Globalization;

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
                .ForMember(vm => vm.FinalUnitPrice, opt => opt.MapFrom(item => $"{item.DisplayPrice.FinalUnitPrice:0.00} {item.DisplayPrice.CurrencyCode}"));

                cfg.CreateMap<ColorDto, ColorVm>()
                .ForMember(vm => vm.Id, opt => opt.MapFrom(dto => dto.Color_id))
                .ForMember(vm => vm.Name, opt => opt.MapFrom(dto => dto.Color_name));

                cfg.CreateMap<Order, OrderVm>()
                .ForMember(vm => vm.DateOrdered, opt => opt.MapFrom(order => order.DateOrdered.ToString("d", CultureInfo.GetCultureInfo("en-GB"))))
                .ForMember(vm => vm.PaymentStatus, opt => opt.MapFrom(order => order.Payment.Status))
                .ForMember(vm => vm.GrandTotal, opt => opt.MapFrom(order => $"{order.Cost.GrandTotal:0.00} {order.Cost.CurrencyCode}"));
            });

            _mapper = mapperConfig.CreateMapper();
        }

        public ItemVm Map(Item item) => _mapper.Map<ItemVm>(item);

        public ColorVm Map(ColorDto color) => _mapper.Map<ColorVm>(color);

        public OrderVm Map(Order order) => _mapper.Map<OrderVm>(order);
    }
}
