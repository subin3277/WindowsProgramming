using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7
{
    class 메소드오버라이드
    {
        static void Main(string[] args)
        {
            자식 Gildong = new 자식();
            Gildong.Say();

            Gildong.Hi();

            Gildong.Run();
        }
    }
}
