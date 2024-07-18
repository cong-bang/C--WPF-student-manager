using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudentRepository
    {
        private Prn231Su23StudentGroupDbContext _context;
        public List<Student> GetStudents()
        {
            _context = new Prn231Su23StudentGroupDbContext();
            return _context.Students.Include("Group").ToList();
        }

        public void AddStudent(Student s)
        {
            _context = new Prn231Su23StudentGroupDbContext();
            _context.Students.Add(s);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student s)
        {
            _context = new Prn231Su23StudentGroupDbContext();
            _context.Students.Update(s);
            _context.SaveChanges();
        }

        public void DeleteStudent(Student s)
        {
            _context = new Prn231Su23StudentGroupDbContext();
            _context.Students.Remove(s);
            _context.SaveChanges();
        }

        public List<Student> SearchDateOfBirthStudents(int start, int end)
        {
            var students = _context.Students.Include(s => s.Group).Where(s => s.DateOfBirth.HasValue &&
                                                                     s.DateOfBirth.Value.Year >= start &&
                                                                     s.DateOfBirth.Value.Year <= end)
                                                              .OrderBy(s => s.DateOfBirth.Value.Date)
                                                              .ToList();
            return students;
        }

    }
}
