using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 성적처리
    {
        static void Main(string[] args)
        {
            int[,] jumsu = new int[4, 7] { {1,33,44,55,0,0,0 },
                                           {2,77,88,99,0,0,0 },
                                           {3,55,66,77,0,0,0 },
                                           {4,66,77,88,0,0,0} };
            string[] name = new string[] { "KBS", "SBS", "YTN", "MBC" };

            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 4; j++)
                {
                    jumsu[i, 4] += jumsu[i, j];
                }
                jumsu[i, 5] = jumsu[i, 4] / 3;
            }

            for (int i = 0; i < 4; i++)
            {
                jumsu[i,6] = 1;
                for (int j = 0; j < 4; j++)
                {
                    if (jumsu[i,5] < jumsu[j,5])
                        jumsu[i,6]++;
                }
            }

            Console.WriteLine("학번\t이름\t국어\t영어\t수학\t총점\t평균\t석차");
            Console.WriteLine("============================================================");
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if (j == 1)
                        Console.Write("{0}\t",name[i]);
                    Console.Write("{0}\t",jumsu[i,j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
