using App.Data;
using App.Repo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace App.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void AddAuthor(Author author)
        {
            _authorRepository.Insert(author);
        }

        public List<Author> GetAllAuthors()
        {
            return _authorRepository.GetQueryable().Include(c => c.Books).ToList();
        }

        public Author GetAuthor(long id)
        {
            return _authorRepository.Get(id);
        }

        public List<Author> GetAuthors()
        {
            return _authorRepository.GetAll().ToList();
        }

        public void UpdateAuthor(Author author)
        {
            _authorRepository.Update(author);
        }
    }
}
