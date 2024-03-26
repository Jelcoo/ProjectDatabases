using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class SupervisorService
    {
        private SupervisorDao supervisorDao;

        public SupervisorService()
        {
            supervisorDao = new SupervisorDao();
        }

        // Method to get all supervisors
        public List<Supervisor> GetSupervisors()
        {
            return supervisorDao.GetAll();
        }

        // Method to get non-participating supervisors
        public List<Supervisor> GetNonParticipatingSupervisors(Activity activity = null)
        {
            return supervisorDao.GetNonParticipatingSupervisors(activity);
        }
        // Method to get non-participating supervisors
        public List<Supervisor> GetParticipatingSupervisors(Activity activity = null)
        {
            return supervisorDao.GetParticipatingSupervisors(activity);
        }

        // Method to assign a supervisor to a specific activity
        public void AssignSupervisor(int activityId, int teacherId)
        {
            supervisorDao.AssignSupervisor(activityId, teacherId);
        }

        // Method to unassign a supervisor from an activity
        public void UnassignSupervisor(int activityId, int teacherId)
        {
            supervisorDao.UnassignSupervisor(activityId, teacherId);
        }
    }
}
