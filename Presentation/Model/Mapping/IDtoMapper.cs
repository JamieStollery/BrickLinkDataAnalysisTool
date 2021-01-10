using Data.Common.Model.Dto;
using Presentation.Model.Orders;
using System.Collections.Generic;

namespace Presentation.Model.Mapping
{
    public interface IDtoMapper
    {
        KeyValuePair<OrderDto, IEnumerable<OrderItemDto>> Map(Order order);
        Order Map(OrderDto orderDto, IEnumerable<OrderItemDto> orderItemDtos);
    }
}