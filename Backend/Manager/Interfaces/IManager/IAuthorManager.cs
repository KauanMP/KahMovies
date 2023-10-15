using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Author;

namespace Manager.Interfaces.IManager
{
    public interface IAuthorManager
    {
        Task<IEnumerable<AuthorView>> GetAllAuthorsAsync();
        Task<AuthorView> GetAuthorByIdAsync(int id);
        Task<AuthorView> InsertAuthorAsync(NewAuthor newAuthor);
        Task<AuthorView> UpdateAuthorAsync(AuthorUpdate authorUpdate);
        Task<AuthorView> DeleteAuthorAsync(int id);
    }
}