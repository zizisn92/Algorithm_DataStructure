using System;

namespace Bai19_Tinh_khoang_thoi_gian_giua_hai_moc_thoi_gian
{
    class Program
    {
        static void TinhKhoangThoiGian(int startSecond, int startMinute, int startHour, int endSecond,int endMinute, int endHour)
        {
            int second = 0;
            int minute = 0;
            int hour = 0;
            int x = 0;
            if(endSecond-startSecond<0)
            {
                second = 60 - startSecond + endSecond;
                x = -1;
            }
            else
            {
                second = endSecond - startSecond;
                x = 0;
            }
            if(x<0)
            {
                if(endMinute-startMinute<0)
                {
                    minute = 60 - startMinute + endMinute - 1;
                    x = -1;
                }
                else
                {
                    minute = endMinute - startMinute  - 1;
                    x = 0;
                }
                
            }
            else
            {
                if (endMinute - startMinute < 0)
                {
                    minute = 60 - startMinute + endMinute;
                    x = -1;
                }
                else
                {
                    minute = endMinute - startMinute;
                    x = 0;
                }
            }
            if (x < 0)
            {
                hour = endHour - startHour - 1;
            }
            else
            {
                hour = endHour - startHour;
            }
            Console.WriteLine($"{hour} {minute} {second}");
        }
        static void Main(string[] args)
        {
            TinhKhoangThoiGian(47, 28, 3, 48, 40, 5);
            Console.WriteLine("Hello World!");
        }
    }
}
