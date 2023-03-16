using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class TeacherService
    {
        private LecturerDAO lecturerdb;

        public TeacherService()
        {
            lecturerdb = new LecturerDAO();
        }

        public List<Teacher> GetLecturers()
        {
            List<Teacher> teachers = lecturerdb.GetAllTeachers();
            return teachers;
        }
    }
}