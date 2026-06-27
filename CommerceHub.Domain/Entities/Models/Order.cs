using CommerceHub.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Entities.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string CustomerId { get; set; }
        public required string SellerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }

        public void Cancel()
        {
            if (Status != OrderStatus.Pending)
                throw new InvalidOperationException();
            Status = OrderStatus.Cancelled;
        }

        public void Confirm()
        {
            if (Status != OrderStatus.Pending)
                throw new InvalidOperationException();
            Status = OrderStatus.Confirmed;
        }

        public void Complete()
        {
            if (Status != OrderStatus.Confirmed)
                throw new InvalidOperationException();
            Status = OrderStatus.Completed;
        }


    }
}
