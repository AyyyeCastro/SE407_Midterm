using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public static Book GetBookByID(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var book = db.Books
                  .Include(books => books.Author)
                  .Include(books => books.Genre)
                  .Where(books => books.BookId == id)
                  .FirstOrDefault(); 

                return book;
            }
        }

        public static Author GetAuthorByID(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var author = db.Authors
                  .Where(author => author.AuthorId == id)
                  .FirstOrDefault();

                return author;
            }
        }

        public static Genre GetGenreByID(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                var genre = db.Genres
                  .Where(genre => genre.GenreId == id)
                  .FirstOrDefault();

                return genre;
            }
        }

        public static List<Genre> GetAllGenres()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Genres.ToList();
            }

        }
        public static List<Author> GetAllAuthors()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Authors.ToList();
            }

        }

        public static List<Book> GetAllBooksFull()
        {
            using (var db = new SE407_BookStoreContext())
            {
                var books = db.Books
                    .Include(books => books.Author)
                    .Include(books => books.Genre)
                    .ToList();

                return books;

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
