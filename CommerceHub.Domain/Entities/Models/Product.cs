using CommerceHub.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string OwnerId { get; set; }

        public Product()
        {

        }
        public void AddProduct(CreateProductCommand command)
        {
            command.Validate();
            Name = command.Name;
            Brand = command.Brand;
            Price = command.Price;
            Stock = command.Stock;
            Description = command.Description;
            CategoryId = command.CategoryId;
            OwnerId = command.OwnerId;
        }
        public void UpdateProduct(UpdateProductCommand command)
        {
            command.Validate();
            if (command.Name is not null)
                Name = command.Name;
            if (command.Brand is not null)
                Brand = command.Brand;
            if (command.Price is not null)
                Price = command.Price.Value;
            if (command.Stock is not null)
                Stock = command.Stock.Value;
            if (command.Description is not null)
                Description = command.Description;
            if (command.CategoryId is not null)
                CategoryId = command.CategoryId.Value;

        }
       
    }
}
