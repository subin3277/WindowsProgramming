using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7
{
    class MainClass
    {
        static void Main()
        {
            ClassOne.Insa();

            다른네임스페이스.OtherClass.Insa();
        }

        public class ClassOne
        {
            public static void Insa()
            {
                Console.WriteLine("안녕..");
            }
        }
        
    }
}
