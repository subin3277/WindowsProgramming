using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    class sbs
    {
        private static string name = "홍서방";
        private int age = 19;

        public static void Print()
        {
            Console.WriteLine("정적 이름은: {0}",sbs.name);
        }
        public void Out()
        {
            Console.WriteLine("인스턴스 나이는 : {0}",age);
        }
        public sbs()
        {
            Console.WriteLine("Default C#");
        }
    }
    class 생성자
    {
        static void Main(string[] args)
        {
            sbs.Print(); //이름 출력
            sbs k1 = new sbs(); //default 호출, sbs 호출
            k1.Out(); //나이 출력
        }
    }
}
