using System;

namespace Bai30_Tinh_Lai_Xuat_Nam
{
    class Program
    {
        static void TinhLaiXuatNam(double laiXuat, double vonBanDau, int nam)
        {
            double a;
            Console.WriteLine("{0,-10}{1,-10}", "NAM", "VON");
            for (int i = 1; i <= nam+1; i++)
            {
                double y=1;
                for (int j = 1; j < i; j++)
                {
                    y *= (1 + laiXuat/100);
                }
                a = vonBanDau * y;
                if(i!=1)
                {
                    Console.WriteLine("{0,-10}{1,-10}", i - 1, a);
                }
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap lai xuat");
            double laiXuat = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap von ban dau:");
            double vonBanDau = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi han");
            int nam = Int32.Parse(Console.ReadLine());
            TinhLaiXuatNam(laiXuat, vonBanDau, nam);
            Console.ReadKey();
        }
    }
}
