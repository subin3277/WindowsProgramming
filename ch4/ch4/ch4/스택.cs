using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 스택
    {
        static void Main(string[] args)
        {
            Stack St = new Stack();

            St.Push("첫번째");
            St.Push("두번째");
            St.Push("세번째");

            Console.WriteLine(St.Pop());
            Console.WriteLine(St.Pop());
            Console.WriteLine(St.Pop());
        }
    }
}
