using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class Method
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            //int tot = a + b;
            //Console.WriteLine("a + b = {0}", tot);
            Sum(a, b);
        }

        private static void Sum(int c, int d)
        {
            int tot = c + d;
            Console.WriteLine("a + b = {0}", tot);
        }
    }
}
