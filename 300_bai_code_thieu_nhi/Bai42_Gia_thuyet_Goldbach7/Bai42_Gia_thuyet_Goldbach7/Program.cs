using System;
using System.Collections.Generic;

namespace Bai42_Gia_thuyet_Goldbach7
{
    class Program
    {
        static bool KiemTraSoNguyenTo(int n)
        {
            if(n==2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n%i==0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static List<int> TimSoNguyenTo(int n)
        {
            List<int> lst = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if(KiemTraSoNguyenTo(i))
                {
                    lst.Add(i);
                }
            }
            return lst;
        }
        static List<string> Goldbach7(int n)
        {
            List<int> lstSnt = TimSoNguyenTo(n);
            List<string> lstKq = new List<string>();

            for (int i = 0; i < lstSnt.Count; i++)
            {
                for (int j = 0; j < lstSnt.Count; j++)
                {
                    for (int k = 0; k < lstSnt.Count; k++)
                    {
                        int kq= lstSnt[i] + lstSnt[j] + lstSnt[k];
                        if (lstSnt.Contains(kq))
                        {
                            lstKq.Add($"{lstSnt[i]} + {lstSnt[j]} + {lstSnt[k]}" + "=" + kq);
                        }
                    }
                }
            }

            return lstKq;
        }
        static void Main(string[] args)
        {
            var kq = Goldbach7(100);
            for (int i = 0; i < kq.Count; i++)
            {
                Console.WriteLine(kq[i]);
            }
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
