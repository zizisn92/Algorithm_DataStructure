using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class HashSetClone<T>
    {
        public List<List<T>> HashTable { set; get; }
        public int Capacity { set; get; }
        public HashSetClone(int capacity)
        {
            this.Capacity = capacity;
            HashTable = new List<List<T>>(Capacity);
            for (int i = 0; i < Capacity; i++)
            {
                HashTable.Add(null);
            }
        }

        public int HashFunction(T item)
        {
            // Check Type data before hash
            if (item.GetType()== typeof(int))
            {
                int index;
                index = Convert.ToInt32(item) % Capacity;
                return index;
            }
            return -1;
        }
        public void Add(T item)
        {
            if (item.GetType() == typeof(int))
            {
                var index = HashFunction(item);
                if(HashTable[index] ==null)
                {
                    HashTable[index] = new List<T>();
                    HashTable[index].Add(item);
                }
                else
                {
                    HashTable[index].Add(item);
                }

            }
        }
        public bool Contains(T item)
        {
            if (item.GetType() == typeof(int))
            {
                var index = HashFunction(item);
                if (HashTable[index] == null)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < HashTable[index].Count; i++)
                    {
                        if (EqualityComparer<T>.Default.Equals(HashTable[index][i], item))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }

    class Program
    {
        static void TestPerformance(int count, int number)
        {
            HashSet<int> hashSet = new HashSet<int>();
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i < count; i++)
            {
                hashSet.Add(i);
            }
            
            stopWatch.Start();
            hashSet.Contains(number);
            stopWatch.Stop();
            Console.WriteLine($"HashSet for {count} item: {stopWatch.Elapsed.TotalMilliseconds}");
            stopWatch.Reset();
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }
            stopWatch.Start();
            list.Contains(number);
            stopWatch.Stop();
            Console.WriteLine($"List/Array for {count} item: {stopWatch.Elapsed.TotalMilliseconds}");
            Console.WriteLine("***********************************");
        }
        static Tuple<double, double> TestPerformance2(int number)
        {        
            HashSetClone<int> hashSetClone = new HashSetClone<int>(number);
            List<int> lst = new List<int>(number);
            for (int i = 0; i < number; i++)
            {
                hashSetClone.Add(i);
                lst.Add(i);
            }
            Stopwatch st = new Stopwatch();
            st.Start();
            hashSetClone.Contains(number - 1);
            st.Stop();
            double time1=st.Elapsed.TotalMilliseconds;
            st.Reset();
            st.Start();
            lst.Contains(number - 1);
            st.Stop();
            double time2=st.Elapsed.TotalMilliseconds;
            return new Tuple<double, double> ( time1,time2);
        }
        static void TestPerformance3(int number)
        {
            HashSetClone<int> hashSetClone = new HashSetClone<int>(number);
            List<int> lst = new List<int>(number);
            for (int i = 0; i < number; i++)
            {
                hashSetClone.Add(i);
                lst.Add(i);
            }
            Stopwatch st = new Stopwatch();
            st.Start();
            hashSetClone.Contains(number - 1);
            st.Stop();
            Console.WriteLine($"HashSet for {number} item:{st.Elapsed.TotalMilliseconds}");
            st.Reset();
            st.Start();
            lst.Contains(number - 1);
            st.Stop();
            double time2 = st.Elapsed.TotalMilliseconds;
            Console.WriteLine($"List/Array for {number} item:{st.Elapsed.TotalMilliseconds}");
        }
        static void TestPerformance4(int []array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                HashSet<int> hashSet = new HashSet<int>(array[i]);
                for (int j = 0; j < array[i]; j++)
                {
                    hashSet.Add(j);
                }
                Stopwatch st = new Stopwatch();
                st.Start();
                hashSet.Contains(1);
                st.Stop();
                Console.WriteLine($"HashSet for {array[i]} item:{st.Elapsed.TotalMilliseconds}");
            }
        }
        static void Main(string[] args)
        {
            //TestPerformance(100000,99999);

            //TestPerformance(10000000, 9999999);

            //Console.WriteLine("Hello World!");
            //int count = 1;
            //Tuple<double, double> tuple = new Tuple<double, double> ( 0, 0 );
            //while (tuple.Item1<=tuple.Item2)
            //{
            //    Tuple<double, double> result= TestPerformance2(count);
            //    count++;
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);
            //TestPerformance2(1000);
            //int[] array = new int[5] { 10, 100, 1000, 10000, 1000000 };
            //TestPerformance4(array);
            //TestPerformance3(100000);
            //TestPerformance3(10000000);
            int i=1;
            int count = 0;
            //do
            //{
            //    i++;
            //    count++;
            //} while (i < 10);
            while (i < 10)
            {
                i++;
                count++;
            }
            //for (int i = 1;  i< 6; i++)
            //{
            //    n += i;
            //}
            Console.ReadKey();
            //hashSetClone.Add(1);
            //hashSetClone.Add(2);
            //hashSetClone.Add(3);
            //hashSetClone.Add(11);
            //Console.WriteLine(hashSetClone.Constaint(3));
            //Console.WriteLine(hashSetClone.Constaint(11));
            //Console.WriteLine(hashSetClone.Constaint(4));
        }
    }
}
