using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_8
{
    internal abstract class Khachhang
    {
        
         public int id { get; set; }
         public string hoten { get; set; }
         public string date { get; set; }
         public int quantity { get; set; }


         public Khachhang(int Id, string Hoten, string Date, int Quantity)
            {
                id = Id;
                hoten = Hoten;
                date = Date;
                quantity = Quantity;
            }

        
    }
}
