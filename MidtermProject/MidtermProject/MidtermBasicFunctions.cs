using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermProject.Models;

namespace MidtermProject
{
    public class MidtermBasicFunctions
    {
        // Function to return a single book by title
        public static Book GetBookByTitle(string title)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.FirstOrDefault(b => b.BookTitle == title);
            }
        }

        // Function to return a list of all books in the database
        public static List<Book> GetAllBooks()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.ToList();
            }
        }

        // Function to return a list of books written by a specific author by last name
        public static List<Book> GetByLN(string lastName)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.Where(b => b.Author.AuthorLast == lastName).ToList();
            }
        }
    }
}
