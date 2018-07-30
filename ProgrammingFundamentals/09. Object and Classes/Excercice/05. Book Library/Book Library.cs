using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                books.Add(AddBookToList(input));
            }
            Library library = new Library { Books = books };
            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();
            foreach (Book book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }
                else
                {
                    authors[book.Author] = book.Price;
                }
            }
            foreach (var kvp in authors.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }

        private static Book AddBookToList(string input)
        {
            var inputArgs = input.Split(' ').ToArray();
            var author = inputArgs[1];
            var price = decimal.Parse(inputArgs[5]);
            return new Book { Author = author, Price = price };
        }
    }

    public class Book
    {
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
