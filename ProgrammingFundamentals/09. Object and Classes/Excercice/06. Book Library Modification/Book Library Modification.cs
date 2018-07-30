using System;
using System.Collections.Generic;
using System.Globalization;
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
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> booksReleasedAfterDate = new Dictionary<string, DateTime>();
            foreach (Book book in library.Books)
            {
                if (book.ReleaseDate.CompareTo(date) > 0 )
                {
                    booksReleasedAfterDate.Add(book.Title, book.ReleaseDate);
                }
            }

            foreach (var kvp in booksReleasedAfterDate.OrderBy(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:dd.MM.yyyy}");
            }
        }

        private static Book AddBookToList(string input)
        {
            var inputArgs = input.Split(' ');
            var title = inputArgs[0];
            DateTime releaseDate = DateTime.ParseExact(inputArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var price = decimal.Parse(inputArgs[5]);
            return new Book { Title = title, Price = price, ReleaseDate = releaseDate };
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}