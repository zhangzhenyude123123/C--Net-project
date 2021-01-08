using net.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.Business
{
    class Updates
    {
        public void UpdateClass(int cid,int grade)
        {
            var classes = new ClassHandler();
            classes.UpdateClass(cid, grade);

        }

        public void UpdateStudent(int sid,string name)
        {
            var students = new StudentHandler();
            students.UpdateStudent(sid, name);
        }
    }
}
