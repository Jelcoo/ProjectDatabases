﻿using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;
using System;
using System.Globalization;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAll()
        {
            SqlCommand command = new SqlCommand("SELECT teacherId, firstName, lastName, phoneNumber, dateOfBirth, roomId FROM [teachers] WHERE deleted=0", OpenConnection());

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

        public Teacher ReadTeacher(SqlDataReader reader)
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

        public void UpdateTeacher(Teacher teacher)
        {
            string query = @"
  UPDATE [teachers]
SET
    firstName = @FirstName,
    lastname = @LastName,
    phoneNumber = @PhoneNumber,
    dateOfBirth = @DateOfBirth,
    roomId = @RoomId
WHERE teacherId = @TeacherId";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
            command.Parameters.AddWithValue("@LastName", teacher.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", teacher.PhoneNumber);
            command.Parameters.AddWithValue("@DateOfBirth", teacher.DateOfBirth);
            command.Parameters.AddWithValue("@RoomId", teacher.RoomId);
            command.Parameters.AddWithValue("@TeacherId", teacher.TeacherId);

            command.ExecuteNonQuery();

            CloseConnection();
        }

        public int CreateTeacher(Teacher teacher)
        {
            string query = @"
INSERT INTO teachers (firstName, lastname, phoneNumber, dateOfBirth, roomId)
VALUES (@FirstName, @LastName, @PhoneNumber, @DateOfBirth, @RoomId);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@FirstName", teacher.FirstName);
            command.Parameters.AddWithValue("@LastName", teacher.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", teacher.PhoneNumber);
            command.Parameters.AddWithValue("@DateOfBirth", teacher.DateOfBirth);
            command.Parameters.AddWithValue("@RoomId", teacher.RoomId);

            int id = Convert.ToInt32(command.ExecuteScalar());

            CloseConnection();
            return id;
        }

        public void DeleteTeacher(Teacher teacher)
        {
            SqlCommand command = new SqlCommand("UPDATE teachers SET deleted=1 WHERE teacherId = @Id", OpenConnection());
            command.Parameters.AddWithValue("@Id", teacher.TeacherId);

            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
