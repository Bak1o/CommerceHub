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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task AddCategory(CategoryCommand command)
        {
            var category = new Category();
            category.SetName(command);
            await _categoryRepository.AddAsync(category);
            
        }

        public async Task DeleteCategory(int categoryId)
        {
            var category = await _categoryRepository.GetByIdAsync(categoryId);
            if (category == null) 
                throw new ObjectNotFoundException(categoryId);

            await _categoryRepository.DeleteAsync(categoryId);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _categoryRepository.GetAllAsync() ?? Enumerable.Empty<Category>();
        }

        public async Task<Category> GetByIdAsync(int categoryId)
        {
            var category = await _categoryRepository.GetByIdAsync(categoryId);
            if (category == null)
                throw new ObjectNotFoundException(categoryId);

            return category;
           
        }

        public async Task<Category> GetByNameAsync(string name)
        {
            var category = await _categoryRepository.GetByName(name);
            if (category == null)
                throw new ObjectNotFoundException(name);

            return category;
        }

        public async Task UpdateCategory(UpdateCategoryCommand command)
        {
            var category = await _categoryRepository.GetByIdAsync(command.Id);
            if (category == null)
                throw new ObjectNotFoundException(command.Id);

            await _categoryRepository.UpdateAsync(category);
        }
    }
}
