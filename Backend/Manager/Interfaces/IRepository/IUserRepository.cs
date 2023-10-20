using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(string email);
        Task<User> InsertUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task DeleteUserAsync(string email);
    }
}