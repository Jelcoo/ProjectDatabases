using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;
using System;
using System.Globalization;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAll(string sortBy = null)
        {
            string query = "SELECT teacherId, firstName, lastName, phoneNumber, dateOfBirth, roomId FROM [teachers]";

            if (sortBy != null)
            {
                query += $" ORDER BY {sortBy}";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

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
