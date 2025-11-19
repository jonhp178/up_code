using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang1_th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bai1();
            //bai2();
            //bai3();
            //bai4();
            //bai5();
            bai6();
        }
        static void bai1()
        {
            int[] array1 = new int[3];
            nhapmang1(array1);
            int[] array2;
            nhapmang2(out array2);
            int[] array3 = nhapmang3();
        }
        static void nhapmang1(int[] a1)
        {
            Console.WriteLine($"nhap {a1.Length} phan tu cua mang ");
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write($" a[{i}]= ");
                a1[i] = int.Parse(Console.ReadLine());
            }

        }

        static void nhapmang2(out int[] a)
        {
            Console.Write($"nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            a = new int[n];  //'out' bắt buộc hàm phải khỏi tạo giá trị cho 'a' trước khi kết thúc

            Console.WriteLine($"nhap {n} phan tu cho mang ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($" a[{i}]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int[] nhapmang3()
        {
            Console.Write($"nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];   //khoi tao mang moi

            Console.WriteLine($"nhap {n} phan tu cho mang ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($" a[{i}]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            //tra ve mang vua tao
            return a;

        }
        static void bai2()
        {
            int[] array2;
            nhapmang2(out array2);
            xuatmang(array2);
        }
        static void xuatmang(int[] a)
        {
            Console.WriteLine("cac phan tu cua mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
        static void bai3()
        {
            int[] array3 = nhapmang3();
            xuatmang(array3);
            long tong = tinhtong(array3);
            Console.WriteLine($"tong cac phan tu: {tong}");
        }
        static long tinhtong(int[] a)
        {
            long sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        static void bai4()
        {
            int[] array3 = nhapmang3();
            xuatmang(array3);
            Console.WriteLine("gia tri x can tim ");
            int x = int.Parse(Console.ReadLine());

            int vitritimthay = tiemkiem(array3, x);
            if (vitritimthay == -1)
            {
                Console.WriteLine($"ko tim thay {x} trong mang");
            }
            else
            {
                Console.WriteLine($"gia trị là {x}");
            }
        }
        static int tiemkiem(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        static void bai5()
        {
            int[] array3 = nhapmang3();
            xuatmang(array3);
            int giatrimax = timmax(array3, out int vitrimax);
            Console.WriteLine($"gia tri lon nhat la: {giatrimax}");
            Console.WriteLine($"vi tri (index) cuoi cung cua gia tri lon nhat la: {vitrimax}");

        }
        static int timmax(int[] a, out int vitri)
        {
            int max = a[0];
            vitri = 0;

            for (int i = 0; i < a.Length; i++)
            {
                //nếu tìm thấy vị trí lớn hơn cập nhật vị trí và mã
                if (a[i] > max)
                {
                    max = a[i];
                    vitri = i;
                }
                //nếu tìm thấy vị trí bằng max thì chỉ cẩn cập nhật vị trí(để lấy vị trí cuối cùng)
                else if (a[i] == max)
                {
                    vitri = i;
                }

            }
            return max;
        }
        static void bai6()
        {
            int[] array3 = nhapmang3();
            xuatmang(array3);
            int ketqua = demsoduong(array3);
            Console.WriteLine($"so luong so nguyen duong la: {ketqua}");

        }
        static int demsoduong(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    dem++;
                }
            }
            return dem;
        }














    }
}
