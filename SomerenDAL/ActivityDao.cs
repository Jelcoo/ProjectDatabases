using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;
using System;
using System.Collections;
using System.Net;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAll(string sortBy = null)
        {
            string query = "SELECT activityId, name, location, startOfActivity, endOfActivity FROM [activities]";

            if (sortBy != null)
            {
                query += $" ORDER BY {sortBy}";
            }
            SqlCommand command = new SqlCommand(query, OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Activity> activities = new List<Activity>();

            while (reader.Read())
            {
                Activity activity = ReadActivity(reader);
                activities.Add(activity);
            }
            reader.Close();
            CloseConnection();

            return activities;
        }

        public List<Student> GetAllParticipants(int activityId)
        {
            SqlCommand command = new SqlCommand("SELECT activityId, studentId FROM [activityparticipants] WHERE activityId=@Id", OpenConnection());
            command.Parameters.AddWithValue("@Id", activityId);

            SqlDataReader reader = command.ExecuteReader();
            List<Student> participants = new List<Student>();
            StudentDao studentdb = new StudentDao();

            while (reader.Read())
            {
                Student student = studentdb.GetById((int)reader["studentId"]);
                participants.Add(student);
            }
            reader.Close();
            CloseConnection();

            return participants;
        }

        public List<Teacher> GetAllSupervisors(int activityId)
        {
            SqlCommand command = new SqlCommand("SELECT activityId, teacherId FROM [activitysupervisors] WHERE activityId=@Id", OpenConnection());
            command.Parameters.AddWithValue("@Id", activityId);

            SqlDataReader reader = command.ExecuteReader();
            List<Teacher> supervisors = new List<Teacher>();
            TeacherDao teacherdb = new TeacherDao();

            while (reader.Read())
            {
                Teacher teacher = teacherdb.GetById((int)reader["teacherId"]);
                supervisors.Add(teacher);
            }
            reader.Close();
            CloseConnection();

            return supervisors;
        }

        private Activity ReadActivity(SqlDataReader reader)
        {
            Activity activity = new Activity()
            {
                ActivityId = (int)reader["activityId"],
                Name = reader["name"].ToString(),
                Location = reader["location"].ToString(),
                StartOfActivity = DateTime.Parse(reader["startOfActivity"].ToString()),
                EndOfActivity = DateTime.Parse(reader["endOfActivity"].ToString())
            };

            return activity;
        }
    }
}