using System;
using System.Collections.Generic;
using System.Linq;
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
            if (Name.Length < 1 || Name.Length > 100)
                throw new ArgumentException();
            if (Brand.Length < 1 || Brand.Length > 100)
                throw new ArgumentException();
            if (Price < 0)
                throw new ArgumentException();
            if (Stock < 0)
                throw new ArgumentException();
            if (Description.Length < 1 || Description.Length > 4000)
                throw new ArgumentException();
        }
    }
}
