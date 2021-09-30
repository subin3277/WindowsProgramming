using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Ranking
    {
        static void Main(string[] args)
        {
            int[] Num = new int[5] { 33, 22, 44, 55, 11 };
            int[] Rank = new int[5] { 0, 0, 0, 0, 0 };
            int i = 0; int j = 0;

            for(i = 0; i < 5; i++)
            {
                Rank[i] = 1;
                for (j = 0; j < 5; j++)
                {
                    if (Num[i] < Num[j])
                        Rank[i]++;
                }
            }
            for(i = 0;i<5;i++)
                Console.WriteLine("점수 {0}는 {1} 등임",Num[i],Rank[i]);
        }
        
    }
}
