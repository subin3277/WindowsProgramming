using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Method
    {
        public static void Main(string[] args)
        {
            Start(); //매개변수, 반환값 없는 메소드
        }

        private static void Start()
        {
            Console.WriteLine("매개변수와 반환 값이 없는 메소드");
        }
    }
}
