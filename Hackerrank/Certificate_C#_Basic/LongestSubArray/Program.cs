using System;
using System.Collections.Generic;

namespace LongestSubArray
{
    class Program
    {
        static int LongestSubArray(List<int> arr)
        {
            arr.Sort();
            int max = 0;
            int[] countArr = new int[arr[arr.Count - 1] + 1];
            for (int i = 0; i < arr.Count; i++)
            {
                countArr[arr[i]]++;
            }
            for (int i = 0; i < countArr.Length - 1; i++)
            {
                if (countArr[i] != 0 && countArr[i + 1] != 0)
                {
                    if (max < countArr[i] + countArr[i + 1])
                    {
                        max = countArr[i] + countArr[i + 1];
                    }
                }
            }
            return max;
        }
        static int LongestSubArray1(List<int> arr)
        {
            arr.Sort();
            int max = 0;
            int count = 0;
            int start = 0;
            int end = 0;
            int temp = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i + 1] - arr[i] == 1)
                {
                    count++;
                    if (count == 1)
                    {
                        temp = i + 1;
                    }
                    if (count == 2)
                    {
                        end = i;
                        if (max < end - start + 1)
                        {
                            max = end - start + 1;
                        }
                        start = temp;
                        i = temp;
                        count = 0;
                    }

                }
                if (arr[i + 1] - arr[i] > 1)
                {
                    end = i;
                    if (max < end - start + 1)
                    {
                        max = end - start + 1;
                    }
                    start = i + 1;
                    count = 0;
                }
            }
            if (count == 1)
            {
                if (max < arr.Count - start + 1)
                {
                    max = arr.Count - start;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
