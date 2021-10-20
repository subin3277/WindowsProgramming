using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jumin_DLL;

namespace Jumin
{
    class Jumin
    {
        static void Main(string[] args)
        {
            string jumin = "";

            Console.WriteLine("주민번호를 -없이 입력하세요 : ");
            jumin = Console.ReadLine();
            Console.WriteLine("당신이 태어난 년도는 {0}", Jumin_DLL.Calculator.YEAR(jumin));
            Console.WriteLine("당신이 태어난 월은 {0}", Jumin_DLL.Calculator.MONTH(jumin));
            Console.WriteLine("당신이 태어난 날은 {0}", Jumin_DLL.Calculator.DAY(jumin));
            Console.WriteLine("당신의 나이는 {0}", Jumin_DLL.Calculator.NAI(jumin));
            Console.WriteLine("당신의 성별은 {0}", Jumin_DLL.Calculator.TYPE(jumin));
        }
    }
}
