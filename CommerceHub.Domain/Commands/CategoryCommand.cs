using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Commands
{
    public class CategoryCommand
    {
        public string Name { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("name");
            if (Name.Length < 1 || Name.Length > 100)
                throw new ArgumentException();
        }
    }
}
