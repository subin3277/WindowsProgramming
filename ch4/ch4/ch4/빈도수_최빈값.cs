using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 빈도수_최빈값
    {
        static void Main(string[] args)
        {
            int in_num = 0;
            int max = 0;
            int max_num = 0;
            int[] count = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for(int i = 0; i < 10; i++)
            {
                Console.Write("숫자 0부터 9 사이 값 10개 입력 : ");
                in_num = Convert.ToInt32(Console.ReadLine());

                count[in_num]++;
            }

            Console.WriteLine("");
            Console.WriteLine("입력값\t빈도수");
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    max_num = i;
                }
                Console.WriteLine("{0}\t{1}",i,count[i]);
            }
            Console.WriteLine("최빈값은 {0} 이(가) {1}번 나타남",max_num,max);
        }
    }
}
