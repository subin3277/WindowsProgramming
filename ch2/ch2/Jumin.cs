using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class Jumin
    {
        static void Main(string[] args)
        {
            string jumin = ""; int nowyear = 0;
            int year = 0; int month = 0; int day = 0; int gender = 0;
            int c_year = 0;
            Console.Write("주민번호 13자리를 입력하세요 : ");
            jumin = Console.ReadLine();

            year = Convert.ToInt32(jumin.Substring(0, 2));
            month = Convert.ToInt32(jumin.Substring(2, 2));
            day = Convert.ToInt32(jumin.Substring(4, 2));
            gender = Convert.ToInt32(jumin.Substring(6, 1));

            nowyear = DateTime.Now.Year;
            c_year = Calc.Calc_Year(year, gender);

            Console.WriteLine("년도는 : {0}", c_year);
            Console.WriteLine("월는 : {0}", month);
            Console.WriteLine("일는 : {0}", day);
            Console.WriteLine("올해 나이는 : {0}", Calc.Calc_Age(c_year,nowyear));
            Console.WriteLine("성별은 : {0}",Calc.Calc_Gender(gender));
            
        }
    }

    public class Calc
    {
        public static int Calc_Year(int year, int gender)
        {
            if (gender == 1 || gender == 2)
                return year + 1900;
            else
                return year + 2000;
        }
        public static int Calc_Age(int year, int nowyear)
        {
            return nowyear-year;
        }
        public static string Calc_Gender(int gender)
        {
            if (gender == 1 || gender == 3)
                return "남자";
            else
                return "여자";
        }
    }
}
