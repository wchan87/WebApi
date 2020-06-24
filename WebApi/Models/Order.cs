using System;

namespace WebApi.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long PetId { get; set; }
        public int Quantity { get; set; }
        // TODO setup as string($date-time)
        public string ShipDate { get; set; }
        public OrderStatus Status { get; set; }
        public Boolean Complete { get; set; }

        public enum OrderStatus
        {
            placed,
            approved,
            delivered
        }
    }
}
