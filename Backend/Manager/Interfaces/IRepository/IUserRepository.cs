using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Manager.Interfaces.IRepository
{
    public interface IUserRepository
    {
        List<IEnumerable<User>> GetAllUsersAsync();
        List<User> GetUserByIdAsync(int id);
        List<User> InsertUserAsync(User user);
        List<User> UpdateUserAsync(User user);
        List<User> DeleteUserAsync(int id);
    }
}