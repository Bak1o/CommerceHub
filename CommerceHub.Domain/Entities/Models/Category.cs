using CommerceHub.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Entities.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public Category()
        {

        }
        public void SetName(CategoryCommand command)
        {
            command.Validate();
            Name = command.Name;
            
        }
        
       
    }
}
