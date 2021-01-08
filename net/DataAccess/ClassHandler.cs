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
                var classes = new Class { cid = cid1, cname = cname1,grade = grade1 };
                context.Classes.Add(classes);
                context.SaveChanges();
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
                string sql = @"select * from Class where cid = ";
                string cids = cid.ToString();
                var cates = context.Classes.SqlQuery(sql + cid);
                foreach (var item in cates)
                {
                    Console.WriteLine(item.cid + " " + item.cname + " " + item.grade);
                }
            }
        }

        public void UpdateClass(int cid,int grade)
        {
            using (var context = new Context())
            {
                var classes = context.Classes.FirstOrDefault(s => s.cid == cid);
                classes.grade = grade;
                context.SaveChanges();
            }

        }

        public void DeleteClass(int cid)
        {
            using (var context = new Context())
            {
                var classes = context.Classes.FirstOrDefault(s => s.cid == cid);
                context.Classes.Remove(classes);
                context.SaveChanges();
            }
        }

        //public bool CheckClass(int cid)
        //{
        //    using (var context = new Context())
        //    {
                

        //        return false;
        //    }
        //}
    }
}
