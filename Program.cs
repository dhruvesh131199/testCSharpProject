using System;
using BookStoreApp.Models;
using BookStoreApp.Services;
using BookStoreApp.Utils;

namespace BookStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("📘 Welcome to the Book Store!");

            IBookService bookService = new BookService();
            DiscountService discountService = new DiscountService();

            var book = new Book("Clean Code", new Author("Robert", "Martin"), 29.99m);
            bookService.AddBook(book);

            decimal discountedPrice = discountService.ApplyDiscount(book.Price, 0.1m);
            Logger.Log($"Discounted price of '{book.Title}': ${discountedPrice}");

            Logger.Log("Application finished.");
        }
    }
}
