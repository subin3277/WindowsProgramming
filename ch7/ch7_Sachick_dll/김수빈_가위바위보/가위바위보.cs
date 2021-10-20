using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 김수빈_가위바위보;

namespace 가위바위보
{
    class 가위바위보
    {
        static void Main()
        {
            Random su = new Random();
            int comnum = su.Next(1, 4);
            Console.WriteLine("1,2,3 중 하나의 수 입력 : ");
            int menum = Convert.ToInt32(Console.ReadLine());

            string result = 김수빈_가위바위보.GBB.Res(comnum, menum);
            Console.WriteLine("컴의 선택은 {0}",comnum);
            Console.WriteLine("나의 선택은 {0}", menum);
            Console.WriteLine(result);

        }
    }
}
