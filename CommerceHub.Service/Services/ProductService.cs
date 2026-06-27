using CommerceHub.Domain.Abstractions;
using CommerceHub.Domain.Commands;
using CommerceHub.Domain.Entities.Models;
using CommerceHub.Domain.Exceptions;
using CommerceHub.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository repository)
        {
            _productRepository = repository;
        }
        public async Task AddProduct(CreateProductCommand command)
        {
            var product = new Product();
            product.AddProduct(command);
            await _productRepository.AddAsync(product);

        }

        public async Task DeleteProduct(int productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            if (product == null)
             throw new ObjectNotFoundException(productId);

            await _productRepository.DeleteAsync(productId);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync() ?? Enumerable.Empty<Product>();
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            if (product == null)
                throw new ObjectNotFoundException(productId);

            return product;
        }

        public async Task UpdateProduct(UpdateProductCommand command)
        {
            command.Validate();
            var product = await _productRepository.GetByIdAsync(command.ProductId);
            
            if (product is null)
                throw new ObjectNotFoundException(command.ProductId);
           
            product.UpdateProduct(command);
            await _productRepository.UpdateAsync(product);
        }
    }
}
