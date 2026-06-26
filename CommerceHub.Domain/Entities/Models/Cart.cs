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
        public void AddItem(int productId, int quantity)
        {
            var existingItem = Items.FirstOrDefault(x => x.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem { ProductId = productId, Quantity = quantity });
            }
        }
        public void RemoveItem(int productId)
        {
            var existingItem = Items.FirstOrDefault(x => x.ProductId == productId);
            if (existingItem != null)
            {
                Items.Remove(existingItem);
            }
        }
    }
}
