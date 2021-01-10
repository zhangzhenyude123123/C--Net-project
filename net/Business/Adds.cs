using net.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.Business
{
    class Adds
    {
        private StudentHandler studenthandler;
        private ClassHandler classhandler;
        public void Addstudent(int ssid, string sname, string ssex,int cid)
        {
            studenthandler = new StudentHandler();
            studenthandler.AddStudent(ssid, sname, ssex,cid);
        }

        public void Addclass(int cid, string cname,int grade)
        {
            classhandler = new ClassHandler();
            classhandler.AddClass(cid, cname, grade);
        }
       
    }
}
