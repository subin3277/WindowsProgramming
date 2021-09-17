using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class 가위바위보
    {
        static void Main(string[] args)
        {
            Random su = new Random();
            int count = 0;
            int com1 = 0; int com2 = 0; int com3 = 0;
            int wincount = 0; int losecount = 0; int drawcount = 0;

            while (true)
            {
                Console.Write("1, 2, 3 중 하나의 수 입력 : ");
                int mynum = Convert.ToInt16(Console.ReadLine());
                int comnum = su.Next(1, 4);
                if (mynum == -1)
                    break;
                count++;
                string res = check_w_l(comnum, mynum);
                Console.WriteLine(res);
                Console.WriteLine("컴의 선택은 {0}",comnum);
                Console.WriteLine("---------------------------------------");
                computer_su(ref com1,ref com2,ref com3,comnum);
                my_w_l_d(ref wincount,ref losecount,ref drawcount,res);

            }
            Console.WriteLine(" ");
            Console.WriteLine("총 게임 횟수 {0} 번", count);
            Console.WriteLine("컴의 가위={0}, 컴의 바위 ={1}, 컴의 보 ={2}", com1, com2, com3);
            Console.WriteLine("서로비김= {0}, 내가 승 ={1}, 내가 패={2}", drawcount, wincount, losecount);

        }
        private static void my_w_l_d(ref int my_w, ref int my_l, ref int my_d,string res)
        {
            if (res.Equals("서로 비김"))
                my_d++;
            else if (res.Equals("이김"))
                my_w++;
            else
                my_l++;
        }
        private static void computer_su(ref int com1, ref int com2, ref int com3,int comnum)
        {
            if (comnum == 1)
                com1++;
            else if (comnum == 2)
                com2++;
            else
                com3++;
        }
        private static string check_w_l(int comnum, int mynum)
        {
            if (comnum == 1)
            {
                if (mynum == 1)
                    return "서로 비김";
                else if (mynum == 2)
                    return "이김";
                else
                    return "짐";
            }
            else if (comnum == 2)
            {
                if (mynum == 1)
                    return "짐";
                else if (mynum == 2)
                    return "서로 비김";
                else
                    return "이김";
            }
            else
            {
                if (mynum == 1)
                    return "이김";
                else if (mynum == 2)
                    return "짐";
                
                else
                    return "서로 비김";
                
            }
        }
    }
}
