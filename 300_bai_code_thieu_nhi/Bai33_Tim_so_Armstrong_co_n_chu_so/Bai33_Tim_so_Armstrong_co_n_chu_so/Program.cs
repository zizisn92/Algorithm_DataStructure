using System;

namespace Bai33_Tim_so_Armstrong_co_n_chu_so
{
    class Program
    {
        static void FindArmstrongNumber()
        {
            int sum = 0;
            int product = 1;
            int remainder;
            for (int i=153;i<999;i++)
            {
                int number = i;
                while(number>0)
                {
                    remainder = number % 10;
                    for (int j = 0; j < 3; j++)
                    {
                        product *= remainder;
                    }
                    sum += product;
                    product = 1;
                    number /= 10;
                }
                if(sum==i)
                {
                    Console.WriteLine(i);
                }
                
                sum = 0;
            }
            for (int i = 1000; i < 9999; i++)
            {
                int number = i;
                while (number > 0)
                {
                    remainder = number % 10;
                    for (int j = 0; j < 4; j++)
                    {
                        product *= remainder;
                    }
                    sum += product;
                    product = 1;
                    number /= 10;
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
            }
        }
        static void Main(string[] args)
        {
            FindArmstrongNumber();
            Console.ReadKey();
            
        }
    }
}
