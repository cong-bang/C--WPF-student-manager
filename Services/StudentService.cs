using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StudentService
    {
        private StudentRepository _repo = new StudentRepository();

        public List<Student> GetStudentList()
        {
            return _repo.GetStudents();
        }

        public void AddStudentFromUI(Student s)
        {
            
            _repo.AddStudent(s);
        }

        public void UpdateStudentFromUI(Student s)
        {
            _repo.UpdateStudent(s);
        }

        public void DeleteStudentFromUI(Student s)
        {
            _repo.DeleteStudent(s);
        }

        public List<Student> GetSearchBirthDayStudents(int start, int end) 
        {
            return _repo.SearchDateOfBirthStudents(start, end);
        }
    }
}
