using CommerceHub.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Commands.Abstractions
{
    public abstract class CartCommand
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public virtual void Validate()
        {
            if (ProductId <= 0)
                throw new ValidationException("ProductId must be positive");
            if (Quantity <= 0)
                throw new ValidationException("Quantity must be positive");
        }
    }
}
