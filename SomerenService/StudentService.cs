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

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAll();
            return students;
        }

        public void UpdateStudent(Student student)
        {
            studentdb.UpdateStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            studentdb.DeleteStudent(student);
        }

        public Student CreateStudent(Student student)
        {
            int studentId = studentdb.CreateStudent(student);
            student.SetId(studentId);
            return student;
        }
    }
}