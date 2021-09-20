using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.ViewModels
{
    public class PublisherVM //publisher id sini gönderince publishera bağlı kitaplar ve kitaplara bağlı yazarları alabilmke adına 
    {
        public string Name { get; set; }
    }
    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }
        public List<BookAuthorVM> BookAuthors { get; set; }

    }
    public class BookAuthorVM
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }
}
