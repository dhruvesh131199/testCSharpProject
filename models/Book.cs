namespace BookStoreApp.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public decimal Price { get; set; }

        public Book(string title, Author author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}