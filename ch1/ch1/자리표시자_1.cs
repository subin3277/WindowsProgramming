using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 자리표시자_1
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int hap = 0;
            hap = a + b;
            Console.WriteLine("{0}+{1}={2}",a,b,hap);
            Console.WriteLine(a+"+"+b+"="+hap);
        }
    }
}
