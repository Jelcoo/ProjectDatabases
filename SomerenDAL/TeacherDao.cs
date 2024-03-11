using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAll()
        {
            SqlCommand command = new SqlCommand("SELECT teacherId, firstName, lastName, phoneNumber, dateOfBirth, roomId FROM [teachers]", OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Teacher> teachers = new List<Teacher>();

            while (reader.Read())
            {
                Teacher teacher = ReadTeacher(reader);
                teachers.Add(teacher);
            }
            reader.Close();
            CloseConnection();

            return teachers;
        }

        private Teacher ReadTeacher(SqlDataReader reader)
        {
            Teacher teacher = new Teacher()
            {
                TeacherId = (int)reader["teacherId"],
                FirstName = reader["firstName"].ToString(),
                LastName = reader["lastName"].ToString(),
                DateOfBirth = DateTime.Parse(reader["dateOfBirth"].ToString()),
                PhoneNumber = reader["phoneNumber"].ToString(),
                RoomId = (int)reader["roomId"]
            };

            return teacher;
        }
    }
}
