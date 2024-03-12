﻿using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAll(string sortBy = null)
        {
            string query = "SELECT studentId, firstName, lastName, phoneNumber, class, vouchers, roomId FROM [students]";

            if (sortBy != null)
            {
                query += $" ORDER BY {sortBy}";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

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

        public Student GetById(int studentId)
        {
            SqlCommand command = new SqlCommand("SELECT studentId, firstName, lastName, phoneNumber, class, vouchers, roomId FROM [students] WHERE studentId=@Id", OpenConnection());
            command.Parameters.AddWithValue("@Id", studentId);

            SqlDataReader reader = command.ExecuteReader();
            Student student = ReadStudent(reader);
            reader.Close();
            CloseConnection();

            return student;
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
    }
}
