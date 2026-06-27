using CommerceHub.Domain.Commands;
using CommerceHub.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Domain.Abstractions
{
    public interface ICategoryService
    {
        Task AddCategory(CategoryCommand command);
        Task UpdateCategory(UpdateCategoryCommand command);
        Task DeleteCategory(int categoryId);
        Task<Category> GetByIdAsync(int categoryId);
        Task<Category> GetByNameAsync(string name);
        Task<IEnumerable<Category>> GetAllAsync();

    }
}
