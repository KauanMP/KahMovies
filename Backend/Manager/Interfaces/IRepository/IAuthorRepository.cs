using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllCategorysAsync();
        Task<Author> GetCategoryByIdAsync(int id);
        Task<Author> InsertCategoryAsync(Author author);
        Task<Author> UpdateCategoryAsync(Author author);
        Task<Author> DeleteCategoryAsync(int id);
    }
}