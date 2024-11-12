using LibraryEFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFC.Repositories
{
    public class AdminRepository
    {
        private readonly LibraryContext _context;

        public AdminRepository(LibraryContext context)
        {
            _context = context;
        }

        public List<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }

        public Admin GetByEmail(string email)
        {
            return _context.Admins.FirstOrDefault(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public void Insert(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public void UpdateByEmail(string email, Admin updatedAdmin)
        {
            var admin = GetByEmail(email);
            if (admin != null)
            {
                admin.Name = updatedAdmin.Name;
                admin.Password = updatedAdmin.Password;
                _context.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var admin = _context.Admins.Find(id);
            if (admin != null)
            {
                _context.Admins.Remove(admin);
                _context.SaveChanges();
            }
        }
    }
}
