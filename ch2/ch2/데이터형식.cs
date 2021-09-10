using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class 데이터형식
    {
        static void Main(string[] args)
        {
            char c1 = 'a'; //소문자
            string s1 = "aaa"; //키워드
            bool b1 = true;

            Char C2 = 'B'; //대문자
            String S2 = "BBB"; //닷넷 데이터형식
            Boolean B2 = false;

            Console.WriteLine("{0} {1} {2}", c1, s1, b1);
            Console.WriteLine("{0} {1} {2}", C2, S2, B2);
        }
    }
}
