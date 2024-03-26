using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAll()
        {
            string query = "SELECT activityId, name, location, startOfActivity, endOfActivity FROM [activities] WHERE deleted=0";
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

        public List<Student> GetActivityAssignedStudents(Activity activity)
        {
            string query = @"
SELECT studentId, firstName, lastName, phoneNumber, class, vouchers, roomId FROM students
WHERE studentId IN (
	SELECT studentId FROM activityparticipants
	JOIN activities ON activities.activityId=activityparticipants.activityId
	WHERE activities.activityId=@ActivityId
    AND activities.deleted=0
)
AND deleted=0;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@ActivityId", activity.ActivityId);

            StudentDao studentdb = new StudentDao();

            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student student = studentdb.ReadStudent(reader);
                students.Add(student);
            }

            reader.Close();
            CloseConnection();

            return students;
        }

        public List<Student> GetActivityUnassignedStudents(Activity activity)
        {
            string query = @"
SELECT studentId, firstName, lastName, phoneNumber, class, vouchers, roomId FROM students
WHERE studentId NOT IN (
	SELECT studentId FROM activityparticipants
	JOIN activities ON activities.activityId=activityparticipants.activityId
	WHERE activities.activityId=@ActivityId
    AND activities.deleted=0
)
AND deleted=0;";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@ActivityId", activity.ActivityId);

            StudentDao studentdb = new StudentDao();

            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student student = studentdb.ReadStudent(reader);
                students.Add(student);
            }

            reader.Close();
            CloseConnection();

            return students;
        }

        public void AssignStudent(Student student, Activity activity)
        {
            string query = @"INSERT INTO activityparticipants (studentId, activityId) VALUES (@StudentId, @ActivityId)";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@ActivityId", activity.ActivityId);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void UnassignStudent(Student student, Activity activity)
        {
            string query = @"DELETE FROM activityparticipants WHERE studentId=@StudentId AND activityId=@ActivityId;";

            using (SqlCommand command = new SqlCommand(query, OpenConnection()))
            {
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@ActivityId", activity.ActivityId);
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
    }
}