using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Total
    {
        static void Main(string[] args)
        {
            int count = 0;
            int oddsum = 0; int evensum = 0; int oddcount = 0; int evencount = 0;
            while (true)
            {
                Console.Write("정수 입력 : ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    Console.WriteLine("+++++++++++++++++");
                    Console.WriteLine("데이터 갯수 {0}",count);
                    Console.WriteLine("짝수의 합 {0}",evensum);
                    Console.WriteLine("짝수의 갯수 {0}", evencount);
                    Console.WriteLine("홀수의 합 {0}", oddsum);
                    Console.WriteLine("홀수의 갯수 {0}", oddcount);
                    break;                       
                }
                else
                {
                    if (num % 2 == 0)
                    {
                        evencount++;
                        evensum = evensum + num;
                    }
                    else
                    {
                        oddcount++;
                        oddsum = oddsum + num;
                    }
                    count++;
                }
            }
        }
    }
}
