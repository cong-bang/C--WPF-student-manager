using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudentGroupRepository
    {
        private Prn231Su23StudentGroupDbContext _context;
        public List<StudentGroup> GetStudentGroups()
        {
            _context = new Prn231Su23StudentGroupDbContext();
            return _context.StudentGroups.ToList();
        }

        
    }
}
