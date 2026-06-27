using CommerceHub.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Commands
{
    public class UpdateCategoryCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Validate()
        {
            if (Id <= 0)
                throw new ValidationException("Id must be positive");
            if (string.IsNullOrWhiteSpace(Name))
                throw new ValidationException(nameof(UpdateCategoryCommand) + " must not be empty");
            if (Name.Length > 100)
                throw new ValidationException("Name too large");
        }
    }
}
