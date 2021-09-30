using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 막대그래프
    {
        static void Main(string[] args)
        {
            string[] name = { "김서방", "나서방", "다서방", "라서방", "마서방", "바서방" };
            int[] score = { 66, 77, 99, 55, 88, 75 };

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}\t{1}",name[i],score[i]);
            }
        }
    }
}
