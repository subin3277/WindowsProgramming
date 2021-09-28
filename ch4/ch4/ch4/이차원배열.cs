using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 이차원배열
    {
        static void Main(string[] args)
        {
            int[,] Arr = new int[2,4]{ { 10, 20, 30 ,0}, { 40, 50, 60,0 } };
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t",Arr[i,j]);
                    Arr[i, 3] += Arr[i, j];
                    
                }
                Console.WriteLine("");
            }
            
        }
    }
}
