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
                try
                {
                    string sql = @"select * from Students where ssid = " + ssid1.ToString();
                    string ssid = ssid1.ToString();
                    var cates = context.Students.SqlQuery(sql);
                    foreach (var item in cates)
                    {
                        Console.WriteLine(item.ssid + " " + item.sname + " " + item.ssex + " " + item.cid);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("The ID you entered is wrong!!!");
                }
            }
        }
        public void GetClassAllStudents(int cid)
        {
            using (var context = new Context())
            {
                try
                {
                    string sql = @"select * from Students where cid = ";
                    string cids = cid.ToString();
                    var cates = context.Students.SqlQuery(sql + cid);
                    foreach (var item in cates)
                    {
                        Console.WriteLine(item.ssid + " " + item.sname + " " + item.ssex + " " + item.cid);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("The ID you entered is wrong!!!");
                }

            }
        }

        public void UpdateStudent(int sid,string name)
        {
            using (var context = new Context())
            {
                try
                {
                    var students = context.Students.FirstOrDefault(s => s.ssid == sid);
                    students.sname = name;
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("The ID you entered is wrong!!!");
                }
            }

        }

        public void DeleteStudent(int sid)
        {
            using (var context = new Context())
            {
                try
                {
                    var students = context.Students.FirstOrDefault(s => s.ssid == sid);
                    context.Students.Remove(students);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("The ID you entered is wrong!!!");
                }
            }
        }
    }
}
