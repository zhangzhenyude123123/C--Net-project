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
        Adds adds;
        Deletes deletes;
        Updates updates;
        public void MainMenu()
        {
            Console.WriteLine("Select number to function:\n 1.add 2.update 3.delete:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
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
            }

        }
        public void AddMenu()
        {
            adds = new Adds();
            Console.WriteLine("Select number to function:\n 1.add student " +
                "2.add class 3.add student to class:");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    int sid = Console.Read();//这里有问题
                    string sname = Console.ReadLine();
                    string ssex = Console.ReadLine();
                    adds.addstudent(sid, sname, ssex);
                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }
        public void UpdateMenu()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }
        public void DeleteMenu()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }
    }
}
