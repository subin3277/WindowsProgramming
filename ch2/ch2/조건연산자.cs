using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class 조건연산자
    {
        static void Main(string[] args)
        {
            int Max; int Min;
            Console.Write("1 하나의 수 입력 : ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2 하나의 수 입력 : ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3 하나의 수 입력 : ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Max = num1;
            //    Min = num2;
            //}
            //else
            //{
            //    Min = num1;
            //    Max = num2;
            //}
            //if (Max < num3)
            //    Max = num3;
            //else if (Min > num3)
            //    Min = num3;

            Max = num1 > num2 ? num1 : num2;
            Min = num1 < num2 ? num1 : num2;
            if (Max < num3)
                Max = num3;
            else if (Min > num3)
                Min = num3;

            Console.WriteLine("The Max = {0}    The Min = {1}",Max,Min);
        }
        
    }
}
