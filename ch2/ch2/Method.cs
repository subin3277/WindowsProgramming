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
            int hap = Plus.Sum(a, b);
            Console.WriteLine("a+b={0}", hap);
        }

    }
    //public class Plus
    //{
    //    public static int Sum(int a1, int b1)
    //    {
    //        int tot;
    //        tot = a1 + b1;
    //        return tot;
    //    }
    //}
}
