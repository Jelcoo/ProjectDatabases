using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class TeacherService
    {
        private TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }

        public List<Teacher> GetTeachers(string sortBy = null)
        {
            List<Teacher> teachers = teacherdb.GetAll(sortBy);
            return teachers;
        }
    }
}
