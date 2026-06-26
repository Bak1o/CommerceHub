using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Commands
{
    public class AddToCartCommand
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
