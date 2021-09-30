using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Hap_Min_Max_Aver
    {
        static void Main(string[] args)
        {
            int MAX = 0;
            int MIN = 10;
            int HAP = 0;
            int AVER = 0;

            int[] su = new int[7] { 1, 3, 5, 7, 2, 4, 6 };

            for(int i = 0; i < 7; i++)
            {
                HAP += su[i];
                if (su[i] > MAX)
                    MAX = su[i];
                if (su[i] < MIN)
                    MIN = su[i];
            }
            AVER = HAP / 7;

            Console.WriteLine("HAP={0},MAX={1},MIN={2},AVER={3}",HAP,MAX,MIN,AVER);
            Console.ReadKey();
        }
    }
}
