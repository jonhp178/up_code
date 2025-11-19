using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TH_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bai1
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
                Console.WriteLine("n la so duong");
            else
                Console.WriteLine("n la so am");


            if (n % 2 == 0)
                Console.WriteLine("n la so chan");
            else
                Console.WriteLine("n la so le");
            Console.ReadKey();


            //bai 2 giả phương trình bậc 2
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a phai khac o đe giai pt");
                Console.Write("nhap lai a:");
                a = int.Parse(Console.ReadLine());
            }
            //khai báo biến
            double X1, X2, X;
            double delta = b * b - 4 * a * c;

            // giải phương trình
            if (delta > 0)
            {
                X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"phuong trinh co 2 nghiem pb x1 = {X1}, x2 = {X2}");
            }
            else

            if (delta == 0)
            {
                X = -b / (2 * a);
                Console.WriteLine($"pt co nghiem kep x = {X}");
            }
            else
                Console.WriteLine("pt vo nghiem");


            //bai 3 tìm giá trị lớn nhất trong ba số
            Console.Write("a = ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int g = int.Parse(Console.ReadLine());

            // so sanh
            int max = e;
            if (f > max) max = f;
            if (g > max) max = g;
            Console.WriteLine($"Giá trị lớn nhất trong ba số là: {max}");


            // bai 4
            Console.Write("a = ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int d = int.Parse(Console.ReadLine());

            int tmp;
            if (z > s)
            {
                tmp = z;
                z = s;
                s = tmp;
            }
            if (z > d)
            {
                tmp = z;
                z = d;
                d = tmp;
            }
            if (s > d)
            {
                tmp = s;
                s = d;
                d = tmp;
            }
            Console.WriteLine($"so sau khi hoan doi la: {z}, {s}, {d}");
            Console.ReadKey();

            //bai 5
            bool kt = true;
            Console.Write("a = ");
            double q = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double r = double.Parse(Console.ReadLine());

            if (q + p > r) kt = false;
            if (q + r > p) kt = false;
            if (p + r > q) kt = false;

            ////
            if (kt)
            {
                Console.WriteLine("la hinh tam giac");
                Console.WriteLine($"chu vi hinh tam giac: {q * e * r}");

            }
            else
                Console.WriteLine("ko phai hinh tam giac");
            Console.WriteLine($"dien tich hinh thang: {(q + e) * r / 2} ");

            Console.ReadKey();

            //bai 6
            Console.Write("nhap so thang (1-12): ");
            double month = double.Parse(Console.ReadLine());
            string monthname;
            ////////////////
            if (month == 1)
                monthname = "january";
            if (month == 2)
                monthname = "february";
            if (month == 3)
                monthname = "march";
            if (month == 4)
                monthname = "aprial";
            if (month == 5)
                monthname = "may";
            if (month == 6)
                monthname = "june";
            if (month == 7)
                monthname = "july";
            if (month == 8)
                monthname = "august";
            if (month == 9)
                monthname = "september";
            if (month == 10)
                monthname = "october";
            if (month == 11)
                monthname = "november";
            if (month == 12)
                monthname = "december";

            ////////////////////
            switch (month)
            {
                case 1:
                    monthname = "january";
                    break;
                case 2:
                    monthname = "february";
                    break;
                case 3:
                    monthname = "march";
                    break;
                case 4:
                    monthname = "aprial";
                    break;
                case 5:
                    monthname = "may";
                    break;
                case 6:
                    monthname = "june";
                    break;
                case 7:
                    monthname = "july";
                    break;
                case 8:
                    monthname = "august";
                    break;
                case 9:
                    monthname = "september";
                    break;
                case 10:
                    monthname = "october";
                    break;
                case 11:
                    monthname = "november";
                    break;
                case 12:
                    monthname = "december";
                    break;
                default:
                    monthname = "thang ko hop le";
                    break;
            }
            Console.WriteLine($"thang tuong ung la: " + monthname);
            Console.ReadKey();

            //bai 7
            Console.Write("b = ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("nhạp phep toán (+,-,*,/,%): ");
            char inp = char.Parse(Console.ReadLine());

            switch (inp)
            {
                case '+':
                    Console.WriteLine($"KQ phep toan + : {t + y} ");
                    break;
                case '-':
                    Console.WriteLine($"KQ phep toan - : {t - y} ");
                    break;
                case '*':
                    Console.WriteLine($"KQ phep toan * : {t * y} ");
                    break;
                case '/':
                    Console.WriteLine($"KQ phep toan / : {t / y} ");
                    break;
                case '%':
                    Console.WriteLine($"KQ phep toan % : {a % b} ");
                    break;

            }
            Console.ReadKey();


            //bai 8
            Console.WriteLine("nhap x (0 <= x <= 100) ");
            double x = double.Parse(Console.ReadLine());

            //không dùng swith được vì có phép toán gép, chỉ dùng swith trên c# mới nhất
            if (x >= 0 && x <= 25)
                Console.WriteLine("x thuoc doan tu [o;25]");
            else if (x > 25 && x <= 50)
                Console.WriteLine("x thuoc doan tu (25;50]");
            else if (x > 50 && x <= 75)
                Console.WriteLine("x thuoc doan tu (50;75]");
            else if (x > 75 && x <= 100)
                Console.WriteLine("x thuoc doan tu (75;100]");
            else
                Console.WriteLine("x ko thuoc doan tu [0;100]");

            //bai 9
            Console.Write("nhap ma san pham(1-5)");
            int code = int.Parse(Console.ReadLine());
            Console.Write("nhap so luong san pham");
            int quantity = int.Parse(Console.ReadLine());

            string productName = "";
            double price = 0;

            switch (code)
            {
                case 1:
                    productName = "cochorro quente";
                    price = 4.00;
                    break;
                case 2:
                    productName = "X-Salada";
                    price = 4.50;
                    break;
                case 3:
                    productName = "X-Bacon";
                    price = 5.00;
                    break;
                case 4:
                    productName = "Torrada simples";
                    price = 2.00;
                    break;
                case 5:
                    productName = "Refrigerante ";
                    price = 1.00;
                    break;

            }

            double total = price * quantity;
            //
            Console.WriteLine("\nPRODUCT NAME".PadRight(20) + "PRICE".PadLeft(10) + "QUANTITY".PadLeft(12) + "TOTAL (R$)".PadLeft(15));

            Console.WriteLine($"{productName.PadRight(20)}{price,10:F2}{quantity,12}{total,15:F2}");

            //bai 10
            Console.Write("nhap luong cua ban: ");
            double salary = double.Parse(Console.ReadLine());
            double percent;

            if (salary >= 0 && salary <= 400)
                percent = 15;
            else if (salary <= 800)
                percent = 12;
            else if (salary <= 1200)
                percent = 10;
            else if (salary <= 2000)
                percent = 7;
            else
                percent = 4;

            double newsalary = salary * (1 + percent / 100);
            Console.WriteLine($"tang{percent}% : luon moi la: {newsalary:F2}");


            //bai 11
            Console.Write("nhap hoanh do x:");
            double m = double.Parse(Console.ReadLine());
            Console.Write("nhap tung do y:");
            double v = double.Parse(Console.ReadLine());

            if (m > 0 && v > 0)
                Console.WriteLine("diem thuoc goc phan tu Q1");
            else if (m < 0 && v > 0)
                Console.WriteLine("diem thuoc goc phan tu Q2");
            else if (m < 0 && v < 0)
                Console.WriteLine("diem thuoc goc phan tu Q3");
            else if (m > 0 && v < 0)
                Console.WriteLine("diem thuoc goc phan tu Q4");

        }
    }
}