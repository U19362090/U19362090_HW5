using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    //Create a ViewModel
    public class StudentVM
    {
        public List<Student> Students { get; set; }
        public Book Book { get; set; }
        public List<Class> Class { get; set; }

    }
}