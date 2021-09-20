using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class For_Star
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
