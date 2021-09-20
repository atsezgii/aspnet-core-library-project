using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }
        public int BookId { get; set; } //F.K BOOK
        public Book Book { get; set; }//F.K BOOK
        public int AuthorId { get; set; }//F.K Author
        public Author Author { get; set; }//F.K Author

    }
}
