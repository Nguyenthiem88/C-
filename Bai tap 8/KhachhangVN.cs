using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_8
{
    internal class KhachhangVN : Khachhang
    {
        public string doiTuong { get; set; }
        public KhachhangVN(int Id, string Hoten, string Date, int Quantity, string DoiTuong) : base(Id, Hoten, Date, Quantity)
        {
            doiTuong = DoiTuong;
        }

        public int Thanhtien()
        {
            if (quantity < 50)
            {
                return quantity * 1000;
            }
            else if (quantity < 100)
            {
                return (quantity - 50) * 1200 + 50 * 1000;
            }
            else if (quantity < 200)
            {
                return (quantity - 100) * 1500 + 50 * 1200 + 50 * 1000;
            }
            else
            {
                return (quantity - 200) * 2000 + 100 * 1500 + 50 * 1200 + 50 * 1000;
            }
        }
    }
}
