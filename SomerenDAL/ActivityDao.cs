using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;
using System;

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