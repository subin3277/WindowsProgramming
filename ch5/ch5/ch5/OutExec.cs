using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class OutExec
    {
        public static void Exchange(int won, out float Doller, out float Yen)
        {
            Doller = won / 1100;
            Yen = won / 10;
        }
        static void Main(string[] args)
        {
            int won; float Doller; float Yen;
            Console.Write("환산할 금액을 입력하세요 : ");
            won = Convert.ToInt32(Console.ReadLine());
            Exchange(won, out Doller, out Yen);
            Console.WriteLine("달러로 환산한 금액은 {0}", Doller);
            Console.WriteLine("엔화로 환산한 금액은 {0}", Yen);
        }
    }

}
