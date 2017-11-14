using App.Data;
using System.Collections.Generic;

namespace App.Service
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        Book GetBook(long id);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}
