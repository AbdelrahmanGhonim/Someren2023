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
    public class SupervisorDAO : BaseDao
    {
        public List<Supervisor> GetAllSupervisors() // getting data from database 
        {
            string query = "SELECT Lecturers.id, name, lecturerNumber, dataOfBirth,activties.ID AS activitiesID, activties.Description AS activitiesDescription FROM Lecturers JOIN ActivitySupervisor ON Lecturers.id = ActivitySupervisor.LecturerID JOIN activties ON activties.ID = ActivitySupervisor.ActivityID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Supervisor> fromJoin = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            string query1 = "SELECT id, name, lecturerNumber, dataOfBirth FROM Lecturers ";
            SqlParameter[] sqlParameters1 = new SqlParameter[0];
            List<Supervisor> normal = ReadTablesLecturers(ExecuteSelectQuery(query1, sqlParameters1));
            List<Supervisor> empty = new List<Supervisor>();

            foreach(Supervisor supervisor in fromJoin)
            {
                foreach(Supervisor supervisor2 in normal)
                {
                    if(supervisor.Name == supervisor2.Name && supervisor.Id == supervisor2.Id)
                        empty.Add(supervisor);
                    else
                        empty.Add(supervisor2);
                }
            }

            return empty;
        }
        private List<Supervisor> ReadTables(DataTable dataTable) // data from database into class
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor()
                {
                    Id = (int)dr["id"],
                    Name = dr["Name"].ToString(),
                    Number = (int)dr["lecturerNumber"],
                    DateOfBirth = (DateTime)dr["DataOfBirth"],
                    ActivityId = (int)dr["activitiesID"],
                    ActivityName = dr["activitiesDescription"].ToString(),
                };
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        private List<Supervisor> ReadTablesLecturers(DataTable dataTable) // data from database into class
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor()
                {
                    Id = (int)dr["id"],
                    Name = dr["Name"].ToString(),
                    Number = (int)dr["lecturerNumber"],
                    DateOfBirth = (DateTime)dr["DataOfBirth"],
                    ActivityName = "Null",
                };
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        public List<Supervisor> getSupervisorsById(int id)
        {
            string query = "SELECT Lecturers.id, name, lecturerNumber, dataOfBirth,activties.ID AS activitiesID, activties.Description AS activitiesDescription FROM Lecturers JOIN ActivitySupervisor ON Lecturers.id = ActivitySupervisor.LecturerID JOIN activties ON activties.ID = ActivitySupervisor.ActivityID WHERE activities.ID = " + id;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Supervisor> supervisors = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return supervisors;
        }

        public void AddSupervisorToActivity(Supervisor supervisor)
        {
            string query = ("INSERT INTO ActivitySupervisor(LecturerID, ActivityID) VALUES (@LecturerID, @ActivityID);");
            SqlParameter[] sqlParameters = {
            new SqlParameter("@LecturerID", supervisor.Id),
            new SqlParameter("@ActivityID", supervisor.ActivityId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveSupervisorFromActivity(Supervisor supervisor)
        {
            string query = ("DELETE FROM ActivitySupervisor WHERE LecturerID = @LecturerID");
            SqlParameter[] sqlParameters = {
            new SqlParameter("@LecturerID", supervisor.Id),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
