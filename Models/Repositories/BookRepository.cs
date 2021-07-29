using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        private readonly List<Book> _books;

        public BookRepository()
        {
            _books = new List<Book>()
            {
                new Book
                {
                    Id=1, Title="C# Programmin", Description="No description",
                },
                new Book
                {
                    Id=1, Title="Java Programmin", Description="Nothing",
                },
                new Book
                {
                    Id=1, Title="Python Programmin", Description="No data",
                },
            };
        }
        public void Add(Book entity)
        {
            _books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            _books.Remove(book);
        }

        public Book Find(int id)
        {
            var book= _books.SingleOrDefault(b => b.Id ==id);
            return book;
        }

        public IReadOnlyList<Book> List()
        {
            return _books;
        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);// la méthode find est déja définit // elle retourne l'id  Ligne 42
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;
        }
    }
}
