using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace th_ham_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //bai3();
            
            

        }
        
        static void nhap2so(string info, out int x, out int y) 
        {
            
            Console.Write(info);
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
        }
        static void TinhToanNhieuPhep(int x, int y, out int tong, out int hieu, out int tich, out double thuong)
        {
            tong = x + y;   
            hieu = x - y;
            tich = x * y;
            thuong = (double)x / y;

        }
        static void bai3()
        {
            int x, y;
            nhap2so("bat dau nhap x y:", out x, out y);

            int tong, hieu, tich;
            double thuong;
            TinhToanNhieuPhep(x, y, out tong, out hieu, out tich, out thuong);
            Console.WriteLine($"tong {x} va {y}: " + tong);
            Console.WriteLine($"hieu {x} va {y}: " + hieu);
            Console.WriteLine($"tich {x} va {y}: " + tich);
            Console.WriteLine($"thuong {x} va {y}: " + thuong);

        }
       

    }
}

