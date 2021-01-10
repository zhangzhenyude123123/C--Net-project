using System;
using net.Business;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.Controller
{
    class Dispay
    {
        private Adds adds;
        private Deletes deletes;
        private Updates updates;
        private Selects selects;
        public int exitcode { get; set; }

        public Dispay()
        {
            exitcode = 0;
        }

        public void MainMenu()
        {
            Console.WriteLine("# MainMenu #");
            Console.WriteLine("Select number to function:\n 1.AddMenu 2.UpdateMenu 3.DeleteMenu 4.Select 5.Exit:");
            int num = int.Parse(Console.ReadLine());
            switch (num) {
                case 1:
                    AddMenu();
                    break;
                case 2:
                    UpdateMenu();
                    break;
                case 3:
                    DeleteMenu();
                    break;
                case 4:
                    Selete();
                    break;
                case 5:
                    exitcode = 1;
                    break;
                default:
                    break;
            }

        }

        public void AddMenu()
        {
            adds = new Adds();
            Console.WriteLine("# AddMenu #");
            Console.WriteLine("Select number to function:\n 1.Add student 2.Add class: " +
                "\n"+ "  OR Other Number to MainMenu");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Please enter student id name sex classid:");
                    int sid = int.Parse(Console.ReadLine());
                    string sname = Console.ReadLine();
                    string ssex = Console.ReadLine();
                    int cid1 = int.Parse(Console.ReadLine());
                    adds.Addstudent(sid, sname, ssex, cid1);
                    break;
                case 2:
                    Console.WriteLine("Please enter class id name grade:");
                    int cid2 = int.Parse(Console.ReadLine());
                    string cname = Console.ReadLine();
                    int grade = int.Parse(Console.ReadLine());
                    adds.Addclass(cid2, cname,grade);
                    break;
                default:
                    break;
            }
        }

        public void UpdateMenu()
        {
            updates = new Updates();
            Console.WriteLine("# UpdateMenu #");
            Console.WriteLine("Select number to function:\n 1.update student 2.update class:" +
                "\n" + "  OR Other Number to MainMenu");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Please enter the student's id and the new name:");
                    int sid = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    updates.UpdateStudent(sid, name);
                    break;
                case 2:
                    Console.WriteLine("Please enter the class's id and the new grade:");
                    int cid = int.Parse(Console.ReadLine());
                    int grade = int.Parse(Console.ReadLine());
                    updates.UpdateClass(cid, grade);
                    break;
                default:
                    break;
            }
        }

        public void DeleteMenu()
        {
            deletes = new Deletes();
            Console.WriteLine("# DeleteMenu #");
            Console.WriteLine("Select number to function:\n 1.delete student " +
                "2.delete class : " +
                "\n" + "  OR Other Number to MainMenu");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Please enter the deleted student's id:");
                    int sid = int.Parse(Console.ReadLine());
                    deletes.DeleteStudent(sid);
                    break;
                case 2:
                    Console.WriteLine("Please enter the deleted class's id:");
                    int cid = int.Parse(Console.ReadLine());
                    deletes.DeleteClass(cid);
                    break;
                default:
                    break;
            }
        }

        public void Selete()
        {
            selects = new Selects();
            Console.WriteLine("# SeleteMenu #");
            Console.WriteLine("Select number to function:\n 1.Select one student 2.Select All student " +
                "3.Select one class'students 4.Select one class 5.Select All class: " +
                "\n" + "  OR Other Number to MainMenu");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Please enter the student's id:");
                    int ssid = int.Parse(Console.ReadLine());
                    selects.GetStudent(ssid);
                    break;
                case 2:
                    selects.GetALLStudent();
                    break;
                case 3:
                    Console.WriteLine("Please enter the class's id:");
                    int cid1 = int.Parse(Console.ReadLine());
                    selects.GetClassAllStudents(cid1);
                    break;
                case 4:
                    Console.WriteLine("Please enter the class's id:");
                    int cid2 = int.Parse(Console.ReadLine());
                    selects.GetClass(cid2);
                    break;
                case 5:
                    selects.GetAllClass();
                    break;
                default:
                    break;
            }
        }

    }
}
