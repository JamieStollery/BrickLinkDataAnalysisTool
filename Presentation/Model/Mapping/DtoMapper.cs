using AutoMapper;
using Data.Common.Model.Dto;
using Presentation.Model.Items;
using Presentation.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using OrderWithItems = System.Collections.Generic.KeyValuePair<Data.Common.Model.Dto.OrderDto, System.Collections.Generic.IEnumerable<Data.Common.Model.Dto.OrderItemDto>>;

namespace Presentation.Model.Mapping
{
    public class DtoMapper : IDtoMapper
    {
        private readonly IMapper _mapper;

        public DtoMapper()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderWithItems, Order>()
                    .ForCtorParam("id", opt => opt.MapFrom(kvp => kvp.Key.Order_id))
                    .ForCtorParam("dateOrdered", opt => opt.MapFrom(kvp => kvp.Key.Date_ordered))
                    .ForCtorParam("sellerName", opt => opt.MapFrom(kvp => kvp.Key.Seller_name))
                    .ForCtorParam("storeName", opt => opt.MapFrom(kvp => kvp.Key.Store_name))
                    .ForCtorParam("buyerName", opt => opt.MapFrom(kvp => kvp.Key.Buyer_name))
                    .ForCtorParam("totalCount", opt => opt.MapFrom(kvp => kvp.Key.Total_count))
                    .ForCtorParam("uniqueCount", opt => opt.MapFrom(kvp => kvp.Key.Unique_count))
                    .ForCtorParam("status", opt => opt.MapFrom(kvp => Enum.Parse(typeof(OrderStatus), kvp.Key.Status, true)))
                    .ForCtorParam("payment", opt => opt.MapFrom((kvp, ctx) => ctx.Mapper.Map<Payment>(kvp.Key.Payment)))
                    .ForCtorParam("cost", opt => opt.MapFrom((kvp, ctx) => ctx.Mapper.Map<Cost>(kvp.Key.Cost)))
                    .ForCtorParam("items", opt => opt.MapFrom((kvp, ctx) => kvp.Value.Select(dto => ctx.Mapper.Map<Item>(dto)).ToList()));

                cfg.CreateMap<Order, OrderDto>()
                    .ForMember(dto => dto.Order_id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dto => dto.Date_ordered, opt => opt.MapFrom(src => src.DateOrdered))
                    .ForMember(dto => dto.Seller_name, opt => opt.MapFrom(src => src.SellerName))
                    .ForMember(dto => dto.Store_name, opt => opt.MapFrom(src => src.StoreName))
                    .ForMember(dto => dto.Buyer_name, opt => opt.MapFrom(src => src.BuyerName))
                    .ForMember(dto => dto.Total_count, opt => opt.MapFrom(src => src.TotalCount))
                    .ForMember(dto => dto.Unique_count, opt => opt.MapFrom(src => src.UniqueCount))
                    .ForMember(dto => dto.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dto => dto.Payment, opt => opt.MapFrom((src, dest, mem, ctx) => ctx.Mapper.Map<PaymentDto>(src.Payment)))
                    .ForMember(dto => dto.Cost, opt => opt.MapFrom((src, dest, mem, ctx) => ctx.Mapper.Map<CostDto>(src.Cost)));

                cfg.CreateMap<PaymentDto, Payment>()
                    .ForCtorParam("method", opt => opt.MapFrom(dto => dto.Method))
                    .ForCtorParam("status", opt => opt.MapFrom(dto => Enum.Parse(typeof(PaymentStatus), dto.Status, true)))
                    .ForCtorParam("datePaid", opt => opt.MapFrom(dto => dto.Date_paid))
                    .ForCtorParam("currencyCode", opt => opt.MapFrom(dto => dto.Currency_code))
                    .ReverseMap();

