using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_8
{
    internal class KhachhangNN : Khachhang 
    {
        public string quocTich;
        public KhachhangNN(int Id, string Hoten, string Date, int Quantity, string quocTich) : base(Id, Hoten, Date, Quantity)
        {
            this.quocTich = quocTich;
        }
        public int ThanhTien()
        {
            return quantity * 2000;
        }
    }
}
