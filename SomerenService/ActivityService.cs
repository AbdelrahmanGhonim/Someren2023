using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivitiesDao activitiesdb;
        public ActivityService()
        {
            activitiesdb = new ActivitiesDao(); 
        }
        public List<Activities> GetActivities()
        {
            List<Activities> activities=activitiesdb.GetAllActivities();
            return activities;
        }
        public void AddActivity(Activities activities)
        {
            activitiesdb.AddActivity(activities);
        }
        public void UpdateActivity(Activities activities)
        {
            activitiesdb.UpdateActivity(activities);
        }
        public void RemoveActivity(Activities activities)
        {
            activitiesdb.RemoveActivity(activities);
        }
    }
}
