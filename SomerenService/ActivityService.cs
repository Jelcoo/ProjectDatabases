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

        public List<Activity> GetActivities()
        {
            List<Activity> activities = activitydb.GetAll();
            return activities;
        }

        public List<Student> GetActivityAssignedStudents(Activity activity)
        {
            List<Student> students = activitydb.GetActivityAssignedStudents(activity);
            return students;
        }

        public List<Student> GetActivityUnassignedStudents(Activity activity)
        {
            List<Student> students = activitydb.GetActivityUnassignedStudents(activity);
            return students;
        }

        public void AssignStudent(Student student, Activity activity)
        {
            activitydb.AssignStudent(student, activity);
        }

        public void UnassignStudent(Student student, Activity activity)
        {
            activitydb.UnassignStudent(student, activity);
        }
    }
}