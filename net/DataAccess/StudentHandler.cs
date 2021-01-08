using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.DataAccess
{
    class StudentHandler
    {
        public void AddStudent(int sid1, string sname1,string ssex1,int cid1)
        {
            using (var context = new Context())
            {
                var student = new Student { ssid = sid1, sname = sname1,ssex = ssex1,cid = cid1 };
                try
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You must add this class frist");
                }
            }
        }
        //public void AddStudentToClass(int sid1,int cid1)
        //{
        //    using (var context = new Context())
        //    {
        //        //string str = @"update Students set cid =" + 
        //        //    cid1.ToString() + @"where sid = "+sid1.ToString();
        //        //var cates = context.Students.ExecuteSqlCommand();
        //        var student = context.Students.FirstOrDefault(x => x.ssid == sid1);
        //        student.cid = cid1;
        //        context.SaveChanges();
        //    }
        //}

        public void GetALLStudent()
        {
            using (var context = new Context())
            {
                var cates = context.Students;
                foreach (var item in cates)
                {
                    Console.WriteLine(item.ssid+" "+item.sname+" "+item.ssex+" "+item.cid );
                }
            }
        }
        public void GetStudent(int ssid1)
        {
            using (var context = new Context())
            {
                string sql = @"select * from Students where ssid = " + ssid1.ToString();
                string ssid = ssid1.ToString();
                Console.WriteLine("enter's ssid" + ssid);
                var cates = context.Students.SqlQuery(sql);
                foreach (var item in cates)
                {
                    Console.WriteLine(item.ssid + " " + item.sname + " " + item.ssex + " " + item.cid);
                }
            }
        }
        public void GetClassAllStudents(int cid)
        {
            using (var context = new Context())
            {
                string sql = @"select * from Students where cid = ";
                string cids = cid.ToString();
                var cates = context.Students.SqlQuery(sql + cid);
                foreach (var item in cates)
                {
                    Console.WriteLine(item.ssid + " " + item.sname + " " + item.ssex + " " + item.cid);
                }
            }
        }

        public void UpdateStudent(int sid,string name)
        {
            using (var context = new Context())
            {
                var students = context.Students.FirstOrDefault(s => s.ssid == sid);
                students.sname = name; 
                context.SaveChanges();
            }

        }

        public void DeleteStudent(int sid)
        {
            using (var context = new Context())
            {
                //delete语句
                //var tran = context.Database.BeginTransaction();
                //try
                //{
                //    var student = context.Students.FirstOrDefault(s => s.ssex == "man");
                //    context.Students.Remove(student);    //删除
                //    context.SaveChanges();
                //    tran.Commit();  //必须调用Commit()，不然数据不会保存
                //}
                //catch (Exception ex)
                //{
                //    tran.Rollback();    //出错就回滚
                //}

                //这个比较特殊
                //var opsManagers = context.Database.SqlQuery<>
                var students = context.Students.FirstOrDefault(s => s.ssid == sid);
                context.Students.Remove(students);
                context.SaveChanges();
            }
        }
    }
}
