using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()  // getting data from database 
        {
            string query = "SELECT id,name,studentNumber,dataOfBirth FROM [Students] ORDER BY name ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable) // data from database into class
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Id = (int)dr["id"],
                    Name = dr["name"].ToString(),
                    Number = (int)dr["studentNumber"],
                    BirthDate = (DateTime)dr["dataOfBirth"],
                };
                students.Add(student);
            }
            return students;
        }
    }
}