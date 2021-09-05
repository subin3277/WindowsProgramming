using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 숫자퀴즈
    {
        static void Main(string[] args)
        {
            Random su = new Random();

            int fix_su = su.Next(1,100); 
            Console.Write("상대가 생각하고 있는 수를 입력하세요 : ");
            int input_su = Convert.ToInt16(Console.ReadLine());
            int count = 1;
            while (true)
            {
                if (fix_su < input_su)
                {
                    Console.WriteLine("너무 커");
                    Console.Write("상대가 생각하고 있는 수를 입력하세요 : ");
                    input_su = Convert.ToInt16(Console.ReadLine());
                }
                else if(fix_su > input_su)
                {
                    Console.WriteLine("너무 작어");
                    Console.Write("상대가 생각하고 있는 수를 입력하세요 : ");
                    input_su = Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("정답");
                    Console.WriteLine("랜덤 값은 "+fix_su);
                    Console.WriteLine("시도 횟수 =" + count);
                    break;
                }
                count++;
            }
                        
        }
    }
}
