using Sachick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class 네임스페이스연습
    {
        //public class Hap_test
        //{
        //    public int a;
        //    public int b;
        //    public int Hap()
        //    {
        //        return a + b;
        //    }
        //}
        static void Main(string[] args)
        {
            Hap_test h_t = new Hap_test();
            Hap_test.a = 6;
            Hap_test.b = 4;
            int aa = Hap_test.Hap();
            Console.WriteLine("a+b={0}",aa);
        }
    }
}
