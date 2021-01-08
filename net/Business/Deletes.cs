using net.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.Business
{
    class Deletes
    {
        private StudentHandler studentHandler;
        private ClassHandler classHandler;

        public void DeleteStudent(int sid)
        {
            studentHandler = new StudentHandler();
            studentHandler.DeleteStudent(sid);
        }
        public void DeleteClass(int cid)
        {
            classHandler = new ClassHandler();
            classHandler.DeleteClass(cid);
        }
    }
}
