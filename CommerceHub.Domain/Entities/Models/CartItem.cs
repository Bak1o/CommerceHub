using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Entities.Models
{
    public class CartItem
    {
        public int Id { get; set; }
       
        public required int ProductId { get; set; }
        public required int Quantity { get; set; }
        public void Validate()
        {
            if (ProductId < 0) 
            throw new ArgumentOutOfRangeException();
            if (Quantity < 0)
                throw new ArgumentOutOfRangeException();
        }
    }
}
