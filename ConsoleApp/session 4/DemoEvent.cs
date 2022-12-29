using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.session_4
{
    internal class DemoEvent
    {
        public event StringToVoid Print;
        public event StringToVoid Action;

        public DemoEvent()
        {
            Print += DemoDelegate.SayHello;
            Print += new DemoDelegate().ShowInfo;
        }

        public void Invoke()
        {
            Print("Hello world");
        }
    }
}
