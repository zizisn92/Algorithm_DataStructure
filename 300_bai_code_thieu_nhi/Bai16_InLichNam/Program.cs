using System;

namespace Bai16_InLichNam
{
    class Program
    {
        static bool KiemTraNamNhuan(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            return false;
        }
        static int TinhSoNgayTrongThang(int month, int year)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10||month==12)
            {
                return 31;
            }
            else if(month ==2)
            {
                if(KiemTraNamNhuan(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else
            {
                return 30;
            }
        }
        static int getDow(int q, int m, int y)
        {
            if (m == 1) { m = 13; y--; }
            if (m == 2) { m = 14; y--; }
            int k = y % 100;
            int j = y / 100;
            int h = q + (13 * (m + 1)) / 5 + k + k / 4 + j / 4 + 5 * j;
            h = h % 7;
            return h == 0 ? 6 : h - 1;
        }
        static void InLichNam(int year)
        {
            for(int i=1;i<=12;i++)
            {
                Console.WriteLine("{0,30}", $"Thang {i}");
                Console.WriteLine("{0,-5}{1,-5}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}", "S", "M", "T", "W", "T", "F", "S");
                int count = 0;
                int ngayDauTienThang = getDow(1, i, year);
                count = ngayDauTienThang;
                for (int j = 0; j < ngayDauTienThang; j++)
                {
                    Console.Write("{0,-5}"," ");
                }
                for (int k = 1; k <= TinhSoNgayTrongThang(i,year); k++)
                {
                    if(count % 7==0)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                    Console.Write("{0,-5}",k);
                    count++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap nam: ");
            int nam = Int32.Parse(Console.ReadLine());
            InLichNam(nam);
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
