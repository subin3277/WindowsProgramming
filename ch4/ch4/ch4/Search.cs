using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Search
    {
        static void Main(string[] args)
        {
            int data = 0;
            int[] su = new int[10] { 1, 3, 5, 7, 9, 2, 3, 9, 8, 7 };

            Console.Write("1부터 10 사이 하나의 수 입력 : ");
            data = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                if (su[i] == data)
                {
                    Console.WriteLine("찾는 데이터 {0}는 {1}번째 인덱스에 있습니다.",data,i);
                }
            }
        }
    }
}
