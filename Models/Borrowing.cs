using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFC.Models
{
    public class Borrowing
    {
        public int Id { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime PredictedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public int Rating { get; set; }
        public bool IsReturned { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
