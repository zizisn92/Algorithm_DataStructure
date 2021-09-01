using System;

namespace Bai37_Tim_so_nguyen_duong_lon_nhat
{
    class Program
    {
        static void TimSo(int n)
        {
            int sum = 0;
            int count = 0;
            int number = 1;
            int result;
            while(sum<n)
            {
                sum += number;
                count++;
                number++;
            }
            Console.WriteLine(count - 1);

        }
        static void Main(string[] args)
        {
            TimSo(22);
            Console.ReadKey();
            
        }
    }
}
