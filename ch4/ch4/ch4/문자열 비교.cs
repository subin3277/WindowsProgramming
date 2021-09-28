using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 문자열비교
    {
        static void Main(string[] args)
        {
            //string s1 = "kbs";
            //string s2 = "kbs";
            string[] s1 = new string[] { "kbs" };
            string[] s2 = new string[] { "kbs" }; //kbs가 저장된 stack 주소를 가리킴
            if (s1 == s2)
            {
                Console.WriteLine("s1과 s2는 같다");
            }
            else
                Console.WriteLine("s1과 s2는 다르다");
        }
    }
}
