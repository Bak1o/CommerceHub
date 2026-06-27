using CommerceHub.Domain.Commands;
using CommerceHub.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Abstractions
{
    public interface IProductService
    {
        Task AddProduct(CreateProductCommand command);
        Task UpdateProduct(UpdateProductCommand command);
        Task DeleteProduct(int  productId);
        Task<Product> GetByIdAsync(int productId);
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
