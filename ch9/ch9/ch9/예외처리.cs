using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9
{
    class 예외처리
    {
        static void Main(string[] args)
        {
            int i = 3;
            int j = 0;
            int k = 0;

            //k = 3 / 0; //컴파일 에러
            //k = i / j; //런타임에러 :실행시켜야 알수 있음
            //k = i + j; //원래의도는 i-j

            try //에러 의심 구간
            {
                if (j != 0)
                {
                    k = i / j;
                }
                else
                {
                    throw new Exception("제로가 오면 안됩니다.");
                    k = i / j;
                }
                
            }
            catch(Exception ex) //에러 발생시 실행 구간
            {
                Console.WriteLine("에러 발생됨");
                Console.WriteLine(ex.Message);
            }
            finally //반드시 실행할 구간
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
            Console.WriteLine("k={0}",k);
        }
    }
}
