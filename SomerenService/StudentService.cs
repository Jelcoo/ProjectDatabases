using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents(string sortBy = null)
        {
            List<Student> students = studentdb.GetAll(sortBy);
            return students;
        }
    }
}