using CommerceHub.Domain.Abstractions;
using CommerceHub.Domain.Commands;
using CommerceHub.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Service.Services
{
    public class CartService : ICartService
    {
        public Task AddItemAsync(AddToCartCommand command)
        {
            throw new NotImplementedException();
        }

        public Task ClearCartAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task CreateCartCommand(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCartAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveItemAsync(string customerId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateQuantityAsync(UpdateQuantityInCartCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
