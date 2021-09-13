using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class 성적입력
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("학번 입력 ");
                int hakbun = Convert.ToInt32(Console.ReadLine());
                if (hakbun == -999)
                    break;
                Console.Write("이름 입력 ");
                string name = Console.ReadLine();
                Console.Write("국어 입력 ");
                int kor = Convert.ToInt32(Console.ReadLine());
                while ((kor < 0) || (kor > 100))
                {
                    Console.Write("범위 초과됨, 국어점수 다시 입력 ");
                    kor = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("영어 입력 ");
                int eng = Convert.ToInt32(Console.ReadLine());
                while ((eng < 0) || (eng > 100))
                {
                    Console.Write("범위 초과됨, 영어점수 다시 입력 ");
                    eng = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("수학 입력 ");
                int mat = Convert.ToInt32(Console.ReadLine());
                while ((mat < 0) || (mat > 100))
                {
                    Console.Write("범위 초과됨, 수학점수 다시 입력 ");
                    mat = Convert.ToInt32(Console.ReadLine());
                }
                int tot = Sungjuck.Total(kor, eng, mat);
                double aver = tot / 3.00;
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6:F2}", hakbun, name, kor, eng, mat, tot, aver);
                Console.WriteLine("");
            }
            Console.WriteLine("성적처리 끝");
        }
    }
}
