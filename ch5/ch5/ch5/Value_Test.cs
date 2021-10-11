using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Value_Test
    {
        static void Main(string[] args)
        {
            int i = 100;
            int j = i;

            Console.WriteLine("i는 {0}, j는 {1}",i,j);

            j = 200;
            Console.WriteLine("i는 {0}, j는 {1}로 수정",i,j);
        }
        
    }
}
