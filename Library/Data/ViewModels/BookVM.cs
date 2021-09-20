using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.ViewModels
{
    //viewmodel => the reason why passing viewmodel instead of model itself is because
    //model have properties like id, dateadded 
    //which are properties that we dont ask the user to provide
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public string Genre { get; set; }
        public int? Rate { get; set; }
        public string CoverUrl { get; set; }
        public int PublisherId { get; set; }
        public List<int> AuthorIds { get; set; }
    }
    public class BookWithAuthorsVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public string Genre { get; set; }
        public int? Rate { get; set; }
        public string CoverUrl { get; set; }
        public string PublisherName { get; set; }
        public List<string> AuthorNames { get; set; }
    }
}
