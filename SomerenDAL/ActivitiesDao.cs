using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class ActivitiesDao : BaseDao
    {
       public List<Activities> GetAllActivities()
        {
            string query = "SELECT ID,Description,StartDateTime,EndDateTime FROM activties";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
       }

        public void AddActivity(Activities activities)
        {
            string query = ("INSERT INTO activties (ID, Description,StartDateTime,EndDateTime) VALUES (@ID, @Description,@StartDateTime,@EndDateTime);");
            SqlParameter[] sqlParameters = {
            new SqlParameter("@ID", activities.ID),
            new SqlParameter("@Description", activities.Description),
            new SqlParameter("@StartDateTime", activities.StartDateTime),
            new SqlParameter("@EndDateTime", activities.EndDateTime),

            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateActivity(Activities activities)
        {

            string query = "UPDATE [activties] SET Description=@Description,StartDateTime=@StartDateTime,EndDateTime=@EndDateTime WHERE ID=@ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ID",activities.ID ),
                new SqlParameter("@Description",activities.Description ),
                new SqlParameter("@StartDateTime", activities.StartDateTime),
                new SqlParameter("@EndDateTime",activities.EndDateTime),
            };
            ExecuteEditQuery(query, sqlParameters);           
        }

        public void RemoveActivity(Activities activities)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(
                "DELETE FROM activties WHERE ID = @ID", conn);

            command.Parameters.AddWithValue("@ID", activities.ID);

            int nrOfRowsAffected = command.ExecuteNonQuery(); // checking if anything was added
            conn.Close();

           // if (nrOfRowsAffected == 0)
             //   throw new Exception("Drink was not removed!");
        }

        private List<Activities> ReadTables(DataTable dataTable) // data from database into class
        {
            List<Activities> activities = new List<Activities>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activities activity = new Activities()
                {
                    ID = (int)dr["ID"],
                    Description = (string)dr["Description"],
                    StartDateTime = (DateTime)dr["StartDateTime"],
                    EndDateTime = (DateTime)dr["EndDateTime"],
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
