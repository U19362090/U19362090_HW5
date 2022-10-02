using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.Models
{//Create Model
    public class BorrowedBook
    {
        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public string TakenDate { get; set; }
        public string BroughtDate { get; set; }
        public string StudentName { get; set; }
    }
}