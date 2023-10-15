using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Manager.Interfaces.IRepository;

namespace Infrastructure.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public Task<Author> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> GetAllCategorysAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Author> InsertCategoryAsync(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<Author> UpdateCategoryAsync(Author author)
        {
            throw new NotImplementedException();
        }
    }
}