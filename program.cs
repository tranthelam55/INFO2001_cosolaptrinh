using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai28
{
    class Program
    {
        static void Main(string[] args)
        {
            class_demo ob = new class_demo();
            ob.Show();
            ushort n;
            Console.WriteLine("Nhập n:");
            n = ob.nhapsonguyen2bytekhongdau();
            Console.WriteLine("n=" + n.ToString());
        }
    }

}
