using CommerceHub.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Abstractions
{
    public interface IOrderService
    {
        Task PlaceOrder(string customerId);
        Task CancelOrderAsync(int orderId, string customerId);
        Task ConfirmOrderAsync(int orderId, string sellerId);
        Task CompleteOrderAsync(int orderId, string customerId);
        Task<Order> GetByIdAsync(int orderId);
    }
}
