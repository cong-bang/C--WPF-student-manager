using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StudentGroupService
    {
        private StudentGroupRepository _repo = new StudentGroupRepository();
        public List<StudentGroup> GetStudentGroupList()
        {
            return _repo.GetStudentGroups();
        }
        
    }
}
