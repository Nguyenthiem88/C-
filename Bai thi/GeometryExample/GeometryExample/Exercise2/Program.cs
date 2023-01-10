using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Exercise2
{
    class Program
    {
        static void Main1(string[] args)
        {
            Lion l = new Lion(12.5, "Lion");
            l.Show();
            l.SetMe(10, "Li");
            l.Show();
            Tiger t = new Tiger(55, "tiger");
            t.Show();
            t.SetMe(33, "ti");
            t.Show();
        }
    }
}
