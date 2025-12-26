```csharp
using System.Collections.Generic;
using BookStoreApp.Models;
using BookStoreApp.Utils;

namespace BookStoreApp.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
            Logger.Log($"Added book: {book.Title} by {book.Author.GetFullName()}");
        }

        public List<Book> GetAllBooks()
        {
            //made changes here 2
            return _books;
        }
    }
}
```