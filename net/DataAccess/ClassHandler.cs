using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.DataAccess
{
    class ClassHandler
    {
       
       public void AddClass(int cid1,string cname1,int grade1)
       {
            using (var context = new Context())
            {
                try
                {
                    var classes = new Class { cid = cid1, cname = cname1, grade = grade1 };
                    context.Classes.Add(classes);
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Input is wrong!!!");
                }
            }
       }

        public void GetAllClass()
        {
            using (var context = new Context())
            {
                var cates = context.Classes;
                foreach (var item in cates)
                {
                    Console.WriteLine(item.cid + " " + item.cname + " " + item.grade);
                }
            }
        }

        public void GetClass(int cid)
        {
            using (var context = new Context())
            {
                try
                {
                    string sql = @"select * from Classes where cid = ";
                    string cids = cid.ToString();
                    var cates = context.Classes.SqlQuery(sql + cid);
                    foreach (var item in cates)
                    {
                        Console.WriteLine(item.cid + " " + item.cname + " " + item.grade);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("The ID you entered is wrong!!!");
                }
            }
        }

        public void UpdateClass(int cid,int grade)
        {
            using (var context = new Context())
            {
                try
                {
                    var classes = context.Classes.FirstOrDefault(s => s.cid == cid);
                    classes.grade = grade;
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("The ID you entered is wrong!!!");
                }
            }

        }

        public void DeleteClass(int cid)
        {
            using (var context = new Context())
            {
                try
                {
                    var classes = context.Classes.FirstOrDefault(s => s.cid == cid);
                    context.Classes.Remove(classes);
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
