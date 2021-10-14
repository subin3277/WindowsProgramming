using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    class kbs
    {
        public void PrintAge()
        {
            Console.WriteLine("PrintAge 메소드 호출");
        }
        public kbs()
        {
            Console.WriteLine("Default 생성자가 제일 먼저 호출됨");
        }
    }
    class 디폴트생성자
    {
        static void Main(string[] args)
        {
            kbs k1 = new kbs();
            k1.PrintAge();
        }
    }
}
