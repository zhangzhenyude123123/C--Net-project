using System;
using System.Collections.Generic;
using net.DataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.Business
{
    class Selects
    {
        public void GetStudent(int ssid)
        {
            var student = new StudentHandler();
            student.GetStudent(ssid);
        }

        public void GetClassAllStudents(int cid)
        {
            var students = new StudentHandler();
            students.GetClassAllStudents(cid);
        }

        public void GetALLStudent()
        {
            var students = new StudentHandler();
            students.GetALLStudent();
        }

        public void GetClass(int cid)
        {
            var classes = new ClassHandler();
            classes.GetClass(cid);
        }

        public void GetAllClass()
        {
            var classes = new ClassHandler();
            classes.GetAllClass();
        }
    }
}
