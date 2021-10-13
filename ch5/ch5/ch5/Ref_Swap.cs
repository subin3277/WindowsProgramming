using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Ref_Swap
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("메소드 안에서의 a={0}, b={1}",a,b);
        }

        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            Console.WriteLine("교환전의 a={0}, b={1}",a,b);
            Swap(ref a, ref b);
            Console.WriteLine("교환 후의 a={0}, b={1}", a, b);
        }
    }
}
