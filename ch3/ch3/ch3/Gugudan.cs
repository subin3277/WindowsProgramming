using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Gugudan
    {
        static void Main(string[] args)
        {
            for(int k = 1; k < 4; k++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int i = 3*k-2; i < 3*k+1 ; i++)
                    {
                        Console.Write("{0}*{1}={2:D2}   ", i, j, i * j);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            
            
        }
    }
}
