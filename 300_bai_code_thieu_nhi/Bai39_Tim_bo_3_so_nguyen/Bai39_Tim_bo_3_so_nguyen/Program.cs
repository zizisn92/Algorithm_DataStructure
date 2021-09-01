using System;

namespace Bai39_Tim_bo_3_so_nguyen
{
    class Program
    {
        static void TimBoBaSoNguyen(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 1; k < n; k++)
                    {
                        if(i*i+j*j==k*k)
                        {
                            if (i % 2 == 0 && j%2==0&& k%2==0 && (i == j - 2 && j == k - 2))
                            {
                                Console.WriteLine($"({i},{j},{k}):Ba so chan lien tiep");
                            }
                            if(i==j-1&&j==k-1)
                            {
                                Console.WriteLine($"({i},{j},{k}):Ba so nguyen lien tiep");
                            }
                            break;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            TimBoBaSoNguyen(100);
            Console.ReadKey();
        }
    }
}
