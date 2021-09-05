using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class RandomSu
    {
        static void Main(string[] args)
        {
            Random su = new Random();
            //Random 클래스의 객체 su 생성 후 사용
            Console.WriteLine(su.Next());//임의의 정수 생성
            Console.WriteLine(su.Next(10)); //0에서 9사이 정수 생성

            int a = su.Next(1, 10); //1-10 사이의 정수 생성
            Console.WriteLine(a);
        }
    }
}
