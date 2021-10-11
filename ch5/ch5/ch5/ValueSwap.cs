using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class ValueSwap
    {
        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("교환 메소드 내의 a: {0}, b:{1}", a, b);
        }

        public static void Main()
        {
            int a = 3;
            int b = 4;
            Console.WriteLine("호출하기 전의 a:{0}, b:{1}",a,b);
            Swap(a, b);
            Console.WriteLine("호출 후의 a:{0}, b:{1}", a, b);
        }
    }
}
