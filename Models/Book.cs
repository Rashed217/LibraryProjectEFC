using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int TotalCopies { get; set; }
        public int BorrowedCopies { get; set; }
        public decimal CopyPrice { get; set; }
        public TimeSpan AllowedBorrowingPeriod { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }
    }
}
