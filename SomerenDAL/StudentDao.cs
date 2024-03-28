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
            SqlCommand command = new SqlCommand("SELECT studentId, firstName, lastName, phoneNumber, class, vouchers, roomId FROM [students] WHERE deleted=0 ORDER BY lastName DESC", OpenConnection());

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
            Student student = new Student(
                studentId: (int)reader["studentId"],
                firstName: (string)reader["firstName"],
                lastName: (string)reader["lastName"],
                phoneNumber: (long)reader["phoneNumber"],
                @class: (string)reader["class"],
                vouchers: (int)reader["vouchers"],
                roomId: (int)reader["roomId"]
            );

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

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
            command.Parameters.AddWithValue("@Class", student.Class);
            command.Parameters.AddWithValue("@Vouchers", student.Vouchers);
            command.Parameters.AddWithValue("@RoomId", student.RoomId);
            command.Parameters.AddWithValue("@StudentId", student.StudentId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public int CreateStudent(Student student)
        {
            string query = @"
INSERT INTO students (firstName, lastName, phoneNumber, class, vouchers, roomId)
VALUES (@FirstName, @LastName, @PhoneNumber, @Class, @Vouchers, @RoomId);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
            command.Parameters.AddWithValue("@Class", student.Class);
            command.Parameters.AddWithValue("@Vouchers", student.Vouchers);
            command.Parameters.AddWithValue("@RoomId", student.RoomId);

            int id = Convert.ToInt32(command.ExecuteScalar());

            CloseConnection();
            return id;
        }

        public void DeleteStudent(Student student)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Students WHERE StudentId = @Id", OpenConnection());
            command.Parameters.AddWithValue("@Id", student.StudentId);

            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}

   
