using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapPhanso
{
    internal class Phanso
    {
        public int tuso { get; set; }
        public int maso { get; set; }   
        
        public void NhapPhanso()
        {
            Console.WriteLine("Tu so = ");
            this.tuso = int .Parse(Console.ReadLine());
            Console.WriteLine("Mau so = ");
            do
                this.maso = int.Parse(Console.ReadLine());
            while (this.maso == 0);
        }

        public void InPhanso()
        {
            Console.WriteLine("Phan so = " + tuso + "/" + maso);
        }

        public Phanso RutgonPhanso()
        {
            int ts = tuso;
            int ms = maso;
            while (tuso != maso) ;

            

        }
    }
}
