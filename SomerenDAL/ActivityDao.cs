using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT activityId, name, location, startOfActivity, endOfActivity FROM activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["activityId"],
                    Name = dr["name"].ToString(),
                    Location = dr["location"].ToString(),
                    StartOfActivity = DateTime.Parse(dr["startOfActivity"].ToString()),
                    EndOfActivity = DateTime.Parse(dr["endOfActivity"].ToString())
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}