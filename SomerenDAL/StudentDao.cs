using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAll()
        {
            SqlCommand command = new SqlCommand("SELECT studentId, firstName, lastName, phoneNumber, class, vouchers, roomId FROM [students]", OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student student = ReadStudent(reader);
                students.Add(student);
            }
            reader.Close();
            CloseConnection();

            return students;
        }

        public Student ReadStudent(SqlDataReader reader)
        {
            Student student = new Student()
            {
                StudentId = (int)reader["studentId"],
                FirstName = reader["firstName"].ToString(),
                LastName = reader["lastName"].ToString(),
                PhoneNumber = reader["phoneNumber"].ToString(),
                Class = reader["class"].ToString(),
                Vouchers = (int)reader["vouchers"],
                RoomId = (int)reader["roomId"]
            };

            return student;
        }

        public void UpdateStudent(Student student)
        {
            string query = @"
UPDATE [students]
SET
    firstName = @FirstName,
    lastName = @LastName,
    phonenumber = @Phonenumber,
    class = @Class,
    vouchers = @Vouchers,
    roomId = @RoomId
WHERE studentId = @StudentId";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                command.Parameters.AddWithValue("@Class", student.Class);
                command.Parameters.AddWithValue("@Vouchers", student.Vouchers);
                command.Parameters.AddWithValue("@RoomId", student.RoomId);
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public Student CreateStudent(Student student)
        {
            string query = @"
INSERT INTO students (firstName, lastName, phoneNumber, class, vouchers, roomId)
VALUES (@FirstName, @LastName, @PhoneNumber, @Class, @Vouchers, @RoomId);
SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                command.Parameters.AddWithValue("@Class", student.Class);
                command.Parameters.AddWithValue("@Vouchers", student.Vouchers);
                command.Parameters.AddWithValue("@RoomId", student.RoomId); 
                command.ExecuteNonQuery();

                int id = Convert.ToInt32(command.ExecuteScalar());
                student.StudentId = id;
            }
            CloseConnection();
            return student;
        }

        public void DeleteStudent(Student student)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Students WHERE StudentId = @Id", OpenConnection()))
            {
                command.Parameters.AddWithValue("@Id", student.StudentId);
                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}

   
