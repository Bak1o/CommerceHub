using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Exceptions
{
    public class ObjectNotFoundException : DomainException
    {
        public ObjectNotFoundException(int id) : base($" Item with id :{productId} was not found")
        { 
        }
        public ObjectNotFoundException(string name) : base($" item with {name} was not found ")
        {
            
        }
    }
}
