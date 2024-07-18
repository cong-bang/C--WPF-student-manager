using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRoleRepository
    {
        private Prn231Su23StudentGroupDbContext _context;
        public UserRole? GetAccount(string username, string password)
        {
            _context = new Prn231Su23StudentGroupDbContext();
            return _context.UserRoles.FirstOrDefault(x => (x.Username == username && x.Passphrase == password));
            
        }
    }
}
