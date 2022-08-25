using EShopApi.Entities.OrderAggregate;

namespace EShopApi.DTOs
{
    public class CreateOrderDto
    {

        public bool SaveAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
    }
}
