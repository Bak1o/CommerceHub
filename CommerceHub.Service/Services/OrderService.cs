using CommerceHub.Domain.Abstractions;
using CommerceHub.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Service.Services
{
    public class OrderService : IOrderService
    {
        public Task CancelOrderAsync(int orderId, string customerId)
        {
            throw new NotImplementedException();
        }

        public Task CompleteOrderAsync(int orderId, string customerId)
        {
            throw new NotImplementedException();
        }

        public Task ConfirmOrderAsync(int orderId, string sellerId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task PlaceOrder(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}
