using BookStoreApp.Models;
using System.Collections.Generic;

namespace BookStoreApp.Services
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
    }
}
