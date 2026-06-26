using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Commands
{
    public class RemoveFromCartCommand
    {
        public int ProductId {  get; set; }
    }
}
