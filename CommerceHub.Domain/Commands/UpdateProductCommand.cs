using CommerceHub.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Commands
{
    public class UpdateProductCommand
    {
        public required int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        
        public void Validate()
        {
            if (ProductId <= 0)
                throw new ValidationException(nameof(ProductId) + " Must be positive");
            if (Name is not null && (Name.Length < 1 || Name.Length > 100))
                throw new ValidationException(nameof(Name) + " Length");
            if (Brand is not null && (Brand.Length < 1 || Brand.Length > 100))
                throw new ValidationException(nameof(Brand) + " Length");
            if (Price is not null && Price < 0)
                throw new ValidationException(nameof(Price) + " Must not be negative");
            if (Stock is not null && Stock < 0)
                throw new ValidationException(nameof(Stock) + " Must not be negative");
            if (Description is not null && (Description.Length < 1 || Description.Length > 4000))
                throw new ValidationException(nameof(Description) + " Length");
            if (CategoryId is not null &&  CategoryId <= 0)
                throw new ValidationException(nameof(CategoryId) + " Must  be positive");
        }
    }
}
