using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace SomerenService
{
    public class TeacherService
    {
        private TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAll();
            return teachers;
        }
        public void UpdateTeacher(Teacher teacher)
        {
            teacherdb.UpdateTeacher(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            teacherdb.DeleteTeacher(teacher);
        }

        public Teacher CreateTeacher(Teacher teacher)
        {
            teacherdb.CreateTeacher(teacher);
            return teacher;
        }
    }
}
