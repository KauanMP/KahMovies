using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence;
using Manager.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext dbContext;

        public AuthorRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            return await dbContext.Authors.AsNoTracking().ToListAsync();
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            return await dbContext.Authors.SingleOrDefaultAsync(p => p.Id == id);
        }

        public Task<Author> InsertAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<Author> UpdateAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<Author> DeleteAuthorAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}