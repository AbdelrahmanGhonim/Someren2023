using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class TeacherService
    {
        private LecturerDAO lecturerdb;
        private SupervisorDAO supervisordb;

        public TeacherService()
        {
            lecturerdb = new LecturerDAO();
            supervisordb = new SupervisorDAO();
        }

        public List<Teacher> GetLecturers()
        {
            List<Teacher> teachers = lecturerdb.GetAllTeachers();
            return teachers;
        }

        public List<Supervisor> GetSupervisors()
        {
            List<Supervisor> supervisors = supervisordb.GetAllSupervisors();
            return supervisors;
        }

        public List<Supervisor> GetSupervisorsById(int id)
        {
            List<Supervisor> supervisorsById = supervisordb.getSupervisorsById(id);

            return supervisorsById;
        }

        public void AddSupervisor(Supervisor supervisor)
        {
            supervisordb.AddSupervisorToActivity(supervisor);
        }
        public void RemoveSupervisor(Supervisor supervisor)
        {
            supervisordb.RemoveSupervisorFromActivity(supervisor);
        }
    }
}