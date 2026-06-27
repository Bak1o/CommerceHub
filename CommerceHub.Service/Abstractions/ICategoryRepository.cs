using CommerceHub.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceHub.Service.Abstractions
{
    public interface ICategoryRepository
    {
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
        Task<Category> GetByIdAsync(int id);
        Task<Category> GetByName(string name);
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
