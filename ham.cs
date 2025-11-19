// Buổi 5: hàm
// Ngày: 30/10/2025
// Họ Tên: Phạm Tuấn Anh
// MSSV: 25dh110011
// Tên flie nộp: Buoi5_25dh110011_Phạm_tuấn_anh.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bai1();
            //bai2();
            //bai3();
            //bai4();
            //bai5();
            //bai6();
        }
        static void bai1()
        {
            Console.Write("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            int b = int.Parse(Console.ReadLine());

            int tong = a + b;  
            Console.WriteLine($"tong {a} va {b}: ");  
            int hieu = a - b;
            Console.WriteLine($"hieu {a} va {b}: " + hieu);
            int tich = a * b;
            Console.WriteLine($"tich {a} va {b}: " + tich);
            double thuong = (double)a / b;
            Console.WriteLine($"thuong {a} va {b}: " + thuong);
        }
        static void bai2()
        {
            Console.Write("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"truoc khi doi a = {a}, b = {b}");
            hamdoi(ref a, ref b); //gọi hàm đổi
            Console.WriteLine($"sau khi doi a = {a}, b = {b}");
        }

        // hàm đổi 2 số
        static void hamdoi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // hàm nhập 2 số
        static void nhap2so(string info, out int x, out int y)
        {
            Console.Write(info);  
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }

        // hàm tính toán nhiều phép
        static void TinhToanNhieuPhep(int x, int y, out int tong, out int hieu, out int tich, out double thuong)
        {
            tong = x + y;
            hieu = x - y;
            tich = x * y;
            thuong = (double)x / y;
        }

        static void bai3()
        {
            int x, y;  //khai báo biến nhận 2 số
            nhap2so("bat dau nhap x y: ", out x, out y);   //gọi hàm nhap2số

            int tong, hieu, tich; //khai báo biến nhận kết quả
            double thuong;   


            TinhToanNhieuPhep(x, y, out tong, out hieu, out tich, out thuong);  //gọi hàm tính toán
            Console.WriteLine($"tong {x} va {y}: " + tong);
            Console.WriteLine($"hieu {x} va {y}: " + hieu);
            Console.WriteLine($"tich {x} va {y}: " + tich);
            Console.WriteLine($"thuong {x} va {y}: " + thuong);
        }

        static void bai4()
        {
            int a, b, c;  //khai báo biến nhận 3 số
            nhap3so("nhap a, b, c: ", out a, out b, out c);   //gọi hàm nhap3số

            //gọi hàm tìm giá trị lớn nhất
            int max = timGiaTriLonNhat(a, b, c);
            Console.WriteLine($"gia tri lon nhat trong 3 so {a}, {b}, {c} la: " + max);
        }

        static void bai5()
        {
            int a, b, c;  //khai báo biến nhận 3 số
            nhap3so("nhap a, b, c: ", out a, out b, out c);   //gọi hàm nhap3số

            //gọi hàm tìm giá trị nhỏ nhất
            int min = timGiaTriNhoNhat(a, b, c);
            Console.WriteLine($"gia tri nho nhat trong 3 so {a}, {b}, {c} la: " + min);
        }

        // hàm tìm giá trị lớn nhất
        static int timGiaTriLonNhat(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }

        // hàm tìm giá trị nhỏ nhất
        static int timGiaTriNhoNhat(int a, int b, int c)
        {
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;
        }

        // hàm tìm min max trong 3 số
        static int TimMinMaxBaSo(int a, int b, int c, out int min, out int max)
        {
            min = timGiaTriNhoNhat(a, b, c);
            max = timGiaTriLonNhat(a, b, c);
            return 0;
        }

        // hàm nhập 3 số
        static void nhap3so(string info, out int a, out int b, out int c)
        {
            Console.Write(info);  // in thông báo nhập
            a = int.Parse(Console.ReadLine());  

            b = int.Parse(Console.ReadLine());

            c = int.Parse(Console.ReadLine());
        }

        static void bai6()
        {
            int a, b, c;  //khai báo biến nhận 3 số
            nhap3so("nhap a, b, c: ", out a, out b, out c);   //gọi hàm nhap3số
            int min;
            int max;

            TimMinMaxBaSo(a, b, c, out min, out max);   //gọi hàm tìm min max

            Console.WriteLine($"ba so: {a}, {b}, {c}");
            Console.WriteLine($"gia tri lon nhat (min): {min}");
            Console.WriteLine($"gia tri lon nhat (max): {max}");
        }
    }
}
