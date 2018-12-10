using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.Entities;

namespace LibraryApi.Services
{
    public class LibraryRepository : IRepository
    {
        private LibraryContext _context;

        public LibraryRepository(LibraryContext context)
        {
            _context = context;
        }


        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void AddBookForAuthor(Guid authorId, Book book)
        {
            throw new NotImplementedException();
        }

        public bool AuthorExsts(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds)
        {
            throw new NotImplementedException();
        }

        public Book GetBookForAuthor(Guid authorId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooksForAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void UpdateBookForAuthor(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
