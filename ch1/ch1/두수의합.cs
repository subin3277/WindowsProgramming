using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 두수의합
    {
        static void Main(string[] args)
        {
            Console.Write("하나의 수 s1 입력 : ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("또 하나의 s2 입력 : ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}과 {1}의 합은 = {2}",s1,s2,s1+s2);
        }
    }
}
