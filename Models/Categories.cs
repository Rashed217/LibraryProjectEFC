﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfBooks { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}