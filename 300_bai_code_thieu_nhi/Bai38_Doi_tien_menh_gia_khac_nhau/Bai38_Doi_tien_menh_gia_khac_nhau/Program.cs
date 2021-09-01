using System;

namespace Bai38_Doi_tien_menh_gia_khac_nhau
{
    class Program
    {
        static string DoiTien(int n)
        {
            int min = n;
            string result = "";
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n/2; j++)
                {
                    for (int k = 0; k < n/5; k++)
                    {
                        if((i+2*j+5*k==n)&&j>(i+k))
                        {
                            if(min> i + j + k)
                            {
                                min = i + j + k;
                                result = $"({i}.{j},{k}:{i + j + k})";
                            }
                            break;
                        }    
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DoiTien(137));
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
