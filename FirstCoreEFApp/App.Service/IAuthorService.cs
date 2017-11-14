using App.Data;
using System.Collections.Generic;

namespace App.Service
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        void AddAuthor(Author author);
        Author GetAuthor(long id);
        void UpdateAuthor(Author author);
        List<Author> GetAuthors();
    }
}
