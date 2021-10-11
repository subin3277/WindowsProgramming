using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Method_Class
    {
        static void Main(string[] args)
        {
            Top su = new Top();
            //su.a = 3;
            //su.b = 6;
            Top.a = Convert.ToInt32(Console.ReadLine());
            Top.b = Convert.ToInt32(Console.ReadLine());

            int sum = Top.hap();
            Console.WriteLine("{0}+{1}={2}",Top.a,Top.b,sum);
        }
    }

    public class Top
    {
        public static int a;
        public static int b;
        public static int hap()
        {
            return a + b;
        }
    }
}
