using System.Collections.Generic;
using System.Linq;

namespace BookStore.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
        private readonly List<Author> _authors;

        public AuthorRepository()
        {
            _authors = new List<Author>()
            {
                new Author{Id=1, Fullname="Marie Claire"},
                new Author{Id=2, Fullname="Fatima Alaa"},
                new Author{Id=3, Fullname="Ahmed chleh"},
            };
        }

        public void Add(Author entity)
        {
            _authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            _authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = _authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IReadOnlyList<Author> List()
        {
            return _authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.Fullname = newAuthor.Fullname;
        }
    }
}
