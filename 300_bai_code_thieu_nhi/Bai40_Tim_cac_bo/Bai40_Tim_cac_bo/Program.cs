using System;

namespace Bai40_Tim_cac_bo
{
    class Program
    {
        static void TimBoSo(int n)
        {
            for (int i = 0; i < n/5; i++)
            {
                for (int j = 0; j < n/3; j++)
                {
                    for (int k = 0; k < n*3; k++)
                    {
                       if(i*5+j*3+k/3==n)
                       {
                            Console.WriteLine($"({i},{j},{k})");
                            break;
                       }    
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            TimBoSo(100);
            Console.ReadKey();
           // Console.WriteLine("Hello World!");
        }
    }
}
