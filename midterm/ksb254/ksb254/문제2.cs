using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksb254
{
    class 문제2
    {
        static void Main(string[] args)
        {
            int won = 0;
            Console.Write("물건의 가격을 입력하세요(1000원 미만) : ");
            won = Convert.ToInt32(Console.ReadLine());

            int fivehun=0, hun=0, fifty=0, ten=0, one = 0;
            int charge = 1000 - won;

            if(charge >= 500)
            {
                fivehun = charge / 500;
                charge = charge % 500;
            }
            if (charge >= 100)
            {
                hun = charge / 100;
                charge = charge % 100;
            }
            if(charge >= 50)
            {
                fifty = charge / 50;
                charge = charge % 50;
            }
            if(charge >= 10)
            {
                ten = charge / 10;
                charge = charge % 10;
            }
            one = charge;

            Console.WriteLine("거스름돈입니다.");
            Console.WriteLine("");

            Console.WriteLine("500원 {0} 개", fivehun);
            Console.WriteLine("100원 {0} 개", hun);
            Console.WriteLine("50원 {0} 개", fifty);
            Console.WriteLine("10원 {0} 개", ten);
            Console.WriteLine("1원 {0} 개", one);
            Console.WriteLine("거스름돈은 {0}원 입니다.",1000-won);
        }
    }
}
