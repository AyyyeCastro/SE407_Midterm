using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermProject;
using CsvHelper;
using System.Collections;
using System.Globalization;
using System.IO;
using MidtermProject.Models;


namespace MidtermCOnsole
{
    class outputhelper
    {
        // Function to display all books
        public void ConsoleDisplayAllBooks(List<Book> books)
        {
            Console.WriteLine("List of Books");
            foreach (var b in books)
            {
                Console.WriteLine($"BookID::{b.BookId}   Title:{b.BookTitle}   Year of Release:{b.YearOfRelease}");
            }
        }




        // Function to write all books to CSV
        public void WriteBooksToCSV(List<Book> books)
        {
            using (var writer = new StreamWriter(@"..\books.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(books);
            }
        }

        // Function to display books by title
        public void ConsoleBooksByTitle(string title)
        {
            var book = MidtermBasicFunctions.GetBookByTitle(title);
            if (book != null)
            {
                Console.WriteLine($"BookID::{book.BookId}   Title:{book.BookTitle}   Year of Release:{book.YearOfRelease}");
            }
            else
            {
                Console.WriteLine($"Sorry: {title} does not exist in the database.");
            }
        }

        // Function to display books by author last name
        public void ConsoleBooksByAuthorLN(string lastName)
        {
            var books = MidtermBasicFunctions.GetByLN(lastName);
            if (books.Any())
            {
                Console.WriteLine($"Books written by '{lastName}':");
                foreach (var b in books)
                {
                    Console.WriteLine($"BookID::{b.BookId}   Title:{b.BookTitle}   Year of Release:{b.YearOfRelease}");
                }
            }
            else
            {
                Console.WriteLine($"No books found for author: '{lastName}'.");
            }
        }

        // Function to write books by title to CSV
        public void WriteBooksByTitle(string title)
        {
            var book = MidtermBasicFunctions.GetBookByTitle(title);
            if (book != null)
            {
                var books = new List<Book> { book };
                using (var writer = new StreamWriter(@"..\byTitle.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(books);
                }
            }
            else
            {
                Console.WriteLine($"Sorry: {title} does not exist in the database.");
            }
        }

        public void WriteBooksByAuthLN(string lastName)
        {
            var movies = MidtermBasicFunctions.GetByLN(lastName);
            if (movies.Any())
            {
                using (var writer = new StreamWriter(@"..\byLastName.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(movies);
                }
            }
            else
            {
                Console.WriteLine($"No movies for Director: {lastName}.");
            }
        }       }
}
