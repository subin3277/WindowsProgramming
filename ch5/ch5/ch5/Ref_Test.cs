using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Ref_Test
    {
        static void CallByRef(ref int x)  // 50 이 저장되어 있는 주소의 값은 정수다
        {
            Console.WriteLine("함수내로 전달된 값 : {0}", x);
            x = 1000;     // 전달 받은 주소의 값을 수정
            Console.WriteLine("함수내 재 지정한 값 : {0}", x);  // 수정된 값 출력
        }

        public static void Main(string[] args)
        {
            int y = 50;
            CallByRef(ref y);  // ref : 50 넘겨주는 것이 아니라, 50 이 저장된 주소를 전달함
            Console.WriteLine("Call By Ref : {0}", y);   // 위에서 같은 주소에 수정된 값 출력
        }   // 외부에서 내부로 값을 전달할 때 : ref 사용
    }
}
