using System;
using System.Collections.Generic;
using System.Linq;

namespace Climbing_the_Leaderboard
{
    class Program
    {
        static int[] Climbing_The_Leaderboard(int [] scores, int [] alice)
        {
            var lstScores = scores.ToList();
            lstScores.Sort();
            var lstTemp = new List<int>();
            var lstResult = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int []result = new int[alice.Length];
            //var lstResult = new List<int>();
            int index = 1;
            int index1 = 1;
            int index2 = 0;
            for (int i=0;i<lstScores.Count;i++)
            {
                
                if (dic.ContainsKey(lstScores[i])==false)
                {
                    dic[lstScores[i]] = 1;
                    lstTemp.Add(lstScores[i]);
                    
                }
                else
                {
                    dic[lstScores[i]]++;
                }
            }
            lstTemp.Sort();
            for (int i=0;i<alice.Length;i++)
            {
                for(int j= lstTemp.Count-1; j>=0 ;j--)
                {
                    if(alice[i]>= lstTemp[j])
                    {
                        index1++;
                        lstResult.Add(lstTemp.Count-j);
                        result[index2] = lstTemp.Count - j;
                        index2++;
                        break;
                    }
                }
                if(index1==1)
                {
                    lstResult.Add(lstTemp.Count+1);
                    result[index2] = lstTemp.Count + 1;
                    index2++;
                }
            }
            return result;
        }
        static int [] Climbing_The_Leaderboard1(int[] scores, int[] alice)
        {
            
            var lstScores = scores.ToList();
            var lstResult = new List<int>();
            lstScores.Sort();
            int index = 0;
            var lstTemp = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i=0;i<lstScores.Count-1;i++ )
            {
                if(lstScores[i]==lstScores[i+1])
                {
                    index++;
                }
            }

            for (int i = 0; i < lstScores.Count; i++)
            {

                if (dic.ContainsKey(lstScores[i]) == false)
                {
                    dic[lstScores[i]] = 1;
                    lstTemp.Add(lstScores[i]);

                }
                else
                {
                    dic[lstScores[i]]++;
                }
            }
            lstTemp.Sort();
            
            for (int i = 0; i < alice.Length; i++) 
            {
                int dem = 0;
                for (int j = 0; j < lstTemp.Count; j++)
                {
                    
                    if(alice[i]< lstTemp[j])
                    {
                        dem++;
                        lstResult.Add(lstTemp.Count+1-j);
                        //z= x - i;
                        break;
                        //lstResult.Add()
                        //dem++;
                        //break;
                       
                    }
                    
                }
                if(dem==0)
                {
                    lstResult.Add(1);
                }
                //lstResult.Add(z);
            }
            return lstResult.ToArray();
        }
        static void Main(string[] args)
        {
            int[] scores = new int[]{ 100, 100, 50, 40, 40, 20, 10 };
            int[] alice = new int[] { 5,25,50,120 };

            int[] scores1 = new int[] { 100, 90, 90, 80, 75, 60 };
            int[] alice1 = new int[] { 50, 65, 77, 90,102 };

            //Climbing_The_Leaderboard1(scores, alice);
            foreach (var item in Climbing_The_Leaderboard1(scores1, alice1))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
