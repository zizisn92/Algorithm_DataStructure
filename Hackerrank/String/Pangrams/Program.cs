using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static string pangrams(string s)
        {
            int dem = 0;
            List<int> lst = new List<int>();
            for(int i=65;i<=90;i++)
            {
                lst.Add(i);
            }
            for (int i = 97; i <= 122; i++)
            {
                lst.Add(i);
            }
            lst.Add(32);
            for(int i=0;i<s.Length;i++)
            {
                var x = Convert.ToInt32(s[i]);
                if(lst.Contains(x)==true&& x!=32)
                {
                    if(x>=97)
                    {
                        lst.Remove(x);
                        lst.Remove(x - 32);
                    }
                    else
                    {
                        lst.Remove(x);
                        lst.Remove(x + 32);
                    }
                    dem++;
                }
            }
            if(dem ==26)
            {
                return "pangram";

            }
            else
            {
                return "not pangram";
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the next prize"));
            Console.ReadKey();
        }
    }
}
