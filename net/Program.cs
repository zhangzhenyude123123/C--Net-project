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
                if(dispay.exitcode == 1)
                {
                    break;
                }
            }
            
        }
    }
}
