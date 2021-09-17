using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class 가위바위보
    {
        static void Main(string[] args)
        {
            Random su = new Random();
            int comnum = su.Next(1, 4);

            Console.Write("1, 2, 3 중 하나의 수 입력 : ");
            int mynum = Convert.ToInt32(Console.ReadLine());

            if(mynum == 1)
            {
                if(comnum == 1)
                    Console.WriteLine("서로 비김");
                else if(comnum==2)
                    Console.WriteLine("짐");
                else
                    Console.WriteLine("이김");
            }
            else if (mynum == 2)
            {
                if (comnum == 1)
                    Console.WriteLine("이김");
                else if (comnum == 2)
                    Console.WriteLine("서로 비김");
                else
                    Console.WriteLine("짐");
            }
            else
            {
                if (comnum == 1)
                    Console.WriteLine("짐");
                else if (comnum == 2)
                    Console.WriteLine("이김");
                else
                    Console.WriteLine("서로비김");
            }
            Console.WriteLine("컴의 선택은 {0}",comnum);
        }
    }
}
