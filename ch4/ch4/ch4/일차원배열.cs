using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 일차원배열
    {
        static void Main(string[] args)
        {
            int[] Age = new int[5] { 2, 4, 6, 8, 10 };
            int sum = 0;
            for(int i = 0; i < Age.Length; i++)
            {
                sum += Age[i];
                Console.WriteLine("Age[{0}]={1}", i, Age[i]);
            }
            Console.WriteLine("Hap={0}",sum);
            //Console.WriteLine(Age[0]);
            //Console.WriteLine(Age[1]);
            //Console.WriteLine(Age[2]);
            //Console.WriteLine(Age[3]);
            //Console.WriteLine(Age[4]);
        }
    }
}
