using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.session_4
{
    internal class Number
    {
        public int x { set; get; } 
        public int y { set; get; }  

        public void ChangeXY()
        {
            x++;
            y++;
        }

        public void PrintXY()
        {
            Console.WriteLine("X=" + x);
            Console.WriteLine("Y=" + y);
        }
    }
}
