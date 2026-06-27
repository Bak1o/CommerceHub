using CommerceHub.Domain.Commands;
using CommerceHub.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Abstractions
{
    public interface ICartService
    {
        Task CreateCartCommand(string customerId);
        Task AddItemAsync(AddToCartCommand command);
        Task UpdateQuantityAsync(UpdateQuantityInCartCommand command);
        Task RemoveItemAsync(string customerId,int productId);
        Task ClearCartAsync(string customerId);
        Task<Category> GetCartAsync(string customerId);
        
    }
}
