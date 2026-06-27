using CommerceHub.Domain.Commands;
using CommerceHub.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Entities.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public required string CustomerId { get; set; }
        public List<CartItem> Items { get; set; }

        public Cart() 
        {
            Items = new List<CartItem>();
        }
        public void AddItem(AddToCartCommand command)
        {
            command.Validate();
            var existingItem = Items.FirstOrDefault(x => x.ProductId == command.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += command.Quantity;
            }
            else
            {
                Items.Add(new CartItem { ProductId = command.ProductId, Quantity = command.Quantity });
            }
        }
        public void RemoveItem(int productId)
        {
            var existingItem = Items.FirstOrDefault(x => x.ProductId == productId);
            if (existingItem == null)
                throw new ObjectNotFoundException(productId);
               
                    Items.Remove(existingItem);
            
        }
        public void UpdateQuantity (UpdateQuantityInCartCommand command)
        {
            command.Validate();
            var existingItem = Items.FirstOrDefault(x => x.ProductId == command.ProductId);
            if (existingItem == null)
                throw new ObjectNotFoundException(command.ProductId);
               
            existingItem.Quantity = command.Quantity;
            
        }
        public void Clear()
        {
            Items.Clear();
        }

    }
}
