using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthorsAsync();
        Task<Author> GetAuthorByIdAsync(int id);
        Task<Author> InsertAuthorAsync(Author author);
        Task<Author> UpdateAuthorAsync(Author author);
        Task<Author> DeleteAuthorAsync(int id);
    }
}