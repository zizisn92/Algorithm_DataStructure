using System;

namespace Bai36_In_n_so_nguyen_to_dau_tien
{
    class Program
    {
        static bool KiemTraSoNguyenTo(int n)
        {
            if(n==2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        static void InSoNguyenTo(int n)
        {
            int number = 2;
            int count = 0;
            while(count<=n)
            {
                if(KiemTraSoNguyenTo(number))
                {
                    Console.WriteLine(number); ;
                    count++;
                }
                number++; ;
            }
        }
        static void Main(string[] args)
        {
            InSoNguyenTo(15);
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
