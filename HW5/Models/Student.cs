using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.Models
{//Create Model
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Class { get; set; }
        public int Points { get; set; }
        public bool Book { get; set; }
        
    }
}