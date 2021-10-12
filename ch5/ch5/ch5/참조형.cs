using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class kbs
    {
        public int a = 5;
    }
    class 참조형
    {
        static void Main(string[] args)
        {
            kbs k1 = new kbs(); //  k1에는 주소값이 전달 – 인스턴스는 주소 값 (1000번지)  
            kbs k2 = k1;      //  k2 에 k1주소 가 전달  - k1,  k2 같은 번지 공유 1000번지

            Console.WriteLine("k1의 a 값은 {0},  k2의 a 값은 {1}", k1.a, k2.a);

            k2.a = 12;   // 1000번지 데이터를 12로 변환 – k1, k2 둘 다 12 로 수정됨
            Console.WriteLine("k1의 a 값은 {0},  k2의 a 값은 {1}", k1.a, k2.a);
        }

    }
}
