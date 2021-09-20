using Library.Data.Models;
using Library.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class PublisherService
    {
        private AppDbContext _context;
        public PublisherService(AppDbContext context)
        {
            _context = context;
        }
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
        public PublisherWithBooksAndAuthorsVM GetPublisherWithId(int publisherId)
        {
            var _publisher = _context.Publishers.Where(p => p.Id == publisherId)
                             .Select(n => new PublisherWithBooksAndAuthorsVM()
                             {
                                 Name = n.Name,
                                 BookAuthors = n.Books.Select(n => new BookAuthorVM()
                                 {
                                     BookName = n.Title,
                                     BookAuthors = n.Book_Authors.Select(n => n.Author.FullName).ToList()
                                 }).ToList()
                             }).FirstOrDefault();
            return _publisher;
            
        }

        public void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(p => p.Id == id);
            if (_publisher != null)
            {
                _context.Publishers.Remove(_publisher);
                _context.SaveChanges(); //Publisher has multiple books, books have multiple authors (or author)
            }
        }

    }
}
