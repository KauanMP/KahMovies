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

        public async Task<Author> InsertAuthorAsync(Author author)
        {
            await dbContext.AddAsync(author);
            await dbContext.SaveChangesAsync();

            return author;
        }

        public async Task<Author> UpdateAuthorAsync(Author author)
        {
            var findAuthors = await dbContext.Authors.FindAsync(author.Id);

            if (findAuthors == null)
            {
                return null;
            }

            dbContext.Entry(findAuthors).CurrentValues.SetValues(author);
            await dbContext.SaveChangesAsync();

            return author;
        }

        public async Task DeleteAuthorAsync(int id)
        {
            var findAuthors = await dbContext.Authors.FindAsync(id);

            dbContext.Authors.Remove(findAuthors);
            await dbContext.SaveChangesAsync();
        }
    }
}