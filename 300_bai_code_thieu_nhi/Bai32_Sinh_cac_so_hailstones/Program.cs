using System;

namespace Bai32_Sinh_cac_so_hailstones
{
    class Program
    {

        static void SinhCacSoHailstones(int number)
        {
            int count = 0;
            while(number!=1)
            {
                Console.Write("{0,-10}", number);
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = 3 * number + 1;
                }
               
                count++;
                if(count==6)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
            Console.Write("{0,-10}", number);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n");
            int n = Int32.Parse(Console.ReadLine());
            SinhCacSoHailstones(n);
            Console.ReadKey();
        }
    }
}
