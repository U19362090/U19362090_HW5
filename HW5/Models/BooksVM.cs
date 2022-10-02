using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.Models
{//CreateViewModel
    public class BooksVM
    {
        public List<Book> Books { get; set; }   
        public List<Author> Authors { get; set; }
        public List<Types> Types { get; set; }
    }
}