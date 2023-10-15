using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.ModelViews.Author;
using Manager.Interfaces.IManager;
using Manager.Interfaces.IRepository;

namespace Manager.Implementation
{
    public class AuthorManager : IAuthorManager
    {
        private readonly IAuthorRepository repository;
        private readonly IMapper mapper;

        public AuthorManager(IAuthorRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<AuthorView>> GetAllAuthorsAsync()
        {
            return mapper.Map<IEnumerable<AuthorView>>(await repository.GetAllAuthorsAsync());
        }

        public Task<AuthorView> GetAuthorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorView> InsertAuthorAsync(NewAuthor newAuthor)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorView> UpdateAuthorAsync(AuthorUpdate authorUpdate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAuthorAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}