using System;

namespace Bai15_Ngay_bao_nhieu_trong_nam
{

    class Program
    {
        static bool KiemTraNamNhuan(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }
        static int TinhNgayTrongNam(int day, int month, int year)
        {
            int sum = 0;
            sum = (int)(30.42 * (month - 1)) + day;
            if (month == 2 || (KiemTraNamNhuan(year) && month > 2))
            {
                sum++;
            }
            if(month>2 && month<8)
            {
                sum--;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TinhNgayTrongNam(4, 4, 2000));
            Console.ReadKey();
        }
    }
}
