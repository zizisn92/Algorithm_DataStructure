using System;

namespace reduce_string
{
    class Program
    {
        static string superReducedString(string s)
        {
            int i = 0;
            while (i < s.Length - 1)
            {
                if(i<0)
                {
                    i = 0;
                }
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);
                    i = i - 1;
                    continue;
                }
                i++;
            }
            if(s.Length==0)
            {
                return "Empty String";
            }
            else
            {
                return s;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(superReducedString("aaabccddd"));
            Console.WriteLine(superReducedString("bb"));
            Console.ReadKey();
        }
    }
}
