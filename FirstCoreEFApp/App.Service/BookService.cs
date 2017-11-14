using App.Data;
using App.Repo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace App.Service
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetQueryable().Include(b => b.Author).ToList();
        }

        public void AddBook(Book book)
        {
            _bookRepository.Insert(book);
        }

        public Book GetBook(long id)
        {
            return _bookRepository.Get(id);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }

        public void DeleteBook(Book book)
        {
            _bookRepository.Delete(book);
        }
    }
}
