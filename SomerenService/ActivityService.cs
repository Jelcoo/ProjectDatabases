using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetActivities(string sortBy = null)
        {
            List<Activity> activities = activitydb.GetAll(sortBy);
            return activities;
        }
    }
}