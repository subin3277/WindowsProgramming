using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class switch_hakjum
    {
        static void Main(string[] args)
        {
            int score;
            while (true)
            {
                Console.Write("점수 입력 : ");
                score = Convert.ToInt32(Console.ReadLine());

                if (score == -999)
                {
                    break;
                }
                else if (score > 100 || score < 0)
                {
                    Console.WriteLine("점수 범위 초과 됨");
                    Console.WriteLine(" ");
                }
                else
                {
                    string hakjum = Hakjum_gyesan(score);
                    Console.WriteLine("학점은 {0}", hakjum);
                    Console.WriteLine(" ");
                }
                
            }
         
        }
        public static string Hakjum_gyesan(int score)
        {
            switch (score / 10)
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                case 6:
                    return "D";
                default:
                    return "F";
            }
        }
    }
}
