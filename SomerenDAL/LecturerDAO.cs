using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LecturerDAO : BaseDao
    {
        public List<Teacher> GetAllTeachers() // getting data from database 
        {
            string query = "SELECT id, name, lecturerNumber, dataOfBirth FROM Lecturers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> ReadTables(DataTable dataTable) // data from database into class
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Id = (int)dr["id"],
                    Name = dr["Name"].ToString(),
                    Number = (int)dr["lecturerNumber"],
                    DateOfBirth = (DateTime)dr["DataOfBirth"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
