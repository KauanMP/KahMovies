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
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await dbContext.Users
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(string email)
        {
            return await dbContext.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Email == email);
        }

        public async Task<User> InsertUserAsync(User user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            var findUser = await dbContext.Users.FindAsync(user.Email);

            if (findUser == null)
            {
                return null;
            }

            dbContext.Entry(findUser).CurrentValues.SetValues(user);
            await dbContext.SaveChangesAsync();
            return user;
        }

        public async Task DeleteUserAsync(string email)
        {
            var findUser = await dbContext.Users.FirstAsync(p => p.Email == email);

            dbContext.Remove(findUser);
            await dbContext.SaveChangesAsync();
        }
    }
}