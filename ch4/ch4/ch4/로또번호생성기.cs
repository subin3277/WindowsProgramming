using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class 로또번호생성기
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int resultNum = 0;

            Console.WriteLine("로또번호 생성기");
            for(int j = 0; j < 20; j++)
            {
                int[] list = new int[6] { 0,0,0,0,0,0};
                for (int i = 0; i < 6; i++)
                {
                    resultNum = randNum.Next(1, 46);
                    if (list.Contains(resultNum))
                        i--;
                    else
                    {
                        list[i] = resultNum;
                        Console.Write(resultNum + "\t");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
