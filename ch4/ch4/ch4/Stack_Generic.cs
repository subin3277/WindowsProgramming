using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Stack_Generic
    {
        static void Main(string[] args)
        {
            // stack 사용
            Stack St1 = new Stack();
            St1.Push(123);

            int garo = (int)St1.Pop();
            Console.WriteLine(garo);

            // generic 사용
            Stack<int> St2 = new Stack<int>();
            St2.Push(567);

            int sero = St2.Pop();
            Console.WriteLine(sero);
        }
    }
}