                cfg.CreateMap<CostDto, Cost>()
                    .ForCtorParam("subtotal", opt => opt.MapFrom(dto => dto.Subtotal))
                    .ForCtorParam("grandTotal", opt => opt.MapFrom(dto => dto.Grand_total))
                    .ForCtorParam("currencyCode", opt => opt.MapFrom(dto => dto.Currency_code))
                    .ReverseMap();

                cfg.CreateMap<OrderItemDto, Item>()
                    .ForCtorParam("number", opt => opt.MapFrom(dto => dto.Item.No))
                    .ForCtorParam("inventoryId", opt => opt.MapFrom(dto => dto.Inventory_id))
                    .ForCtorParam("name", opt => opt.MapFrom(dto => dto.Item.Name))
                    .ForCtorParam("type", opt => opt.MapFrom(dto => Enum.Parse(typeof(ItemType), dto.Item.Type, true)))
                    .ForCtorParam("categoryId", opt => opt.MapFrom(dto => dto.Item.CategoryID))
                    .ForCtorParam("colorId", opt => opt.MapFrom(dto => dto.Color_id))
                    .ForCtorParam("quantity", opt => opt.MapFrom(dto => dto.Quantity))
                    .ForCtorParam("condition", opt => opt.MapFrom(dto => dto.New_or_used == 'N' ? ItemCondition.New : ItemCondition.Used)) // Maybe add custom value resolver
                    .ForCtorParam("completeness", opt => opt.MapFrom(dto => dto.Completeness))
                    .ForCtorParam("description", opt => opt.MapFrom(dto => dto.Description))
                    .ForCtorParam("remarks", opt => opt.MapFrom(dto => dto.Remarks))
                    .ForCtorParam("originalPrice", opt => opt.MapFrom(dto => new Price(dto.Unit_price, dto.Unit_price_final, dto.Currency_code)))
                    .ForCtorParam("displayPrice", opt => opt.MapFrom(dto => new Price(dto.Disp_unit_price, dto.Disp_unit_price_final, dto.Disp_currency_code)))
                    .ReverseMap()
                    .ForMember(dest => dest.New_or_used, opt => opt.MapFrom(src => src.Condition == ItemCondition.New ? 'N' : 'U'))
                    .ForMember(dest => dest.Unit_price, opt => opt.MapFrom(src => src.OriginalPrice.UnitPrice))
                    .ForMember(dest => dest.Unit_price_final, opt => opt.MapFrom(src => src.OriginalPrice.FinalUnitPrice))
                    .ForMember(dest => dest.Currency_code, opt => opt.MapFrom(src => src.OriginalPrice.CurrencyCode))
                    .ForMember(dest => dest.Disp_unit_price, opt => opt.MapFrom(src => src.DisplayPrice.UnitPrice))
                    .ForMember(dest => dest.Disp_unit_price_final, opt => opt.MapFrom(src => src.DisplayPrice.FinalUnitPrice))
                    .ForMember(dest => dest.Disp_currency_code, opt => opt.MapFrom(src => src.DisplayPrice.CurrencyCode))
                    .ForMember(dest => dest.Item, opt => opt.MapFrom((src, dest, mem, ctx) => ctx.Mapper.Map<ItemDto>(src)));

                cfg.CreateMap<Item, ItemDto>()
                    .ForMember(dest => dest.No, opt => opt.MapFrom(src => src.Number))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.CategoryID, opt => opt.MapFrom(src => src.CategoryId));
            });
            _mapper = new Mapper(mapperConfig);
        }

        public Order Map(OrderDto orderDto, IEnumerable<OrderItemDto> orderItemDtos) => _mapper.Map<Order>(new OrderWithItems(orderDto, orderItemDtos));

        public OrderWithItems Map(Order order)
        {
            var orderDto = _mapper.Map<OrderDto>(order);
            var orderItemDtos = order.Items.Select(item => _mapper.Map<OrderItemDto>(item));
            return new OrderWithItems(orderDto, orderItemDtos);
        }
    }
}
