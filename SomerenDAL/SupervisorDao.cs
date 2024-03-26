﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using SomerenModel;
using Activity = SomerenModel.Activity;

namespace SomerenDAL
{
    public class SupervisorDao : BaseDao
    {
        // Method to get all supervisors
        public List<Supervisor> GetAll()
        {
            SqlCommand command = new SqlCommand("SELECT a.activityId, a.name AS activityName, t.teacherId, t.firstName, t.lastName FROM activities a JOIN activitysupervisors asv ON a.activityId = asv.activityId JOIN teachers t ON asv.teacherId = t.teacherId", OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Supervisor> supervisors = new List<Supervisor>();

            while (reader.Read())
            {
                Supervisor supervisor = ReadSupervisor(reader);
                supervisors.Add(supervisor);
            }
            reader.Close();
            CloseConnection();

            return supervisors;
        }

        // Method to read a supervisor from the SqlDataReader
        public Supervisor ReadSupervisor(SqlDataReader reader)
        {
            Supervisor supervisor = new Supervisor()
            {
                ActivityId = (int)reader["activityId"],
                ActivityName = reader["activityName"].ToString(),
                TeacherId = (int)reader["teacherId"],
                FirstName = reader["firstName"].ToString(),
                LastName = reader["lastName"].ToString()
            };

            return supervisor;
        }

        // Method to assign a supervisor to a specific activity
        public void AssignSupervisor(int activityId, int teacherId)
        {
            SqlCommand command = new SqlCommand("INSERT INTO activitysupervisors (activityId, teacherId) VALUES (@activityId, @teacherId)", OpenConnection());
            command.Parameters.AddWithValue("@activityId", activityId);
            command.Parameters.AddWithValue("@teacherId", teacherId);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        // Method to unassign a supervisor from an activity
        public void UnassignSupervisor(int activityId, int teacherId)
        {
            SqlCommand command = new SqlCommand("DELETE FROM activitysupervisors WHERE activityId = @activityId AND teacherId = @teacherId", OpenConnection());
            command.Parameters.AddWithValue("@activityId", activityId);
            command.Parameters.AddWithValue("@teacherId", teacherId);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public List<Supervisor> GetParticipatingSupervisors(Activity activity = null)
        {
            string sqlQuery;
            if (activity != null)
            {
                // Get participating supervisors for a specific activity
                sqlQuery = "SELECT t.teacherId, t.firstName, t.lastName FROM teachers t JOIN activitysupervisors asv ON t.teacherId = asv.teacherId WHERE asv.activityId = @activityId";
            }
            else
            {
                // Get participating supervisors for all activities
                sqlQuery = "SELECT DISTINCT t.teacherId, t.firstName, t.lastName FROM teachers t JOIN activitysupervisors asv ON t.teacherId = asv.teacherId";
            }

            SqlCommand command = new SqlCommand(sqlQuery, OpenConnection());
            if (activity != null)
            {
                command.Parameters.AddWithValue("@activityId", activity.ActivityId);
            }

            SqlDataReader reader = command.ExecuteReader();
            List<Supervisor> participatingSupervisors = new List<Supervisor>();

            while (reader.Read())
            {
                Supervisor supervisor = new Supervisor()
                {
                    TeacherId = (int)reader["teacherId"],
                    FirstName = reader["firstName"].ToString(),
                    LastName = reader["lastName"].ToString()
                };
                participatingSupervisors.Add(supervisor);
            }
            reader.Close();
            CloseConnection();

            return participatingSupervisors;
        }


        public List<Supervisor> GetNonParticipatingSupervisors(Activity activity = null)
        {
            string sqlQuery;
            if (activity != null)
            {
                // Get non-participating supervisors for a specific activity
                sqlQuery = "SELECT t.teacherId, t.firstName, t.lastName FROM teachers t WHERE NOT EXISTS (SELECT 1 FROM activitysupervisors asv WHERE asv.teacherId = t.teacherId AND asv.activityId = @activityId)";
            }
            else
            {
                // Get non-participating supervisors for all activities
                sqlQuery = "SELECT t.teacherId, t.firstName, t.lastName FROM teachers t WHERE NOT EXISTS (SELECT 1 FROM activitysupervisors asv WHERE asv.teacherId = t.teacherId)";
            }

            SqlCommand command = new SqlCommand(sqlQuery, OpenConnection());
            if (activity != null)
            {
                command.Parameters.AddWithValue("@activityId", activity.ActivityId);
            }

            SqlDataReader reader = command.ExecuteReader();
            List<Supervisor> nonParticipatingSupervisors = new List<Supervisor>();

            while (reader.Read())
            {
                Supervisor supervisor = new Supervisor()
                {
                    TeacherId = (int)reader["teacherId"],
                    FirstName = reader["firstName"].ToString(),
                    LastName = reader["lastName"].ToString()
                };
                nonParticipatingSupervisors.Add(supervisor);
            }
            reader.Close();
            CloseConnection();

            return nonParticipatingSupervisors;
        }
    }
}
