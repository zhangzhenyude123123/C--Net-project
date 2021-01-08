using net.Business;
using net.Controller;
using net.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net
{
    class Program
    {

        static void Main(string[] args)
        {

            Dispay dispay = new Dispay();
            while (true)
            {
                dispay.MainMenu();
            }
            using (var context = new Context())
            {
                // 如果数据库不存在，则调用EF内置的API创建数据库
                //if (context.Database.CreateIfNotExists())
                //{
                //    Console.WriteLine("数据库创建成功!");
                //}
                //else
                //{
                //    Console.WriteLine("数据库已存在");
                //}

                //Console.ReadKey();
       

                //var id = Convert.ToInt32(Console.ReadLine());
                //var classes= new Class { cid = id };
                //context.Classes.Add(classes);
                //context.SaveChanges();

                //var query = from b in context.Classes
                //            orderby b.cid
                //            select b;
                //foreach(var item in query)
                //{
                //    Console.WriteLine(item.cid);
                //}
                //var cate = new List<Class>
                //{
                //    new Class{
                //        cid = 1,
                //        cname= "computer-science",
                //        mid=1
                //        //Students = new List<Student>{
                //        //    new Student
                //        //    {
                //        //        ssid = 184957,
                //        //        sname = "zhangzhenyu",
                //        //        ssex = "man"
                //        //    },
                //        //    new Student
                //        //    {
                //        //        ssid = 184958,
                //        //        sname = "zhangsan",
                //        //        ssex = "man"
                //        //    }
                //        //}
                //    }
                //};

                //context.Classes.AddRange(cate);
                //context.SaveChanges();
                //Console.WriteLine("is ok");

                //var cate = new List<Student>{
                //    new Student
                //    {
                //        ssid = 184957,
                //        sname = "zhangzhenyu",
                //        ssex = "man"
                //    },
                //    new Student
                //    {
                //        ssid = 184958,
                //        sname = "zhangsan",
                //        ssex = "man"
                //    }
                // };
                //context.Students.AddRange(cate);
                //context.SaveChanges();

                //查询的一种方式
                //var cates = context.Classes;
                //foreach(var item in cates)
                //{
                //    Console.WriteLine(item.cname);
                //}
                //查询的另一种方式
                //Console.WriteLine();
                //var cates = context.Students.FirstOrDefault(x => x.ssex =="man");
                //Console.WriteLine(cates.ssid + cates.sname + cates.ssex);

                //已经成功的测试
                //Console.WriteLine();
                //string str = @"select * from Students";
                //var cates = context.Students.SqlQuery(str);
                //foreach (var item in cates)
                //{
                //    Console.WriteLine(item.ssid + item.sname + item.ssex);
                //}
 

            }
        }
    }
}
