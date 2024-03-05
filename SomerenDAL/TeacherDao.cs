using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT teacherId, firstName, lastName, phoneNumber, dateOfBirth, roomId FROM [teachers]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    TeacherId = (int)dr["teacherId"],
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    DateOfBirth = DateTime.Parse(dr["dateOfBirth"].ToString()),
                    PhoneNumber = dr["phoneNumber"].ToString(),
                    RoomId = (int)dr["roomId"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
