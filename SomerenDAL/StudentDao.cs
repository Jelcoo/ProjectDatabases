using System.Collections.Generic;
using System.Data.SqlClient;
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

        private Student ReadStudent(SqlDataReader reader)
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
    }
}
