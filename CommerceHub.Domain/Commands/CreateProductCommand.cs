using CommerceHub.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string OwnerId { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name) || Name.Length > 100)
                throw new ValidationException(nameof(Name) + " Lenght");
            if (string.IsNullOrWhiteSpace(Brand) || Brand.Length > 100)
                throw new ValidationException(nameof(Brand) + " Lenght");
            if (Price < 0)
                throw new ValidationException(nameof(Price) + " Must not be Negative");
            if (Stock < 0)
                throw new ValidationException(nameof(Stock) + " Must not be negative");
            if (string.IsNullOrWhiteSpace(Description) || Description.Length > 4000)
                throw new ValidationException(nameof(Description) + " Lenght");
            if (CategoryId <= 0)
                throw new ValidationException(nameof(CategoryId) + " is required");
            if (string.IsNullOrWhiteSpace(OwnerId))
                throw new ValidationException(nameof(OwnerId) + " is required");
        }
    }
}
