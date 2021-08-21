using System;
using System.Collections.Generic;

namespace weighted_uniform_string
{
    class Program
    {
  
        static string[] weightedUniformStrings(string s, int[] queries)
        {
            List<int> lst = new List<int>();
            string[] result = new string[queries.Length]; 
            int tong = 0;
            for(int i=0;i<s.Length-1;i++)
            {
                tong +=Convert.ToInt32(s[i])-96;
                lst.Add(tong);
                if(s[i]!=s[i+1])
                {
                    tong = 0;
                }
                if(i==s.Length-2)
                {
                    tong += Convert.ToInt32(s[s.Length-1]) - 96;
                    lst.Add(tong);
                }
            }
            for(int i=0;i<queries.Length;i++)
            {
                
                if (lst.BinarySearch(queries[i])!=null)
                {
                    result[i] = "Yes";
                }
                else
                {
                    result[i] = "No";
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] querry = new int[] { 1, 3, 12, 5, 9, 10 };
            int[] querry1 = new int[] { 9, 7,8,12,5 };
            foreach (var item in weightedUniformStrings("abccddde", querry))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***************************");
            foreach (var item in weightedUniformStrings("aaabbbbcccddd", querry1))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
